using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HantahaAPI.Core.Entity
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string ImageURL { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
