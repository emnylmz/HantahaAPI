using System;

namespace HantahaAPI.Core.Entity
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}

