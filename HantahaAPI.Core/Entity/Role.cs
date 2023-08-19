using System;

namespace HantahaAPI.Core.Entity
{
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<MenuRole> MenuRoles { get; set; }

    }
}

