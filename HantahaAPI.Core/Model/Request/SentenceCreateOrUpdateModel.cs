namespace HantahaAPI.Core.Model.Request
{
    public class SentenceCreateOrUpdateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<SentenceCreateOrUpdateModelItem> SentenceItems { get; set; }
        public int[] VerbIds { get; set; }
    }

    public class SentenceCreateOrUpdateModelItem
    {
        public int Id { get; set; }
        public int SentenceId { get; set; }
        public int LanguageId { get; set; }
        public string Context { get; set; }
    }
}
