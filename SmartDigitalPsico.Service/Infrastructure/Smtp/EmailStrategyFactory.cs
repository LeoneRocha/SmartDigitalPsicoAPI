using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por EmailStrategyFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class EmailStrategyFactory : IEmailStrategyFactory
    {
        private readonly ISmtpSettingsDto _smtpSettings;

        /// <summary>
        /// Método EmailStrategyFactory: executa a operação EmailStrategyFactory.
        /// </summary>
        public EmailStrategyFactory(ISmtpSettingsDto smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

        /// <summary>
        /// Método CreateStrategy: cria ou persiste um novo registro/recurso.
        /// </summary>
        public IEmailStrategy CreateStrategy(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType strategyType)
        {
            switch (strategyType)
            {
                case SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType.Smtp:
                    return new SmtpEmailStrategy(_smtpSettings);
                case SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType.ThirdParty:
                    return new ThirdPartyEmailStrategy();
                default:
                    throw new ArgumentException("Invalid strategy type"); 
            }
        }
    }
}
