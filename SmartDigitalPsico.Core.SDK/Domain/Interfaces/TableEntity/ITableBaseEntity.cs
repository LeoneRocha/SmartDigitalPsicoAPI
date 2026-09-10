using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;

/// <summary>
/// Casca ITableBaseEntity — herda SCH NoSql.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.ITableBaseEntity",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ITableBaseEntity do SCH.")]
public interface ITableBaseEntity : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.ITableBaseEntity
{
}
