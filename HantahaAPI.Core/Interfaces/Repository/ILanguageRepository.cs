using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ILanguageRepository : IGenericRepository<Language>
    {
        Task<List<LanguageListModel>> List();

        Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId);

        Task<Language> GetLanguageIncludeCountriesAsync(int languageId);
    }
}

