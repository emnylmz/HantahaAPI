using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Service.Services
{
    public class VerbItemService : BaseService<VerbItem>, IVerbItemService
    {
        private readonly IVerbItemRepository _verbItemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VerbItemService(IGenericRepository<VerbItem> repository, IUnitOfWork unitOfWork,
            IVerbItemRepository verbItemRepository
            ) : base(repository, unitOfWork)
        {
            _verbItemRepository = verbItemRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<UserVerbListModel> GetUserVerbList(int pageNumber, string search)
        {
            return await _verbItemRepository.GetUserVerbList(pageNumber, search);
        }
    }
}

