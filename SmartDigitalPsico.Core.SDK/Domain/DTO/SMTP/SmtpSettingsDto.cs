using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;

/// <summary>
/// Casca SmtpSettingsDto — herda SCH; satisfaz iface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Email.SmtpSettingsDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando SmtpSettingsDto em SmartCoreHub.Core.SDK.")]
public class SmtpSettingsDto : SmartCoreHub.Core.SDK.Domain.DTOs.Email.SmtpSettingsDto, ISmtpSettingsDto
{
}
