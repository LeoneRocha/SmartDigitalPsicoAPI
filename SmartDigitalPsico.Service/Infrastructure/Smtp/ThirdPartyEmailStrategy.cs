using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class ThirdPartyEmailStrategy : IEmailStrategy
    {
        public async Task SendEmailAsync(EmailMessageVO emailMessage)
        {
            // Implementação para enviar e-mail via um serviço de terceiros
            await Task.CompletedTask;
        }
    }
} 