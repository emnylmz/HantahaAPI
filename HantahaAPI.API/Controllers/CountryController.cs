using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    public class CountryController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IPasswordService _passwordService;

        public CountryController(
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

        [HttpGet("GetAll"),Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAllAsync();
            var userDtos = _mapper.Map<List<UserDto>>(users.ToList());
            return CreateActionResult(CustomResponseDto<List<UserDto>>.SuccessWithData(userDtos));
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            //şifre kontrolleri eşit mi güvenli mi vs.
            if (!_userService.ValidateUserPassword(userDto, out string validationMessage))
                return CreateActionResult(CustomResponseDto<string>.FailWithError(validationMessage));

            var user = _mapper.Map<User>(userDto);

            await _userService.AddAsync(user);

            return CreateActionResult(CustomResponseDto<List<UserDto>>.SuccessWithoutData());

        }

    }


}

