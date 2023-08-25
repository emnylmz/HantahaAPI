using System;
using System.Linq.Expressions;
using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Interfaces
{
    public interface ICountryService:IService<Country>
    {
        Task<List<User>> GetAllCountries();
    }
}

