namespace HantahaAPI.Core.Model.Response
{
    public class UserVerbListModel
    {
        public int PageCount { get; set; }
        public List<UserVerbListItemModel> VerbItems { get; set; }
    }


    public class UserVerbListItemModel
    {
        public int VerbItemId { get; set; }
        public string Context { get; set; } // fiil
        public string LanguageName { get; set; } //dil
        public List<CountryModel> CountryModel { get; set; } //ülkeler
        public List<SentenceModel> Sentences { get; set; } //cümleler sadece o dile aitler gelmeli
    }

    public class CountryModel
    {
        public string Name { get; set; }
        public string EnglishName { get; set; }
        public string ImageUrl { get; set; }
    }

    public class SentenceModel
    {
        public string LanguageName { get; set; }
        public string Context { get; set; }
    }

}
