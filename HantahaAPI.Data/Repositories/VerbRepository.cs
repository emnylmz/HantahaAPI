﻿using HantahaAPI.Core.Entity;
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


        public async Task<VerbCreateOrUpdateModel> GetVerbWithVerbItemsAsync(int verbId)
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

        public async Task<Verb> GetVerbIncludeVerbItemsAsync(int verbId)
        {
            return await
                _dbSet
                .Include(t => t.VerbItems)
                .Where(t => t.Id == verbId).FirstOrDefaultAsync();
        }

        public async Task<List<VerbListModel>> List()
        {
            return await
                _dbSet
                .Select(l =>
                            new VerbListModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                IsDeleted = l.IsDeleted,
                                CreatedOn = l.CreatedOn,
                                UpdatedOn = l.UpdatedOn,
                                CreatedBy = l.CreatedByUser.Firstname + " " + l.CreatedByUser.Lastname,
                                UpdatedBy = l.UpdatedByUser != null ? l.UpdatedByUser.Firstname + " " + l.UpdatedByUser.Lastname : null
                            })
                .OrderBy(i => i.CreatedOn).ToListAsync();
        }

        public async Task<List<ComboModel>> ComboList()
        {
            return await
                _dbSet
                .Where(x => x.IsActive == true && x.IsDeleted == false)
                .Select(l =>
                            new ComboModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                            }).
                OrderBy(i => i.Name).ToListAsync();
        }
    }
}

