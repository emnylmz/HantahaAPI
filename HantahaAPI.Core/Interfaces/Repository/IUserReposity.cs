using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetByUsername(string username);
        Task<List<UserListDto>> GetUserList();
        Task<User> GetByEmail(string email);
        Task<User> GetByResetToken(Guid resetToken);
    }
}

