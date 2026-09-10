using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

/// <summary>
/// Casca IStorageQueueContract — herda SCH NoSql.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageQueueContract",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IStorageQueueContract do SCH.")]
public interface IStorageQueueContract : SmartCoreHub.Core.SDK.Infrastructure.Azure.NoSql.IStorageQueueContract
{
}
