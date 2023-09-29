using System;
using System.Linq.Expressions;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> GetByUsername(string username);
        Task<List<UserListDto>> GetUserList();
        Task<User> GetByEmail(string email);
    }
}

