using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class EmailStrategyFactory : IEmailStrategyFactory
    {
        private readonly ISmtpSettingsVO _smtpSettings;

        public EmailStrategyFactory(ISmtpSettingsVO smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

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
