using HantahaAPI.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HantahaAPI.Core.Entity
{
    public class Feedback:BaseEntity
    {
        public string Topic { get; set; }
        public string Description { get; set; }
        public bool ReadStatus { get; set; }

        public User User { get; set; }
    }
}
