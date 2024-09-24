using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class EmailService : IEmailService
    {
        private readonly EmailContext _emailContext;

        public EmailService(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        public async Task SendEmailAsync(EmailMessageDto emailMessage)
        { 
            await _emailContext.SendEmailAsync(EEmailStrategyType.Smtp, emailMessage);
        }
    }
} 