using AutoMapper;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace HantahaAPI.API.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SystemLogController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ISystemLogService _systemLogService;

        public SystemLogController(
            IHttpContextAccessor httpContextAccessor,
            IMapper mapper,
            ISystemLogService systemLogService
            ) : base(httpContextAccessor)
        {
            _mapper = mapper;
            _systemLogService = systemLogService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAllCountries()
        {
            var errors = await _systemLogService.List();
            return CreateActionResult(CustomResponseDto<List<SystemLogListModel>>.SuccessWithData(errors));
        }

    }


}

