namespace HantahaAPI.Core.Entity
{
    public class SystemLog
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionSource { get; set; }
        public string ExceptionUrl { get; set; }
        public string HeaderString { get; set; }
        public string RequestQueryString { get; set; }
        public string IpAddress { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
    }
}

