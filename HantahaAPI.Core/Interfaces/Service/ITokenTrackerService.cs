using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface ITokenTrackerService : IService<TokenTracker>
    {
        Task<TokenTracker> GetByToken(string token);
    }
}

