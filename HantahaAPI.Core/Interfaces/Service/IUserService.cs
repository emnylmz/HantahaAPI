using System;
using System.Linq.Expressions;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserService:IService<User>
    {
        Task<User> CheckPassAsync(LoginDto loginDto);
    }
}

