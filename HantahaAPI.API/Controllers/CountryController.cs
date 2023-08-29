using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
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
        private readonly ICountryService _countryService;

        public CountryController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            ICountryService countryService
            ) : base(httpContextAccessor)
        {
            _mapper = mapper;
            _countryService = countryService;
        }

        [HttpGet("GetAllCountries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var allCountries = await _countryService.GetAllCountries();
            return CreateActionResult(CustomResponseDto<List<CountryComboModel>>.SuccessWithData(allCountries));
        }

    }


}

