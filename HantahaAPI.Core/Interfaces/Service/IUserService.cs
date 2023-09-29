using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserService:IService<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<UserListDto>> GetUserList();
        Task<bool> CheckPassAndGetUserAsync(LoginDto loginDto);
        Task UpdateAsync(UserUpdateDto updateDto,int updatedBy);
        bool ValidateUserPassword(UserCreateDto userCreateDto, out string errorMessage);
    }
}

