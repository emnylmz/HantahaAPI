using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IVerbService : IService<Verb>
    {
        //bakılack
        Task<List<VerbListModel>> List();
        Task<VerbCreateOrUpdateModel> GetVerbWithVerbItemsAsync(int verbId);
        Task<bool> CreateOrUpdate(VerbCreateOrUpdateModel verb, int userId);
        Task<List<ComboModel>> ComboList();
    }
}

