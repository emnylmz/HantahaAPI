namespace HantahaAPI.Core.Model.Response
{
    public class LanguageWithCountriesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<CountryComboModel> LanguageCountries { get; set; }
    }



}

