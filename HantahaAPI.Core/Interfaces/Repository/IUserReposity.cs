using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> GetByUsername(string username);
        Task<List<User>> GetAll();
        Task<User> GetByEmail(string email);
    }
}

