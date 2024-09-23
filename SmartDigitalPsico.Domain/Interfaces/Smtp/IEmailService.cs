using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessageDto emailMessage);
    }
}