using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

/// <summary>
/// Casca fábrica email — Create com enum SDP Enuns; strategies herdam SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.EmailStrategyFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca CreateStrategy com EEmailStrategyType SDP; strategies herdam SCH.")]
public class EmailStrategyFactory : IEmailStrategyFactory
{
    private readonly ISmtpSettingsDto _smtpSettings;

    public EmailStrategyFactory(ISmtpSettingsDto smtpSettings)
    {
        _smtpSettings = smtpSettings ?? throw new ArgumentNullException(nameof(smtpSettings));
    }

    public IEmailStrategy CreateStrategy(EEmailStrategyType strategyType)
    {
        return strategyType switch
        {
            EEmailStrategyType.Smtp => new SmtpEmailStrategy(_smtpSettings),
            EEmailStrategyType.ThirdParty => new ThirdPartyEmailStrategy(),
            _ => throw new ArgumentException("Invalid strategy type", nameof(strategyType)),
        };
    }
}
