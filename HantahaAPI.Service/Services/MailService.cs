using HantahaAPI.Core.DTOs;
using HantahaAPI.Core.Model;
using Microsoft.Extensions.Options;
using MimeKit;

public class MailService : HantahaAPI.Core.Interfaces.Service.IMailService
{
    private readonly Settings _settings;

    public MailService(IOptions<Settings> settings)
    {
        _settings = settings.Value;
    }

    public async Task<bool> SendMailAsync(MailDataDto mailData)
    {
        try
        {
            await Task.Run(async () =>
            {
                using (MimeMessage emailMessage = new MimeMessage())
                {
                    MailboxAddress emailFrom = new MailboxAddress(_settings.MailSettings.SenderName, _settings.MailSettings.SenderEmail);
                    emailMessage.From.Add(emailFrom);
                    MailboxAddress emailTo = new MailboxAddress(mailData.EmailToName, mailData.Email);
                    emailMessage.To.Add(emailTo);

                    emailMessage.Subject = mailData.EmailSubject;

                    BodyBuilder emailBodyBuilder = new BodyBuilder();
                    emailBodyBuilder.HtmlBody = mailData.EmailBody;
                    emailMessage.Body = emailBodyBuilder.ToMessageBody();

                    using (MailKit.Net.Smtp.SmtpClient mailClient = new MailKit.Net.Smtp.SmtpClient())
                    {
                        await mailClient.ConnectAsync(_settings.MailSettings.Server, _settings.MailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                        await mailClient.AuthenticateAsync(_settings.MailSettings.UserName, _settings.MailSettings.Password);
                        await mailClient.SendAsync(emailMessage);
                        await mailClient.DisconnectAsync(true);
                    }
                }
            });

            return true;
        }
        catch (Exception ex)
        {
            // Hata Detayları
            return false;
        }
    }
}