using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;

/// <summary>
/// Casca EmailMessageDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Email.EmailMessageDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando EmailMessageDto em SmartCoreHub.Core.SDK.")]
public class EmailMessageDto : SmartCoreHub.Core.SDK.Domain.DTOs.Email.EmailMessageDto
{
}
