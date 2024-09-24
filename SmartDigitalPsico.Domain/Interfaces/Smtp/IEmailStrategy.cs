using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface IEmailStrategy
    {
        Task SendEmailAsync(EmailMessageDto emailMessage);
    }
}
