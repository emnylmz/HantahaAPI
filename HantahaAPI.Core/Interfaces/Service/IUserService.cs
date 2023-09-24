using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserService:IService<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> GetAll();
        Task<bool> CheckPassAndGetUserAsync(LoginDto loginDto);
        bool ValidateUserPassword(UserCreateDto userCreateDto, out string errorMessage);
    }
}

