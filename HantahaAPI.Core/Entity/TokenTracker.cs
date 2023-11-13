namespace HantahaAPI.Core.Entity
{
    public class TokenTracker
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int UserId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
