using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure
{
    /// <summary>
    /// Classe responsável por StorageQueueService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class StorageQueueService : IStorageQueueContract 
    {
        private readonly IStorageQueueContract _storageQueueRepository;

        /// <summary>
        /// Método StorageQueueService: executa a operação StorageQueueService.
        /// </summary>
        public StorageQueueService(IStorageQueueRepositoryFactory storageQueueRepositoryFactory, string queueName)
        {
            EStorageAdapterType _storageAdapterType = EStorageAdapterType.Azure;
            _storageQueueRepository = storageQueueRepositoryFactory.Create(_storageAdapterType, queueName);
        }

        /// <summary>
        /// Método DeleteMessageAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public virtual async Task DeleteMessageAsync(string messageId, string popReceipt)
        {
            await _storageQueueRepository.DeleteMessageAsync(messageId, popReceipt);
        }

        /// <summary>
        /// Método DequeueMessageAsync: executa a operação DequeueMessageAsync.
        /// </summary>
        public virtual async Task<string> DequeueMessageAsync()
        {
            return await _storageQueueRepository.DequeueMessageAsync();
        }

        /// <summary>
        /// Método EnqueueMessageAsync: executa a operação EnqueueMessageAsync.
        /// </summary>
        public virtual async Task EnqueueMessageAsync(string message)
        {
            await _storageQueueRepository.EnqueueMessageAsync(message);
        }
    }
}
