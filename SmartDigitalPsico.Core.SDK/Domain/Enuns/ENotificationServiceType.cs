using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de canais de notificação.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ENotificationServiceType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum ENotificationServiceType
{
    Email = (int)SchEnums.ENotificationServiceType.Email,
    Sms = (int)SchEnums.ENotificationServiceType.Sms,
    WhatsApp = (int)SchEnums.ENotificationServiceType.WhatsApp,
}
