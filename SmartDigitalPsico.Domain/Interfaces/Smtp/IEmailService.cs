using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessageVO emailMessage);
    }
}