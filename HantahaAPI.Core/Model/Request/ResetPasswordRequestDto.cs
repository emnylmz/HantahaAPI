namespace HantahaAPI.Core.Model.Request
{
    public class ResetPasswordRequestDto
    {
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public string ResetToken { get; set; }
    }
}
