using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

/// <summary>
/// Casca IEmailService — marcador sobre <see cref="INotificationPlatformService"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.IEmailService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Marcador SDP sobre INotificationPlatformService (espelho SCH IEmailService).")]
public interface IEmailService : INotificationPlatformService
{
}
