using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Service.Services
{
    public class SystemLogService : BaseService<SystemLog>, ISystemLogService
    {
        private readonly ISystemLogRepository _systemLogRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SystemLogService(IGenericRepository<SystemLog> repository, IUnitOfWork unitOfWork,
            ISystemLogRepository systemLogRepository
            ) : base(repository, unitOfWork)
        {
            _systemLogRepository = systemLogRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<SystemLogListModel>> List()
        {
            return await _systemLogRepository.List();
        }
    }
}

