﻿using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ICountryService : IService<Country>
    {
        Task<List<CountryComboModel>> GetAllCountries();
    }
}

