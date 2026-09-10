using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Data.Repository.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure;

/// <summary>
/// Casca StorageQueueRepositoryFactory — lógica alinhada ao SCH (adapters SDP casca).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Infrastructure.StorageQueueRepositoryFactory",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca espelhando StorageQueueRepositoryFactory do SCH.")]
public class StorageQueueRepositoryFactory : IStorageQueueRepositoryFactory
{
    private readonly IConfiguration _configuration;

    public StorageQueueRepositoryFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IStorageQueueContract Create(EStorageAdapterType eStorageAdapterType, string queueName)
    {
        _ = eStorageAdapterType;
        var azureStorageQueueAdapter = new AzureStorageQueueAdapter(_configuration, queueName);
        return new GenericStorageQueueRepository(azureStorageQueueAdapter, queueName);
    }
}
