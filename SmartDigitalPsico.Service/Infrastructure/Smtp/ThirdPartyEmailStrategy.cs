using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class ThirdPartyEmailStrategy : IEmailStrategy
    {
        public async Task SendEmailAsync(EmailMessageDto emailMessage)
        {
            // Implementação para enviar e-mail via um serviço de terceiros
            await Task.CompletedTask;
        }
    }
} 