using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IVerbRepository : IGenericRepository<Verb>
    {
        Task<List<VerbListModel>> List();
        Task<VerbCreateOrUpdateModel> GetVerbWithVerbItemsAsync(int verbId);
        Task<Verb> GetVerbIncludeVerbItemsAsync(int verbId);
        Task<List<ComboModel>> ComboList();
    }
}

