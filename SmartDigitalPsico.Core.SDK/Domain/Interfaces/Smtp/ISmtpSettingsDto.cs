using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

/// <summary>
/// Casca ISmtpSettingsDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.ISmtpSettingsDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ISmtpSettingsDto em SmartCoreHub.Core.SDK.")]
public interface ISmtpSettingsDto : SmartCoreHub.Core.SDK.Service.Email.ISmtpSettingsDto
{
}
