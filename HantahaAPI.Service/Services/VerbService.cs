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
                var entity = await _verbRepository.GetVerbIncludeLanguagesAsync(verb.Id);

                if (entity == null)
                {
                    return false;
                }
                //entity.Name = verb.Name;
                //entity.IsActive = verb.IsActive;
                //entity.UpdatedOn = DateTime.Now;
                //entity.UpdatedBy = userId;
                //todo

                //deleted olanları bul
                //güncellenecekleri bul
                //yeni eklenenleri bul

                //foreach (var countryId in language.LanguageCountries)
                //{
                //    LanguageCountry country = new LanguageCountry
                //    {
                //        CountryId = countryId,
                //        CreatedBy = userId,
                //        CreatedOn = DateTime.Now
                //    };
                //    entity.LanguageCountries.Add(country);
                //}

                //_languageRepository.Update(entity);
                //await _unitOfWork.CommitAsync();

                return true;
            }

        }

        public async Task<VerbCreateOrUpdateModel> GetVerbIncludeLanguagesAsync(int verbId)
        {
            return await _verbRepository.GetVerbIncludeLanguagesAsync(verbId);
        }

        public async Task<List<VerbListModel>> List()
        {
            return await _verbRepository.List();
        }
    }
}

