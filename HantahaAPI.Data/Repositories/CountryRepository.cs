using System;
using System.Linq.Expressions;
using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class CountryRepository : GenericRepository<Country>,ICountryRepository
    {
        private readonly DbSet<Country> _dbSet;
        public CountryRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Country>();
        }

        public async Task<List<CountryComboModel>> GetAllCountries()
        {
            return await _dbSet.Select(i => new CountryComboModel { Id = i.Id, ImageURL = i.ImageURL, Name = i.Name }).OrderBy(i => i.Name).ToListAsync();
        }
    }
}

