using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

/// <summary>
/// Casca ThirdParty stub — herda SCH; bridge IEmailStrategy SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.ThirdPartyEmailStrategy",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ThirdPartyEmailStrategy; bridge IEmailStrategy SDP.")]
public class ThirdPartyEmailStrategy : SmartCoreHub.Core.SDK.Service.Email.ThirdPartyEmailStrategy, IEmailStrategy
{
    Task IEmailStrategy.SendEmailAsync(EmailMessageDto emailMessage)
        => base.SendEmailAsync(emailMessage);
}
