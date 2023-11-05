using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IVerbItemService : IService<VerbItem>
    {
        Task<UserVerbListModel> GetUserVerbList(int pageNumber, string search);
    }
}

