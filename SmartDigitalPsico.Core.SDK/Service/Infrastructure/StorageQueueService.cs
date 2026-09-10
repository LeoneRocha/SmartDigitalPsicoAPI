using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure;

/// <summary>
/// Casca StorageQueueService — espelho SCH com factory SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.StorageQueueService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca espelhando StorageQueueService; factory SDP na assinatura pública.")]
public class StorageQueueService : IStorageQueueContract
{
    private readonly IStorageQueueContract _storageQueueRepository;

    public StorageQueueService(IStorageQueueRepositoryFactory storageQueueRepositoryFactory, string queueName)
    {
        EStorageAdapterType storageAdapterType = EStorageAdapterType.Azure;
        _storageQueueRepository = storageQueueRepositoryFactory.Create(storageAdapterType, queueName);
    }

    public virtual async Task DeleteMessageAsync(string messageId, string popReceipt)
        => await _storageQueueRepository.DeleteMessageAsync(messageId, popReceipt);

    public virtual async Task<string> DequeueMessageAsync()
        => await _storageQueueRepository.DequeueMessageAsync();

    public virtual async Task EnqueueMessageAsync(string message)
        => await _storageQueueRepository.EnqueueMessageAsync(message);
}
