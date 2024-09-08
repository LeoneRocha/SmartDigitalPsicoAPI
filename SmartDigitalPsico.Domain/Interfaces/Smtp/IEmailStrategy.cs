using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface IEmailStrategy
    {
        Task SendEmailAsync(EmailMessageVO emailMessage);
    }
}
