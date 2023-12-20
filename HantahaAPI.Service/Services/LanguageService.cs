using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Service.Services
{
    public class LanguageService : BaseService<Language>, ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LanguageService(IGenericRepository<Language> repository, IUnitOfWork unitOfWork,
            ILanguageRepository languageRepository
            ) : base(repository, unitOfWork)
        {
            _languageRepository = languageRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ComboModel>> ComboList()
        {
            return await _languageRepository.ComboList();
        }

        public async Task<bool> CreateOrUpdate(LanguageCreateOrUpdateModel language, int userId)
        {
            //create
            if (language.Id == 0)
            {
                Language entinty = new();
                entinty.Name = language.Name;
                entinty.EnglishName = language.EnglishName;
                entinty.IsActive = language.IsActive;
                entinty.CreatedOn = DateTime.Now;
                entinty.CreatedBy = userId;
                entinty.LanguageCountries = new List<LanguageCountry>();
                foreach (var countryId in language.LanguageCountries)
                {
                    LanguageCountry country = new LanguageCountry
                    {
                        CountryId = countryId,
                        CreatedBy = userId,
                        CreatedOn = DateTime.Now
                    };
                    entinty.LanguageCountries.Add(country);
                }
                await _languageRepository.AddAsync(entinty);
                await _unitOfWork.CommitAsync();
                return true;
            }
            //update
            else
            {
                var entity = await _languageRepository.GetLanguageIncludeCountriesAsync(language.Id);

                if (entity == null)
                {
                    return false;
                }
                entity.Name = language.Name;
                entity.IsActive = language.IsActive;
                entity.UpdatedOn = DateTime.Now;
                entity.UpdatedBy = userId;
                entity.EnglishName = language.EnglishName;

                entity.LanguageCountries.Clear();
                foreach (var countryId in language.LanguageCountries)
                {
                    LanguageCountry country = new LanguageCountry
                    {
                        CountryId = countryId,
                        CreatedBy = userId,
                        CreatedOn = DateTime.Now
                    };
                    entity.LanguageCountries.Add(country);
                }

                _languageRepository.Update(entity);
                await _unitOfWork.CommitAsync();

                return true;
            }

        }

        public async Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId)
        {
            return await _languageRepository.GetLanguageWithCountriesAsync(languageId);
        }

        public async Task<List<LanguageListModel>> List()
        {
            return await _languageRepository.List();
        }
    }
}

