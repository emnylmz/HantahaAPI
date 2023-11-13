using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;

namespace HantahaAPI.Service.Services
{
    public class TokenTrackerService : BaseService<TokenTracker>, ITokenTrackerService
    {
        private readonly ITokenTrackerRepository _blackListTokenRepository;

        public TokenTrackerService(IGenericRepository<TokenTracker> repository, IUnitOfWork unitOfWork,
            ITokenTrackerRepository blackListTokenRepository
            ) : base(repository, unitOfWork)
        {
            _blackListTokenRepository = blackListTokenRepository;
        }

        public async Task<TokenTracker> GetByToken(string token)
        {
            return await _blackListTokenRepository.GetByToken(token);
        }
    }
}

