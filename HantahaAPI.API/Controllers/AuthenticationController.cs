using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model;
using HantahaAPI.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    public class AuthenticationController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public AuthenticationController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IAuthenticationService authenticationService,
        IUserService userService
            ):base(httpContextAccessor)
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _userService.CheckPassAsync(loginDto);

            //user gelirse şifre doğru
            if (user == null)
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("Kullanıcı adı veya şifre hatalı"));

            else
            {
                var token =_authenticationService.Login(user);
                //kullanıcı rolü
                //kullanıcı menüleri
                return CreateActionResult(CustomResponseDto<string>.SuccessWithData(token));
            }
        }
    }


}

