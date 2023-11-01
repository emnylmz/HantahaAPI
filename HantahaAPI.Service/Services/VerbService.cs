using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Service.Services
{
    public class VerbService : BaseService<Verb>, IVerbService
    {
        private readonly IVerbRepository _verbRepository;
        private readonly IUnitOfWork _unitOfWork;

        public VerbService(IGenericRepository<Verb> repository, IUnitOfWork unitOfWork,
            IVerbRepository verbRepository
            ) : base(repository, unitOfWork)
        {
            _verbRepository = verbRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ComboModel>> ComboList()
        {
            return await _verbRepository.ComboList();
        }

        public async Task<bool> CreateOrUpdate(VerbCreateOrUpdateModel verb, int userId)
        {
            //create
            if (verb.Id == 0)
            {
                Verb entinty = new();
                entinty.Name = verb.Name;
                entinty.IsActive = verb.IsActive;
                entinty.CreatedOn = DateTime.Now;
                entinty.CreatedBy = userId;
                entinty.VerbItems = new List<VerbItem>();
                foreach (var verbItem in verb.VerbItems)
                {
                    VerbItem verbItemEntity = new VerbItem
                    {
                        Context = verbItem.Context,
                        LanguageId = verbItem.LanguageId,
                        CreatedBy = userId,
                        CreatedOn = DateTime.Now
                    };
                    entinty.VerbItems.Add(verbItemEntity);
                }
                await _verbRepository.AddAsync(entinty);
                await _unitOfWork.CommitAsync();
                return true;
            }
            //update
            else
            {
                var entity = await _verbRepository.GetVerbIncludeVerbItemsAsync(verb.Id);

                if (entity == null)
                {
                    return false;
                }

                entity.Name = verb.Name;
                entity.IsActive = verb.IsActive;
                entity.UpdatedOn = DateTime.Now;
                entity.UpdatedBy = userId;

                var existingItemIds = verb.VerbItems.Select(item => item.Id).ToList();

                foreach (var existingItem in entity.VerbItems)
                    if (!existingItemIds.Contains(existingItem.Id))
                        entity.VerbItems.Remove(existingItem);//remove


                foreach (var verbItem in verb.VerbItems)
                {

                    if (verbItem.Id == 0)  //add
                    {
                        VerbItem verbItemEntity = new VerbItem
                        {
                            Context = verbItem.Context,
                            LanguageId = verbItem.LanguageId,
                            CreatedBy = userId,
                            CreatedOn = DateTime.Now
                        };
                        entity.VerbItems.Add(verbItemEntity);
                    }
                    else  //update
                    {
                        var existingItem = entity.VerbItems.FirstOrDefault(item => item.Id == verbItem.Id);
                        if (existingItem != null)
                        {
                            existingItem.Context = verbItem.Context;
                            existingItem.LanguageId = verbItem.LanguageId;
                            existingItem.UpdatedOn = DateTime.Now;
                            existingItem.UpdatedBy = userId;
                        }
                    }
                }

                _verbRepository.Update(entity);
                await _unitOfWork.CommitAsync();

                return true;
            }

        }

        public async Task<VerbCreateOrUpdateModel> GetVerbWithVerbItemsAsync(int verbId)
        {
            return await _verbRepository.GetVerbWithVerbItemsAsync(verbId);
        }

        public async Task<List<VerbListModel>> List()
        {
            return await _verbRepository.List();
        }
    }
}

