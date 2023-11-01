namespace HantahaAPI.Core.Entity
{
    public class SentenceVerb
    {
        public int Id { get; set; }
        public int SentenceId { get; set; }
        public int VerbId { get; set; }

        public Sentence Sentence { get; set; }
        public Verb Verb { get; set; }
    }
}
