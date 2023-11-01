using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ISystemLogRepository : IGenericRepository<SystemLog>
    {
        Task<List<SystemLogListModel>> List();
    }
}

