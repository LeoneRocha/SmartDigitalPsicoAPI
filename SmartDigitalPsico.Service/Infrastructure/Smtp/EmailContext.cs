using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por EmailContext.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class EmailContext
    {
        private readonly IEmailStrategyFactory _emailStrategyFactory;

        /// <summary>
        /// Método EmailContext: executa a operação EmailContext.
        /// </summary>
        public EmailContext(IEmailStrategyFactory emailStrategyFactory)
        {
            _emailStrategyFactory = emailStrategyFactory;
        }

        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendEmailAsync(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType strategyType, EmailMessageDto emailMessage)
        {
            var strategy = _emailStrategyFactory.CreateStrategy(strategyType);
            await strategy.SendEmailAsync(emailMessage);
        }
    }
}
