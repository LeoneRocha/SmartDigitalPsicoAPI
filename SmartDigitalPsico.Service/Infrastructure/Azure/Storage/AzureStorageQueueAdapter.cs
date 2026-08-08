using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Service.Infrastructure.Azure.Storage
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_AZURE")]
    public class AzureStorageQueueAdapter : SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter
    {
        public AzureStorageQueueAdapter(IConfiguration configuration, string queueName) : base(configuration, queueName) { }

        public AzureStorageQueueAdapter(QueueClient queueClient) : base(queueClient) { }
    }
}
