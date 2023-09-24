using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text.Json;
using HantahaAPI.Core.Enums;
using HantahaAPI.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HantahaAPI.API
{
    public class GlobalExceptionMiddleware : IMiddleware
    {
        private readonly ILogger _logger;

        public GlobalExceptionMiddleware(ILogger<GlobalExceptionMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

                if (!string.IsNullOrEmpty(token))
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwt = tokenHandler.ReadJwtToken(token);

                    // Token geçerliyse ve tarihi geçmemişse devam et
                    if (!IsTokenValid(jwt))
                    {
                        // Token geçersiz veya tarihi geçmişse isteği reddet
                        context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

                        ProblemDetails problemDetails = new()
                        {
                            Status = (int)HttpStatusCode.Unauthorized,
                            Type = "Authentication Error",
                            Title = "Unauthorized",
                            Detail = "Token is invalid or expired"
                        };

                        string json = JsonSerializer.Serialize(problemDetails);
                        context.Response.ContentType = "application/json";

                        await context.Response.WriteAsync(json);

                        return;
                    }
                }

                await next(context);
            }
            catch (Exception ex)
            {
                //burada db log işlemi eklenecek
                
                // Kullanıcının IP adresi
                var ipAddress = GetIpAddress(context);

                //request header
                var headers = context.Request.Headers;
                var headersString = string.Join("; ", headers.Select(h => $"{h.Key}: {h.Value}"));

                //diğer bilgiler
                var requestMethod = context.Request.Method;
                var requestPath = context.Request.Path;
                var requestQueryString = context.Request.QueryString;

                _logger.LogError(ex, ex.Message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                ProblemDetails problemDetails = new()
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Type = "Server Error",
                    Title = "Server Error",
                    Detail = ex.Message
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
            // Token geçerliliği ve tarih kontrolü burada yapılır
            if (jwt.ValidTo >= DateTime.UtcNow)
            {
                // Token geçerli ise true döner
                return true;
            }

            // Token tarihi geçmişse false döner
            return false;
        }
    }
}

