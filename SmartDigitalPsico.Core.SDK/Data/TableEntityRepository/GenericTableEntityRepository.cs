using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Core.SDK.Data.TableEntityRepository;

/// <summary>
/// Casca GenericTableEntityRepository — herda SCH NoSql.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.GenericTableEntityRepository`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando GenericTableEntityRepository do SCH.")]
public class GenericTableEntityRepository<T>
    : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.GenericTableEntityRepository<T>,
      IStorageTableContract<T>
    where T : BaseEntityTable, new()
{
    public GenericTableEntityRepository(
        SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageTableContract<T> tableStorageAdapter,
        string tableName)
        : base(tableStorageAdapter, tableName)
    {
    }
}
