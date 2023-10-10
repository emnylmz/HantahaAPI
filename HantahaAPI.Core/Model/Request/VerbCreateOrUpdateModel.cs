namespace HantahaAPI.Core.Model.Request
{
    public class VerbCreateOrUpdateModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public List<VerbCreateOrUpdateModelItem> VerbItems { get; set; }
    }

    public class VerbCreateOrUpdateModelItem
    {
        public int Id { get; set; }
        public int VerbId { get; set; }
        public int LanguageId { get; set; }
        public string Context { get; set; }
    }
}
