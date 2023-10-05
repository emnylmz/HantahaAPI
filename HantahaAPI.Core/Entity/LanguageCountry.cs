using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Entity
{
    public class LanguageCountry : BaseEntity
    {
        public int LanguageId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public Language Language { get; set; }
    }
}
