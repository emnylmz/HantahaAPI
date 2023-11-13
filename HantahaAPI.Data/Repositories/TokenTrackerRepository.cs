using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class TokenTrackerRepository : GenericRepository<TokenTracker>, ITokenTrackerRepository
    {
        private readonly DbSet<TokenTracker> _dbSet;
        public TokenTrackerRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<TokenTracker>();
        }

        public async Task<TokenTracker> GetByToken(string token)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Token == token);
        }
    }
}

