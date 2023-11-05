using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IVerbItemRepository : IGenericRepository<VerbItem>
    {

        Task<UserVerbListModel> GetUserVerbList(int pageNumber, string search);
    }
}

