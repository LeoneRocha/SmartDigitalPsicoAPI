using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.Infrastructure;

/// <summary>
/// Casca GenericStorageQueueRepository — herda SCH NoSql.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.GenericStorageQueueRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando GenericStorageQueueRepository do SCH.")]
public class GenericStorageQueueRepository
    : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.GenericStorageQueueRepository,
      IStorageQueueContract
{
    public GenericStorageQueueRepository(
        SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageQueueContract storageQueueAdapter,
        string tableName)
        : base(storageQueueAdapter, tableName)
    {
    }
}
