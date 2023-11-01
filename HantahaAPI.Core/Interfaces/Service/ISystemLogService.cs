using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ISystemLogService : IService<SystemLog>
    {
        Task<List<SystemLogListModel>> List();
    }
}

