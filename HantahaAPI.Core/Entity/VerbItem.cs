using HantahaAPI.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace HantahaAPI.Core.Entity
{
    //oluşturulmaya göre sırala
    public class VerbItem : BaseEntity
    {
        public string Context { get; set; }
        public int LanguageId { get; set; }

        [ForeignKey("VerbId")]
        public int VerbId { get; set; }

        public Verb Verb { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }

        [ForeignKey("CreatedBy")]
        public User CreatedByUser { get; set; }
#nullable enable
        [ForeignKey("UpdatedBy")]
        public User? UpdatedByUser { get; set; }
#nullable disable
    }
}
