using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class SystemLogRepository : GenericRepository<SystemLog>, ISystemLogRepository
    {
        private readonly DbSet<SystemLog> _dbSet;
        public SystemLogRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<SystemLog>();
        }

        public async Task<List<SystemLogListModel>> List()
        {
            return await _dbSet.Include(t => t.User)
                .Select(i => new SystemLogListModel
                {
                    UserFullname = i.User != null ? i.User.Firstname + " " + i.User.Lastname : null,
                    RequestQueryString = i.RequestQueryString,
                    Date = i.Date,
                    IpAddress = i.IpAddress,
                    Source = i.ExceptionSource,
                    Url = i.ExceptionUrl,
                    Message = i.ExceptionMessage
                })
                .OrderBy(i => i.Date).ToListAsync();
        }
    }
}

