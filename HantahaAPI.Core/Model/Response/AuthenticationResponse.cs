using System;

namespace HantahaAPI.Core.Model.Response
{
    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public bool IsAdmin { get; set; }
    }
}

