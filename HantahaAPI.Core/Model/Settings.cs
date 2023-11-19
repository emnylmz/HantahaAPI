namespace HantahaAPI.Core.Model
{
    public class Settings
    {
        public string SecretKeyBase64 { get; set; }

        public string ProjectName { get; set; }

        public string ProjectVersion { get; set; }

        public string MsSQLConnection { get; set; }
        public string PsgSQLConnection { get; set; }

        public JWTSettings JWTSettings { get; set; }
        public MailSettings MailSettings { get; set; }
    }

    public class JWTSettings
    {
        public string SecretKey { get; set; }

        public int ExpireMinutes { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }

    public class MailSettings
    {
        public string Server { get; set; }

        public int Port { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

