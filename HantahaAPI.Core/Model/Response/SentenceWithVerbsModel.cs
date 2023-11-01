using HantahaAPI.Core.Entity;

namespace HantahaAPI.Core.Model.Response
{
    public class SentenceWithVerbsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<SentenceItem> SentenceItems { get; set; }
        public List<ComboModel> Verbs { get; set; }
    }



}

