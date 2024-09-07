using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Service.Infrastructure
{
    public class StorageQueueService : IStorageQueueContract 
    {
        private readonly IStorageQueueContract _storageQueueRepository;

        public StorageQueueService(IStorageQueueRepositoryFactory storageQueueRepositoryFactory, string queueName)
        {
            EStorageAdapterType _storageAdapterType = EStorageAdapterType.Azure;
            _storageQueueRepository = storageQueueRepositoryFactory.Create(_storageAdapterType, queueName);
        }

        public virtual async Task DeleteMessageAsync(string messageId, string popReceipt)
        {
            await _storageQueueRepository.DeleteMessageAsync(messageId, popReceipt);
        }

        public virtual async Task<string> DequeueMessageAsync()
        {
            return await _storageQueueRepository.DequeueMessageAsync();
        }

        public virtual async Task EnqueueMessageAsync(string message)
        {
            await _storageQueueRepository.EnqueueMessageAsync(message);
        }
    }
}
