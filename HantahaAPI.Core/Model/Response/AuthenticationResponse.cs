namespace HantahaAPI.Core.Model.Response
{
    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}

