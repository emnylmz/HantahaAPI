namespace HantahaAPI.Core.Model.Request
{
    public class LanguageCreateOrUpdateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public bool IsActive { get; set; }
        public int[] LanguageCountries { get; set; }
    }
}
