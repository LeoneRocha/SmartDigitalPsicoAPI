using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Data.Repository.Infrastructure
{
    public class GenericStorageQueueRepository : IStorageQueueContract
    {
        private readonly IStorageQueueContract _storageQueueAdapter;

        public GenericStorageQueueRepository(IStorageQueueContract storageQueueAdapter, string tableName)
        {
            _storageQueueAdapter = storageQueueAdapter;
        }

        public virtual async Task DeleteMessageAsync(string messageId, string popReceipt)
        {
            await _storageQueueAdapter.DeleteMessageAsync(messageId, popReceipt);
        }

        public virtual async Task<string> DequeueMessageAsync()
        {
            return await _storageQueueAdapter.DequeueMessageAsync();
        }

        public virtual async Task EnqueueMessageAsync(string message)
        {
            await _storageQueueAdapter.EnqueueMessageAsync(message);
        }
    }
} 