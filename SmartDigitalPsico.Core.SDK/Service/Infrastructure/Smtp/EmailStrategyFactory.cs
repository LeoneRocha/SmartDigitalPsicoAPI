using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por EmailStrategyFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
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
        public IEmailStrategy CreateStrategy(EEmailStrategyType strategyType)
        {
            switch (strategyType)
            {
                case EEmailStrategyType.Smtp:
                    return new SmtpEmailStrategy(_smtpSettings);
                case EEmailStrategyType.ThirdParty:
                    return new ThirdPartyEmailStrategy();
                default:
                    throw new ArgumentException("Invalid strategy type");
            }
        }
    }
}
