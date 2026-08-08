using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por ThirdPartyEmailStrategy.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class ThirdPartyEmailStrategy : IEmailStrategy
    {
        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendEmailAsync(EmailMessageDto emailMessage)
        {
            // Implementação para enviar e-mail via um serviço de terceiros
            await Task.CompletedTask;
        }
    }
} 
