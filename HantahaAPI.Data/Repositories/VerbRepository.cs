using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class VerbRepository : GenericRepository<Verb>, IVerbRepository
    {
        private readonly DbSet<Verb> _dbSet;
        public VerbRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Verb>();
        }

        public async Task<VerbCreateOrUpdateModel> GetVerbIncludeLanguagesAsync(int verbId)
        {
            return await _dbSet.Include(t => t.VerbItems).Where(t => t.Id == verbId)
                .Select(l =>
                            new VerbCreateOrUpdateModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                VerbItems = l.VerbItems.Select(c => new VerbCreateOrUpdateModelItem
                                {
                                    Id = c.Id,
                                    LanguageId = c.LanguageId,
                                    VerbId = l.Id,
                                    Context = c.Context
                                }).ToList(),
                            }).FirstOrDefaultAsync();
        }

        //public async Task<LanguageWithCountriesModel> GetLanguageWithCountriesAsync(int languageId)
        //{
        //    return await
        //        _dbSet
        //        .Include(t => t.LanguageCountries).ThenInclude(u => u.Country)
        //        .Where(t => t.Id == languageId)
        //        .Select(l =>
        //                    new LanguageWithCountriesModel
        //                    {
        //                        Id = l.Id,
        //                        Name = l.Name,
        //                        IsActive = l.IsActive,
        //                        LanguageCountries = l.LanguageCountries.Select(c => new CountryComboModel
        //                        {
        //                            Id = c.CountryId,
        //                            ImageURL = c.Country.ImageURL,
        //                            Name = c.Country.Name
        //                        }).ToList(),
        //                    }).FirstOrDefaultAsync();
        //}

        public async Task<List<VerbListModel>> List()
        {
            return await
                _dbSet
                .Where(x => x.IsDeleted == false)
                .Select(l =>
                            new VerbListModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                CreatedOn = l.CreatedOn,
                                UpdatedOn = l.UpdatedOn,
                                CreatedBy = l.CreatedByUser.Firstname + " " + l.CreatedByUser.Lastname,
                                UpdatedBy = l.UpdatedByUser != null ? l.UpdatedByUser.Firstname + " " + l.UpdatedByUser.Lastname : null
                            })
                .OrderBy(i => i.CreatedOn).ToListAsync();
        }
    }
}

