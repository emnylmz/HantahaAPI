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
    public class VerbController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IVerbService _verbService;

        public VerbController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            IVerbService verbService
            ) : base(httpContextAccessor)
        {
            _mapper = mapper;
            _verbService = verbService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
            var languages = await _verbService.List();
            return CreateActionResult(CustomResponseDto<List<VerbListModel>>.SuccessWithData(languages));
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<IActionResult> CreateOrUpdate(VerbCreateOrUpdateModel request)
        {
            bool result = await _verbService.CreateOrUpdate(request, UserId);

            if (result)
                return CreateActionResult(CustomResponseDto<List<LanguageListModel>>.SuccessWithoutData());
            else
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("işlem sırasında hata oluştu."));


        }

        [HttpPost("Remove")]
        public async Task<IActionResult> Remove(IdModel request)
        {
            //burada is deleted alanı eklenebilir
            var verb = await _verbService.GetByIdAsync(request.Id);
            verb.IsDeleted = true;
            await _verbService.UpdateAsync(verb);

            return CreateActionResult(CustomResponseDto<bool>.SuccessWithoutData());
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get(IdModel request)
        {
            var verb = await _verbService.GetVerbIncludeLanguagesAsync(request.Id);

            return CreateActionResult(CustomResponseDto<VerbCreateOrUpdateModel>.SuccessWithData(verb));
        }

    }


}

