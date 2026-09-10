using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca StorageQueueNameConstants — espelho de constantes SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.StorageQueueNameConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando StorageQueueNameConstants do SCH.")]
public static class StorageQueueNameConstants
{
    public const string GeneralQueue = Sch.StorageQueueNameConstants.GeneralQueue;
}
