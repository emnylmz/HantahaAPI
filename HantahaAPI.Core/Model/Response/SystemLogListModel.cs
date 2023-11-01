namespace HantahaAPI.Core.Model.Response
{
    public class SystemLogListModel
    {
        public int Id { get; set; }

        public string? UserFullname { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
        public string IpAddress { get; set; }
        public string RequestQueryString { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
