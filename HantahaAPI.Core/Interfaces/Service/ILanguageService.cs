using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ILanguageService : IService<Language>
    {
        Task<List<LanguageListModel>> List();
        Task<List<ComboModel>> ComboList();
        Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId);
        Task<bool> CreateOrUpdate(LanguageCreateOrUpdateModel language, int userId);
    }
}

