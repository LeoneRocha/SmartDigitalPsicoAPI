using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

/// <summary>
/// Contrato estratégia email — surface SDP (EmailMessageDto SDP herda SCH).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.IEmailStrategy",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; SendEmailAsync usa EmailMessageDto SDP.")]
public interface IEmailStrategy
{
    Task SendEmailAsync(EmailMessageDto emailMessage);
}
