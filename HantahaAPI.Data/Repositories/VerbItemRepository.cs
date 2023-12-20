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

            var query = _dbSet.Include(vi => vi.Verb).ThenInclude(v => v.VerbItems).ThenInclude(vi => vi.Language)
                .Include(vi => vi.Language).ThenInclude(l => l.LanguageCountries).ThenInclude(lc => lc.Country)
                .Include(vi => vi.Verb).ThenInclude(v => v.SentenceVerbs).ThenInclude(sv => sv.Sentence).ThenInclude(s => s.SentenceItems).ThenInclude(si => si.Language).ThenInclude(l => l.LanguageCountries).ThenInclude(lc => lc.Country)
                .Where(vi => vi.Verb.IsActive && !vi.Verb.IsDeleted && vi.Language.Name != "Türkçe" && vi.Verb.VerbItems.Any(x => x.Language.Name == "Türkçe")
                  &&
                    (vi.Context.ToLower().Contains(search.ToLower()) || vi.Verb.VerbItems.Any(vi => vi.Context.ToLower().Contains(search.ToLower())))
                 //vi.Verb.SentenceVerbs.Any(sv => sv.Sentence.SentenceItems.Any(si => si.Context.ToLower().Contains(search.ToLower()) && si.Language.Name == vi.Language.Name))
                 );

            query = query.OrderBy(u => Guid.NewGuid());

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
            .ToArrayAsync();

            Random.Shared.Shuffle(userVerbList);

            var userVerbListModel = new UserVerbListModel
            {
                PageCount = pageCount,
                VerbItems = userVerbList
        .Select(vi => new UserVerbListItemModel
        {
            VerbItemId = vi.Id,
            Context = vi.Context,
            TurkishContext = vi.Verb.VerbItems.FirstOrDefault(x => x.Language.Name == "Türkçe").Context,
            LanguageName = vi.Language.EnglishName,
            CountryModel = vi.Language.LanguageCountries.Select(l => new CountryModel
            {
                Name = l.Country.Name,
                EnglishName = l.Country.EnglishName,
                ImageUrl = l.Country.ImageURL
            }).OrderBy(c => c.Name).ToList(),
            Sentences = vi.Verb.SentenceVerbs
                .Where(sv => !sv.Sentence.IsDeleted && sv.Sentence.IsActive /*&& sv.Sentence.SentenceItems.Any(si => si.Context.ToLower().Contains(search.ToLower()) && si.Language.Name == vi.Language.Name)*/)
                .SelectMany(sv => sv.Sentence.SentenceItems)
                .GroupBy(si => si.Language.Name) // Dil bazında grupla
                .Select(group => new SentenceModel
                {
                    Context = string.Join("\n", group.Select(si => si.Context)),
                    LanguageName = group.Key,
                    CountryModel = group.SelectMany(si => si.Language.LanguageCountries).Distinct()
                        .Select(siL => new CountryModel
                        {
                            Name = siL.Country.Name,
                            EnglishName = siL.Country.EnglishName,
                            ImageUrl = siL.Country.ImageURL
                        }).OrderBy(siL => siL.Name).ToList(),

                })
                .ToList()
        })
        .ToList()
            };

            return userVerbListModel;
        }

    }
}

