using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DbSet<User> _dbSet;
        public UserRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<User>();
        }

        public async Task<List<UserListDto>> GetUserList()
        {
            var users = await _dbSet
            .Include(x => x.Country)
            .AsNoTracking()
            .Select(x => new UserListDto
            {
                Id = x.Id,
                Username = x.Username,
                Email = x.Email,
                IsActive = x.IsActive,
                Fullname = x.Firstname + " " + x.Lastname,
                LastLoginDate = x.LastLoginDate.Value,
                LastLoginIP = x.LastLoginIP,
                CreatedOn = x.CreatedOn,
                IsAdmin = x.IsAdmin,
                UserVisibilityType = x.UserVisibilityType,
                Country = x.Country.Name
            })
            .ToListAsync();
            return users;
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetByResetToken(Guid resetToken)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.ResetToken == resetToken);
        }

        public async Task<User> GetByUsername(string username)
        {
            return await _dbSet.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}

