using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    public class AzureStorageQueueAdapter : IStorageQueueContract
    {
        private readonly QueueClient? _queueClient; 

        public AzureStorageQueueAdapter(IConfiguration configuration, string queueName)
        { 
            string conBSC = configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
            if (!string.IsNullOrEmpty(conBSC))
            {
                _queueClient = new QueueClient(conBSC, queueName);
                _queueClient.CreateIfNotExists();
            }
        } 
        public async Task EnqueueMessageAsync(string message)
        {
            if (_queueClient == null)
            {
                return;
            }
            await _queueClient.SendMessageAsync(message);
        }

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