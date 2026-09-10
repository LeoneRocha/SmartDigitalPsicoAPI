using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

/// <summary>
/// Casca AzureStorageQueueAdapter — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando AzureStorageQueueAdapter do SCH.")]
public class AzureStorageQueueAdapter
    : SmartCoreHub.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter,
      IStorageQueueContract
{
    public AzureStorageQueueAdapter(IConfiguration configuration, string queueName)
        : base(configuration, queueName)
    {
    }

    public AzureStorageQueueAdapter(QueueClient queueClient) : base(queueClient)
    {
    }
}
