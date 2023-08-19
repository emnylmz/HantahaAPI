using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HantahaAPI.Core.Entity
{
    public class MenuRole
    {
        public int MenuRoleId { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        public Menu Menu { get; set; }
        public Role Role { get; set; }
    }
}
