using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface ITokenTrackerRepository : IGenericRepository<TokenTracker>
    {
        Task<TokenTracker> GetByToken(string token);
    }
}

