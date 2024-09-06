using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class EmailService : IEmailService
    {
        private readonly EmailContext _emailContext;

        public EmailService(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        public async Task SendEmailAsync(EmailMessageVO emailMessage)
        { 
            await _emailContext.SendEmailAsync(EEmailStrategyType.Smtp, emailMessage);
        }
    }
} 