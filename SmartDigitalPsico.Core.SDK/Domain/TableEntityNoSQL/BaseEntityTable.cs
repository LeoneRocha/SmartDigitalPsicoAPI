using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;

namespace SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

/// <summary>
/// Casca BaseEntityTable — herda SCH NoSql (dep de adapters/factories).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.BaseEntityTable",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando BaseEntityTable do SCH.")]
public abstract class BaseEntityTable
    : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.BaseEntityTable,
      ITableBaseEntity
{
}
