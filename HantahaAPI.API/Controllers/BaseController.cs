using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using HantahaAPI.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using HantahaAPI.Core.Enums;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http;
using AutoMapper;

namespace HantahaAPI.API.Controllers
{
    [Route("HantahaAPI/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly int UserId;

        public BaseController(IHttpContextAccessor httpContextAccessor)
        {
            var identity = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userId = identity.Claims.FirstOrDefault(x => x.Type == CustomClaimTypes.UserId)?.Value;
                if (userId != null)
                    UserId = Convert.ToInt32(userId);
            }
        }

        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            IActionResult result;

            if (response.StatusCode == (int)HttpStatusCode.NoContent)
            {
                result = new NoContentResult();
            }
            else
            {
                result = new ObjectResult(response)
                {
                    StatusCode = response.StatusCode
                };
            }

            return result;
        }
    }
}

