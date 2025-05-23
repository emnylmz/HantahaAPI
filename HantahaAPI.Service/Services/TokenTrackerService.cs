﻿using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;

namespace HantahaAPI.Service.Services
{
    public class TokenTrackerService : BaseService<TokenTracker>, ITokenTrackerService
    {
        private readonly ITokenTrackerRepository _tokenTrackerRepository;

        public TokenTrackerService(IGenericRepository<TokenTracker> repository, IUnitOfWork unitOfWork,
            ITokenTrackerRepository tokenTrackerRepository
            ) : base(repository, unitOfWork)
        {
            _tokenTrackerRepository = tokenTrackerRepository;
        }

        public async Task<TokenTracker> GetByToken(string token)
        {
            return await _tokenTrackerRepository.GetByToken(token);
        }
    }
}

