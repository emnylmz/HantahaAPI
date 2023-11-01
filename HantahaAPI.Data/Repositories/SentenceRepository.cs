using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class SentenceRepository : GenericRepository<Sentence>, ISentenceRepository
    {
        private readonly DbSet<Sentence> _dbSet;
        public SentenceRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<Sentence>();
        }


        public async Task<SentenceWithVerbsModel> GetSentenceWithItemsAsync(int sentenceId)
        {
            return await _dbSet.Include(t => t.SentenceItems).Include(t => t.SentenceVerbs)
                .Where(t => t.Id == sentenceId)
                .Select(l =>
                            new SentenceWithVerbsModel
                            {
                                Id = l.Id,
                                Name = l.Name,
                                IsActive = l.IsActive,
                                SentenceItems = l.SentenceItems.Select(c => new SentenceItem
                                {
                                    Id = c.Id,
                                    LanguageId = c.LanguageId,
                                    SentenceId = l.Id,
                                    Context = c.Context
                                }).ToList(),
                                Verbs = l.SentenceVerbs.Select(x => new ComboModel { Id = x.VerbId, Name = x.Verb.Name }).ToList(),
                            }).FirstOrDefaultAsync();
        }

        public async Task<Sentence> GetSentenceIncludeItemsAsync(int sentenceId)
        {
            return await
                _dbSet
                .Include(t => t.SentenceItems)
                .Include(t => t.SentenceVerbs)
                .Where(t => t.Id == sentenceId).FirstOrDefaultAsync();
        }

        public async Task<List<SentenceListModel>> List()
        {
            return await
                _dbSet
                .Select(l =>
                            new SentenceListModel
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
    }
}

