using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Entity
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<LanguageCountry> LanguageCountries { get; set; }
    }
}
