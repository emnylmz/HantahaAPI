using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IBlackListTokenService : IService<BlackListToken>
    {
        Task<bool> GetByToken(string token);
    }
}

