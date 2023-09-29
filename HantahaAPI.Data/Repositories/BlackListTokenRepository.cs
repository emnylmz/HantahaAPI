using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class BlackListTokenRepository : GenericRepository<BlackListToken>,IBlackListTokenRepository
    {
        private readonly DbSet<BlackListToken> _dbSet;
        public BlackListTokenRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<BlackListToken>();
        }

        public async Task<BlackListToken> GetByToken(string token)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Token == token);
        }
    }
}

