using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IVerbRepository : IGenericRepository<Verb>
    {
        Task<List<VerbListModel>> List();

        //Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId);

        Task<VerbCreateOrUpdateModel> GetVerbIncludeLanguagesAsync(int verbId);
    }
}

