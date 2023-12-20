using HantahaAPI.Core.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace HantahaAPI.Core.Entity
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<LanguageCountry> LanguageCountries { get; set; }
        [ForeignKey("CreatedBy")]
        public User CreatedByUser { get; set; }
#nullable enable
        [ForeignKey("UpdatedBy")]
        public User? UpdatedByUser { get; set; }
#nullable disable
    }
}
