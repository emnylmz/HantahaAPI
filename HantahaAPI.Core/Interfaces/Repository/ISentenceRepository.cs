using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ISentenceRepository : IGenericRepository<Sentence>
    {
        Task<List<SentenceListModel>> List();
        Task<SentenceWithVerbsModel> GetSentenceWithItemsAsync(int verbId);
        Task<Sentence> GetSentenceIncludeItemsAsync(int verbId);
    }
}

