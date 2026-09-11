using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de unidades de intervalo de notificação.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EIntervalNotificationType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum EIntervalNotificationType
{
    Minutes = (int)SchEnums.EIntervalNotificationType.Minutes,
    Hours = (int)SchEnums.EIntervalNotificationType.Hours,
    Days = (int)SchEnums.EIntervalNotificationType.Days,
    Months = (int)SchEnums.EIntervalNotificationType.Months,
    Years = (int)SchEnums.EIntervalNotificationType.Years,
}
