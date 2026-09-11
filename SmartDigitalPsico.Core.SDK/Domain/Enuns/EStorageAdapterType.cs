using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de provedores de storage.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EStorageAdapterType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum EStorageAdapterType
{
    Azure = (int)SchEnums.EStorageAdapterType.Azure,
    AWS = (int)SchEnums.EStorageAdapterType.AWS,
    Google = (int)SchEnums.EStorageAdapterType.Google,
}
