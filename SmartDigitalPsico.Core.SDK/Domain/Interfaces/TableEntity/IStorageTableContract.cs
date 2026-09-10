using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;

/// <summary>
/// Casca IStorageTableContract — herda SCH NoSql.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageTableContract`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IStorageTableContract do SCH.")]
public interface IStorageTableContract<T>
    : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageTableContract<T>
    where T : BaseEntityTable, new()
{
}
