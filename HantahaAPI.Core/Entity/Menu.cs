using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HantahaAPI.Core.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        #nullable enable
        public int? ParentMenuId { get; set; }
        public string? Icon { get; set; }

        #nullable disable
        public string MenuText { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<MenuRole> MenuRoles { get; set; }
    }
}
