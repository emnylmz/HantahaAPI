using HantahaAPI.Core.Entity;
using HantahaAPI.Core.Model.Request;
using HantahaAPI.Core.Model.Response;

namespace HantahaAPI.Core.Interfaces
{
    public interface ISentenceService : IService<Sentence>
    {
        //bakılack
        Task<List<SentenceListModel>> List();
        Task<SentenceWithVerbsModel> GetSentenceWithItemsAsync(int sentenceId);
        Task<bool> CreateOrUpdate(SentenceCreateOrUpdateModel sentence, int userId);
    }
}

