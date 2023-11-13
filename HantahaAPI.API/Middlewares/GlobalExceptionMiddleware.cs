using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Enums;
using HantahaAPI.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Text.Json;

namespace HantahaAPI.API
{
    public class GlobalExceptionMiddleware : IMiddleware
    {
        private readonly ITokenTrackerService _tokenTrackerService;
        private readonly ISystemLogService _systemLogService;

        public GlobalExceptionMiddleware(ITokenTrackerService tokenTrackerService, ISystemLogService systemLogService)
        {
            _tokenTrackerService = tokenTrackerService;
            _systemLogService = systemLogService;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

                var ipAddress = GetIpAddress(context);

                if (!string.IsNullOrEmpty(token))
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwt = tokenHandler.ReadJwtToken(token);

                    if (!IsTokenValid(jwt))
                    {
                        DenyRequest(context, HttpStatusCode.Unauthorized, "Token is invalid");
                        return;
                    }

                    TokenTracker tokenTracker = await _tokenTrackerService.GetByToken(token);

                    if (tokenTracker == null)
                    {
                        DenyRequest(context, HttpStatusCode.Unauthorized, "Token is expired");
                        return;
                    }
                }
                await next(context);
            }
            catch (Exception ex)
            {

                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                string userId = null;


                if (!string.IsNullOrEmpty(token))
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwt = tokenHandler.ReadJwtToken(token);
                    var userIdClaim = jwt.Claims.FirstOrDefault(claim => claim.Type == CustomClaimTypes.UserId);

                    userId = userIdClaim?.Value;
                }


                // Kullanıcının IP adresi
                var ipAddress = GetIpAddress(context);
                var headers = context.Request.Headers;
                var headersString = string.Join("; ", headers.Select(h => $"{h.Key}: {h.Value}"));
                var requestPath = context.Request.Path;
                var requestQueryString = context.Request.QueryString;

                await _systemLogService.AddAsync(
                    new SystemLog
                    {
                        Date = DateTime.Now,
                        UserId = string.IsNullOrWhiteSpace(userId) ? null : Convert.ToInt32(userId),
                        ExceptionMessage = ex.Message,
                        ExceptionSource = ex.Source,
                        RequestQueryString = requestQueryString.ToString(),
                        IpAddress = ipAddress,
                        ExceptionUrl = requestPath,
                        HeaderString = headersString,
                    });

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails problemDetails = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error",
                    Title = "Server Error",
                    Detail = "Hata sizde değil bizde."
                };

                string json = JsonSerializer.Serialize(problemDetails);
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsync(json);

            }
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

        private bool IsTokenValid(JwtSecurityToken jwt)
        {
            // Mevcut zamanı kullanmak yerine UTC zamanını kullanın
            var utcNow = DateTime.UtcNow;

            // Tokenin son kullanma tarihini UTC saat dilimine dönüştürün
            var validToUtc = jwt.ValidTo.ToUniversalTime();

            // Token geçerliliği ve tarih kontrolü burada yapılır
            if (validToUtc >= utcNow)
            {
                // Token geçerli ise true döner
                return true;
            }

            // Token tarihi geçmişse false döner
            return false;
        }

        private void DenyRequest(HttpContext context, HttpStatusCode statusCode, string detail)
        {
            context.Response.StatusCode = (int)statusCode;

            ProblemDetails problemDetails = new()
            {
                Status = (int)statusCode,
                Type = "Authentication Error",
                Title = "Unauthorized",
                Detail = detail
            };

            string json = JsonSerializer.Serialize(problemDetails);
            context.Response.ContentType = "application/json";

            context.Response.WriteAsync(json);
        }
    }
}

