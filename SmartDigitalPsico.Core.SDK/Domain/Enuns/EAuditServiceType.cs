using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de destinos de auditoria.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.EAuditServiceType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum EAuditServiceType
{
    Database = (int)SchEnums.EAuditServiceType.Database,
    Log = (int)SchEnums.EAuditServiceType.Log,
    AzureTable = (int)SchEnums.EAuditServiceType.AzureTable,
}
