using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Interfaces;
using HantahaAPI.Core.Model.Response;
using Microsoft.EntityFrameworkCore;

namespace HantahaAPI.Data
{
    public class VerbItemRepository : GenericRepository<VerbItem>, IVerbItemRepository
    {
        private readonly DbSet<VerbItem> _dbSet;
        public VerbItemRepository(AppDbContext context) : base(context)
        {
            _dbSet = context.Set<VerbItem>();
        }

        public async Task<UserVerbListModel> GetUserVerbList(int pageNumber, string search)
        {
            int pageSize = 8;

            var query = _dbSet.Include(vi => vi.Verb)
                .Include(vi => vi.Language).ThenInclude(l => l.LanguageCountries).ThenInclude(lc => lc.Country)
                .Include(vi => vi.Verb).ThenInclude(v => v.SentenceVerbs).ThenInclude(sv => sv.Sentence).ThenInclude(s => s.SentenceItems).ThenInclude(si => si.Language)
                .Where(vi => vi.Verb.IsActive && !vi.Verb.IsDeleted && vi.Language.Name != "Türkçe" &&
                 (
                    vi.Context.Contains(search) ||
                    vi.Verb.SentenceVerbs.Any(sv => sv.Sentence.SentenceItems.Any(si => si.Context.ToLower().Contains(search.ToLower()) && si.Language.Name == vi.Language.Name))
                 ));

            // Son eklenenlere göre sıralama ekleyin
            query = query.OrderByDescending(vi => vi.CreatedOn);

            int itemCount = await query.CountAsync();
            int pageCount = (int)Math.Ceiling((double)itemCount / pageSize);
            int itemsToSkip = (pageNumber - 1) * pageSize;

            if (itemsToSkip < 0)
            {
                itemsToSkip = 0;
            }

            var userVerbList = await query
                .Skip(itemsToSkip)
                .Take(pageSize)
                .ToListAsync();

            var userVerbListModel = new UserVerbListModel
            {
                PageCount = pageCount,
                VerbItems = userVerbList
                .Select(vi => new UserVerbListItemModel
                {
                    VerbItemId = vi.Id,
                    Context = vi.Context,
                    LanguageName = vi.Language.Name,
                    CountryModel = vi.Language.LanguageCountries.Select(l => new CountryModel
                    {
                        Name = l.Country.Name,
                        EnglishName = l.Country.EnglishName,
                        ImageUrl = l.Country.ImageURL
                    }).OrderBy(c => c.Name).ToList(),
                    Sentences = vi.Verb.SentenceVerbs
                        .Where(sv => !sv.Sentence.IsDeleted && sv.Sentence.IsActive && sv.Sentence.SentenceItems.Any(si => si.Context.ToLower().Contains(search.ToLower()) && si.Language.Name == vi.Language.Name))
                        .SelectMany(sv => sv.Sentence.SentenceItems)
                        .Select(si => new SentenceModel { Context = si.Context, LanguageName = si.Language.Name })
                        .ToList()
                })
                .ToList()
            };

            return userVerbListModel;
        }

    }
}

