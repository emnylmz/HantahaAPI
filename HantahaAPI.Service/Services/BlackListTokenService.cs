using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;

namespace HantahaAPI.Service.Services
{
    public class BlackListTokenService : BaseService<BlackListToken>, IBlackListTokenService
    {
        private readonly IBlackListTokenRepository _blackListTokenRepository;

        public BlackListTokenService(IGenericRepository<BlackListToken> repository, IUnitOfWork unitOfWork,
            IBlackListTokenRepository blackListTokenRepository
            ) : base(repository, unitOfWork)
        {
            _blackListTokenRepository = blackListTokenRepository;
        }

        public async Task<bool> GetByToken(string token)
        {
           var invalidToken= await _blackListTokenRepository.GetByToken(token);

            return invalidToken == null ?false:true;
        }
    }
}

