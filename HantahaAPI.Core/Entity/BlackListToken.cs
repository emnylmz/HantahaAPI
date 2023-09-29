
using System.Numerics;

namespace HantahaAPI.Core.Entity
{
    public class BlackListToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
