using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por ThirdPartyEmailStrategy.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
