using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

/// <summary>
/// Casca EmailContext — resolve strategy SDP e envia.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.EmailContext",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca EmailContext com enum/factory SDP; envio via strategies SCH.")]
public class EmailContext
{
    private readonly IEmailStrategyFactory _emailStrategyFactory;

    public EmailContext(IEmailStrategyFactory emailStrategyFactory)
    {
        _emailStrategyFactory = emailStrategyFactory ?? throw new ArgumentNullException(nameof(emailStrategyFactory));
    }

    public async Task SendEmailAsync(EEmailStrategyType strategyType, EmailMessageDto emailMessage)
    {
        ArgumentNullException.ThrowIfNull(emailMessage);
        var strategy = _emailStrategyFactory.CreateStrategy(strategyType);
        await strategy.SendEmailAsync(emailMessage).ConfigureAwait(false);
    }
}
