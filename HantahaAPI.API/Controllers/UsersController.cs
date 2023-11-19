using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Interfaces.Service;
using HantahaAPI.Core.Model.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IMailService _mailService;

        public UsersController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            IMailService mailService,
            IUserService userService
            ) : base(httpContextAccessor)
        {
            _userService = userService;
            _mapper = mapper;
            _mailService = mailService;
        }

        [HttpGet("GetAll")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetUserList();
            return CreateActionResult(CustomResponseDto<List<UserListDto>>.SuccessWithData(users));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserCreateDto userCreateDto)
        {
            if (!_userService.ValidateUserPassword(userCreateDto, out string validationMessage))
                return CreateActionResult(CustomResponseDto<string>.FailWithError(validationMessage));

            var user = _mapper.Map<User>(userCreateDto);
            user.ResetToken = new Guid();
            await _userService.AddAsync(user);

            return CreateActionResult(CustomResponseDto<UserUpdateDto>.SuccessWithoutData());
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequestDto requestDto)
        {
            if (String.IsNullOrWhiteSpace(requestDto.Email))
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Lütfen e-posta giriniz.", HttpStatusCode.OK));

            User user = await _userService.GetByEmail(requestDto.Email);
            if (user == null)
                return CreateActionResult(CustomResponseDto<string>.FailWithError("E-postaya ait kullanıcı bulunamadı.", HttpStatusCode.OK));

            if (user.LastCreationDateOfResetToken != null && user.LastCreationDateOfResetToken.Value.AddHours(2) > DateTime.Now)
                return CreateActionResult(CustomResponseDto<string>.FailWithError("Size şifre sıfırlama maili göndermiştik. Lütfen mail ve spam kutunuzu kontrol ediniz.", HttpStatusCode.OK));

            string body = string.Empty;
            //using streamreader for reading my htmltemplate
            using (StreamReader reader = new StreamReader(Path.Combine("wwwroot\\EmailTemplates", "ForgotPassword.html")))
            {
                body = reader.ReadToEnd();
            }

            user.LastCreationDateOfResetToken = DateTime.Now;
            user.ResetToken = Guid.NewGuid();
            string token = user.ResetToken.ToString();

            string fullName = user.Firstname + " " + user.Lastname;

            body = body.Replace("{0}", fullName);
            body = body.Replace("{1}", token);

            await _mailService.SendMailAsync(new MailDataDto
            {
                EmailSubject = "Hantaha | Şifremi Unuttum",
                Email = requestDto.Email,
                EmailBody = body,
                EmailToName = user.Firstname + " " + user.Lastname
            }); ;

            await _userService.UpdateAsync(user);

            return CreateActionResult(CustomResponseDto<UserUpdateDto>.SuccessWithoutData());
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequestDto requestDto)
        {
            if (String.IsNullOrWhiteSpace(requestDto.Password))
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Lütfen şifre giriniz.", HttpStatusCode.OK));

            if (String.IsNullOrWhiteSpace(requestDto.RepeatPassword))
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Lütfen şifre tekrar giriniz.", HttpStatusCode.OK));

            if (requestDto.Password != requestDto.RepeatPassword)
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Şifre ve şifre tekrar alanları eşleşmiyor.", HttpStatusCode.OK));

            await _userService.ResetPassword(requestDto);

            return CreateActionResult(CustomResponseDto<UserUpdateDto>.SuccessWithoutData());
        }

        [HttpPost("Update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            await _userService.UpdateAsync(userUpdateDto, UserId);

            return CreateActionResult(CustomResponseDto<UserUpdateDto>.SuccessWithoutData());

        }

    }


}

