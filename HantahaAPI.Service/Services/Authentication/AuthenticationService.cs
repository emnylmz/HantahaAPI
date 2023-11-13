using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Enums;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model;
using HantahaAPI.Core.Model.Response;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HantahaAPI.Service.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly Settings _settings;

        public AuthenticationService(IOptions<Settings> settings)
        {
            _settings = settings.Value;
        }

        public AuthenticationResponse Login(User user, out DateTime expirationDate)
        {
            return GenerateToken(user, out expirationDate);
        }

        private AuthenticationResponse GenerateToken(User user, out DateTime expirationDate)
        {
            AuthenticationResponse authenticationResponse = new();

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.JWTSettings.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Username),
                new Claim(CustomClaimTypes.UserId,user.Id.ToString()),
                new Claim(ClaimTypes.Role,user.IsAdmin?"Admin":"User")
            };

            DateTime expireDate = DateTime.Now.AddMinutes(_settings.JWTSettings.ExpireMinutes);
            var token = new JwtSecurityToken(
            issuer: _settings.JWTSettings.Issuer,
             audience: _settings.JWTSettings.Audience,
            claims,
                expires: expireDate,
                signingCredentials: credentials);

            authenticationResponse.Token = new JwtSecurityTokenHandler().WriteToken(token);
            authenticationResponse.IsAdmin = user.IsAdmin;
            authenticationResponse.Email = user.Email;
            authenticationResponse.Firstname = user.Firstname;
            authenticationResponse.Lastname = user.Lastname;
            authenticationResponse.Username = user.Username;
            expirationDate = expireDate;
            return authenticationResponse;
        }

        public void LogOut()
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
        }

    }
}

