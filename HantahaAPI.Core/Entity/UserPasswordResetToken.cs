using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HantahaAPI.Core.Entity
{
    public class UserPasswordResetToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime ExpirationTime { get; set; }
        public DateTime CreatedOn { get; set; }

        public User User { get; set; }
    }
}
