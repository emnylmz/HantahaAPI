using HantahaAPI.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace HantahaAPI.Core.Entity
{
    //oluşturulmaya göre sırala
    public class SentenceItem : BaseEntity
    {
        public string Context { get; set; }
        public int LanguageId { get; set; }

        [ForeignKey("SentenceId")]
        public int SentenceId { get; set; }

        public Sentence Sentence { get; set; }

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
