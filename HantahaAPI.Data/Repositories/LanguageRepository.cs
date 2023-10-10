using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        private readonly DbSet<Language> _dbSet;
        public LanguageRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Language>();
        }

        public async Task<List<LanguageComboModel>> ComboList()
        {
            return await
                _dbSet
                .Where(x => x.IsActive == true)
                .Select(l =>
                            new LanguageComboModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                            }).
                OrderBy(i => i.Name).ToListAsync();
        }

        public async Task<Language> GetLanguageIncludeCountriesAsync(int languageId)
        {
            return await _dbSet.Include(t => t.LanguageCountries).FirstOrDefaultAsync(x => x.Id == languageId);
        }

        public async Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId)
        {
            return await
                _dbSet
                .Include(t => t.LanguageCountries).ThenInclude(u => u.Country)
                .Where(t => t.Id == languageId)
                .Select(l =>
                            new LanguageWithCountriesModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                LanguageCountries = l.LanguageCountries.Select(c => new CountryComboModel
                                {
                                    Id = c.CountryId,
                                    ImageURL = c.Country.ImageURL,
                                    Name = c.Country.Name
                                }).ToList(),
                            }).FirstOrDefaultAsync();
        }

        public async Task<List<LanguageListModel>> List()
        {
            return await
                _dbSet
                .Select(l =>
                            new LanguageListModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                CreatedOn = l.CreatedOn,
                                UpdatedOn = l.UpdatedOn,
                                CreatedBy = l.CreatedByUser.Firstname + " " + l.CreatedByUser.Lastname,
                                UpdatedBy = l.UpdatedByUser != null ? l.UpdatedByUser.Firstname + " " + l.UpdatedByUser.Lastname : null
                            }).
                OrderBy(i => i.Name).ToListAsync();
        }
    }
}

