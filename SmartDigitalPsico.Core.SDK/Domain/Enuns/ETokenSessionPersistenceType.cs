using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de persistência de sessão/token.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ETokenSessionPersistenceType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum ETokenSessionPersistenceType
{
    DataBase = (int)SchEnums.ETokenSessionPersistenceType.DataBase,
    AzureStorageTable = (int)SchEnums.ETokenSessionPersistenceType.AzureStorageTable,
}
