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
    public class SentenceController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ISentenceService _sentenceService;

        public SentenceController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            IConfiguration configuration,
            ISentenceService sentenceService
            ) : base(httpContextAccessor)
        {
            _mapper = mapper;
            _sentenceService = sentenceService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
            var sentences = await _sentenceService.List();
            return CreateActionResult(CustomResponseDto<List<SentenceListModel>>.SuccessWithData(sentences));
        }

        [HttpPost("CreateOrUpdate")]
        public async Task<IActionResult> CreateOrUpdate(SentenceCreateOrUpdateModel request)
        {
            bool result = await _sentenceService.CreateOrUpdate(request, UserId);

            if (result)
                return CreateActionResult(CustomResponseDto<List<LanguageListModel>>.SuccessWithoutData());
            else
                return CreateActionResult(CustomResponseDto<List<string>>.FailWithError("işlem sırasında hata oluştu."));

        }

        [HttpPost("SetIsDeleted")]
        public async Task<IActionResult> SetIsDeleted(IdModel request)
        {
            var sentence = await _sentenceService.GetByIdAsync(request.Id);
            sentence.IsDeleted = !sentence.IsDeleted;
            await _sentenceService.UpdateAsync(sentence);

            return CreateActionResult(CustomResponseDto<bool>.SuccessWithoutData());
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get(IdModel request)
        {
            var sentence = await _sentenceService.GetSentenceWithItemsAsync(request.Id);

            return CreateActionResult(CustomResponseDto<SentenceWithVerbsModel>.SuccessWithData(sentence));
        }

    }


}

