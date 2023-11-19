using HantahaAPI.Core.DTOs;

namespace HantahaAPI.Core.Interfaces.Service
{
    public interface IMailService
    {
        Task<bool> SendMailAsync(MailDataDto mailData);
    }
}
