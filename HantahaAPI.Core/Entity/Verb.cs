using HantahaAPI.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace HantahaAPI.Core.Entity
{
    //oluşturulmaya göre sırala
    public class Verb : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<VerbItem> VerbItems { get; set; }

        [ForeignKey("CreatedBy")]
        public User CreatedByUser { get; set; }
#nullable enable
        [ForeignKey("UpdatedBy")]
        public User? UpdatedByUser { get; set; }
#nullable disable
    }
}
