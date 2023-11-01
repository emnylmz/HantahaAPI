using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HantahaAPI.API.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LanguageController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ILanguageService _languageService;

        public LanguageController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            ILanguageService languageService
            ) : base(httpContextAccessor)
        {
            _mapper = mapper;
            _languageService = languageService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
            var languages = await _languageService.List();
            return CreateActionResult(CustomResponseDto<List<LanguageListModel>>.SuccessWithData(languages));
        }

        [HttpGet("ComboList")]
        public async Task<IActionResult> ComboList()
        {
            var languages = await _languageService.ComboList();
            return CreateActionResult(CustomResponseDto<List<ComboModel>>.SuccessWithData(languages));
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<IActionResult> CreateOrUpdate(LanguageCreateOrUpdateModel request)
        {
            bool result = await _languageService.CreateOrUpdate(request, UserId);

            if (result)
                return CreateActionResult(CustomResponseDto<List<LanguageListModel>>.SuccessWithoutData());
            else
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("işlem sırasında hata oluştu."));


        }

        [HttpPost("Remove")]
        public async Task<IActionResult> Remove(IdModel request)
        {
            //burada is deleted alanı eklenebilir
            var language = await _languageService.GetByIdAsync(request.Id);
            await _languageService.RemoveAsync(language);

            return CreateActionResult(CustomResponseDto<List<LanguageListModel>>.SuccessWithoutData());
        }

        [HttpPost("GetLanguage")]
        public async Task<IActionResult> GetLanguage(IdModel request)
        {
            var language = await _languageService.GetLanguageWithCountriesAsync(request.Id);

            return CreateActionResult(CustomResponseDto<LanguageWithCountriesModel>.SuccessWithData(language));
        }

    }


}

