using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

/// <summary>
/// Casca IStorageQueueRepositoryFactory — espelho SCH com enums/contratos SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com EStorageAdapterType SDP; não herda SCH interface por tipos.")]
public interface IStorageQueueRepositoryFactory
{
    IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName);
}
