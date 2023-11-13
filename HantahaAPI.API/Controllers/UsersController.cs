using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;

        public UsersController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            IPasswordService passwordService,
            IUserService userService
            ) : base(httpContextAccessor)
        {
            _userService = userService;
            _mapper = mapper;
            _passwordService = passwordService;
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
            user.ForgotPasswordKey = new Guid();
            await _userService.AddAsync(user);

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

