using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace HantahaAPI.Service.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(IGenericRepository<Country> repository, IUnitOfWork unitOfWork,
            ICountryRepository countryRepository
            ) : base(repository, unitOfWork)
        {
            _countryRepository = countryRepository;
        }

        public async Task<List<CountryComboModel>> GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }
    }
}

