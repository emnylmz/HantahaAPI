using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserService : IService<User>
    {
        Task<User> GetByEmail(string email);
        Task ResetPassword(ResetPasswordRequestDto request);
        Task<List<UserListDto>> GetUserList();
        Task<bool> CheckPassAndGetUserAsync(LoginDto loginDto);
        Task UpdateAsync(UserUpdateDto updateDto, int updatedBy);
        bool ValidateUserPassword(UserCreateDto userCreateDto, out string errorMessage);
    }
}

