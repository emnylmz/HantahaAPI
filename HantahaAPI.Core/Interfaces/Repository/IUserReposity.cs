using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Interfaces
{
	public interface IUserRepository: IGenericRepository<User>
    {
        Task<User> GetByUsername(string username);
    }
}

