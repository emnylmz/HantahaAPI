using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface IBlackListTokenRepository : IGenericRepository<BlackListToken>
    {
        Task<BlackListToken> GetByToken(string token);
    }
}

