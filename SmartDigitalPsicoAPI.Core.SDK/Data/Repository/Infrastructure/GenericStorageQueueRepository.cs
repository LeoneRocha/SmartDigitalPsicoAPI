using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Infrastructure
{
    /// <summary>
    /// Classe responsável por GenericStorageQueueRepository.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class GenericStorageQueueRepository : IStorageQueueContract
    {
        private readonly IStorageQueueContract _storageQueueAdapter;

        /// <summary>
        /// Método GenericStorageQueueRepository: executa a operação GenericStorageQueueRepository.
        /// </summary>
        public GenericStorageQueueRepository(IStorageQueueContract storageQueueAdapter, string tableName)
        {
            _storageQueueAdapter = storageQueueAdapter;
        }

        /// <summary>
        /// Método DeleteMessageAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public virtual async Task DeleteMessageAsync(string messageId, string popReceipt)
        {
            await _storageQueueAdapter.DeleteMessageAsync(messageId, popReceipt);
        }

        /// <summary>
        /// Método DequeueMessageAsync: executa a operação DequeueMessageAsync.
        /// </summary>
        public virtual async Task<string> DequeueMessageAsync()
        {
            return await _storageQueueAdapter.DequeueMessageAsync();
        }

        /// <summary>
        /// Método EnqueueMessageAsync: executa a operação EnqueueMessageAsync.
        /// </summary>
        public virtual async Task EnqueueMessageAsync(string message)
        {
            await _storageQueueAdapter.EnqueueMessageAsync(message);
        }
    }
} 
