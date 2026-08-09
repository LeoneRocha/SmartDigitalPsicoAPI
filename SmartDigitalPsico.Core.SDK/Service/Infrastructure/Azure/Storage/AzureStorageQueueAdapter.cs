using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Classe responsável por AzureStorageQueueAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class AzureStorageQueueAdapter : IStorageQueueContract
    {
        private readonly QueueClient? _queueClient;

        /// <summary>
        /// Método AzureStorageQueueAdapter: executa a operação AzureStorageQueueAdapter.
        /// </summary>
        public AzureStorageQueueAdapter(IConfiguration configuration, string queueName)
        {
            string conBSC = configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
            if (!string.IsNullOrEmpty(conBSC))
            {
                _queueClient = new QueueClient(conBSC, queueName);
                _queueClient.CreateIfNotExists();
            }
        }

        public AzureStorageQueueAdapter(QueueClient queueClient)
        {
            _queueClient = queueClient;
        }

        /// <summary>
        /// Método EnqueueMessageAsync: executa a operação EnqueueMessageAsync.
        /// </summary>
        public async Task EnqueueMessageAsync(string message)
        {
            if (_queueClient == null)
            {
                return;
            }
            await _queueClient.SendMessageAsync(message);
        }

        /// <summary>
        /// Método DequeueMessageAsync: executa a operação DequeueMessageAsync.
        /// </summary>
        public async Task<string> DequeueMessageAsync()
        {
            if (_queueClient == null)
            {
                return string.Empty;
            }
            QueueMessage[] retrievedMessage = await _queueClient.ReceiveMessagesAsync(1);
            if (retrievedMessage.Length == 0)
            {
                return string.Empty;
            }
            return retrievedMessage[0].MessageText;
        }

        /// <summary>
        /// Método DeleteMessageAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task DeleteMessageAsync(string messageId, string popReceipt)
        {
            if (_queueClient == null)
            {
                return;
            }
            await _queueClient.DeleteMessageAsync(messageId, popReceipt);
        }
    }
}
