using System.Net;
using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authenticationService;
        private readonly IBlackListTokenService _blackListTokenService;
        private readonly IUserService _userService;

        public AuthenticationController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IAuthenticationService authenticationService,
            IBlackListTokenService blackListTokenService,
            IUserService userService
            ) :base(httpContextAccessor)
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _blackListTokenService = blackListTokenService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            
            var user = await _userService.GetByEmail(loginDto.Email);

            if (user==null)
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("E-postaya ait kullanıcı bulunamadı."));

            if (!user.IsActive)
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Kullanıcı  "));

            bool passResult = await _userService.CheckPassAndGetUserAsync(loginDto);

            //user gelirse şifre doğru
            if (!passResult)
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("E-posta veya şifre hatalı"));

            else
            {
                string loginIp = GetIpAddress(HttpContext);
                
                var response = _authenticationService.Login(user);
                user.LastLoginIP = loginIp;
                user.LastLoginDate = DateTime.Now;
                await _userService.UpdateAsync(user);

                return CreateActionResult(CustomResponseDto<AuthenticationResponse>.SuccessWithData(response));
            }
        }

        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            var token = HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            BlackListToken blackListToken= new (){Token=token,ExpirationDate=DateTime.Now.AddMinutes(60) };

           await _blackListTokenService.AddAsync(blackListToken);

            return CreateActionResult(CustomResponseDto<bool>.SuccessWithoutData());
        }


        private string GetIpAddress(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress;

            // IPv6 döngüsel adresi (localhost) ise IPv4 döngüsel adresi (127.0.0.1) olarak değiştir
            if (ipAddress != null && ipAddress.Equals(IPAddress.IPv6Loopback))
            {
                ipAddress = IPAddress.Loopback;
            }

            // IPv6 adresini IPv4'e dönüştür
            if (ipAddress != null && ipAddress.IsIPv4MappedToIPv6)
            {
                ipAddress = ipAddress.MapToIPv4();
            }

            return ipAddress?.ToString();
        }
    }


}

