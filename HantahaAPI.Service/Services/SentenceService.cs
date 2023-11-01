using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Service.Services
{
    public class SentenceService : BaseService<Sentence>, ISentenceService
    {
        private readonly ISentenceRepository _sentenceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SentenceService(IGenericRepository<Sentence> repository, IUnitOfWork unitOfWork,
            ISentenceRepository sentenceRepository
            ) : base(repository, unitOfWork)
        {
            _sentenceRepository = sentenceRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateOrUpdate(SentenceCreateOrUpdateModel sentence, int userId)
        {
            //create
            if (sentence.Id == 0)
            {
                Sentence entinty = new();
                entinty.Name = sentence.Name;
                entinty.IsActive = sentence.IsActive;
                entinty.CreatedOn = DateTime.Now;
                entinty.CreatedBy = userId;
                entinty.SentenceItems = new List<SentenceItem>();
                //cümleler
                foreach (var verbItem in sentence.SentenceItems)
                {
                    SentenceItem sentenceItemEntity = new SentenceItem
                    {
                        Context = verbItem.Context,
                        LanguageId = verbItem.LanguageId,
                        CreatedBy = userId,
                        CreatedOn = DateTime.Now
                    };
                    entinty.SentenceItems.Add(sentenceItemEntity);
                }

                //cümle içinde geçen fiiller
                entinty.SentenceVerbs = new List<SentenceVerb>();
                foreach (var verbId in sentence.VerbIds)
                {
                    SentenceVerb verbEntity = new SentenceVerb
                    {
                        VerbId = verbId,
                        Sentence = entinty
                    };
                    entinty.SentenceVerbs.Add(verbEntity);
                }

                await _sentenceRepository.AddAsync(entinty);
                await _unitOfWork.CommitAsync();
                return true;
            }
            //update
            else
            {
                var entity = await _sentenceRepository.GetSentenceIncludeItemsAsync(sentence.Id);

                if (entity == null)
                {
                    return false;
                }

                entity.Name = sentence.Name;
                entity.IsActive = sentence.IsActive;
                entity.UpdatedOn = DateTime.Now;
                entity.UpdatedBy = userId;

                var existingItemIds = sentence.SentenceItems.Select(item => item.Id).ToList();

                foreach (var existingItem in entity.SentenceItems)
                    if (!existingItemIds.Contains(existingItem.Id))
                        entity.SentenceItems.Remove(existingItem);//remove


                //cümleler
                foreach (var sentenceItem in sentence.SentenceItems)
                {

                    if (sentenceItem.Id == 0)  //add
                    {
                        SentenceItem sentenceItemEntity = new SentenceItem
                        {
                            Context = sentenceItem.Context,
                            LanguageId = sentenceItem.LanguageId,
                            CreatedBy = userId,
                            CreatedOn = DateTime.Now
                        };
                        entity.SentenceItems.Add(sentenceItemEntity);
                    }
                    else  //update
                    {
                        var existingItem = entity.SentenceItems.FirstOrDefault(item => item.Id == sentenceItem.Id);
                        if (existingItem != null)
                        {
                            existingItem.Context = sentenceItem.Context;
                            existingItem.LanguageId = sentenceItem.LanguageId;
                            existingItem.UpdatedOn = DateTime.Now;
                            existingItem.UpdatedBy = userId;
                        }
                    }
                }

                entity.SentenceVerbs.Clear();
                foreach (var verbId in sentence.VerbIds)
                {
                    SentenceVerb verb = new SentenceVerb()
                    {
                        SentenceId = entity.Id,
                        VerbId = verbId,
                    };
                    entity.SentenceVerbs.Add(verb);
                }

                _sentenceRepository.Update(entity);
                await _unitOfWork.CommitAsync();

                return true;
            }

        }

        public async Task<SentenceWithVerbsModel> GetSentenceWithItemsAsync(int verbId)
        {
            return await _sentenceRepository.GetSentenceWithItemsAsync(verbId);
        }

        public async Task<List<SentenceListModel>> List()
        {
            return await _sentenceRepository.List();
        }
    }
}

