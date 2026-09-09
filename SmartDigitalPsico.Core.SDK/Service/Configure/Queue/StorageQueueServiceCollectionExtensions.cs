using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Queue;

/// <summary>
/// DI Azure Storage Queue — registro concreto SDP. SCH <c>AddCoreStorageQueue</c> é stub documental.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreStorageQueue",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AddCoreStorageQueue SDP com factory/contrato; SCH é stub host-side.")]
public static class StorageQueueServiceCollectionExtensions
{
    public static IServiceCollection AddCoreStorageQueue(this IServiceCollection services, string queueName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(queueName);

        services.AddTransient<IStorageQueueRepositoryFactory, StorageQueueRepositoryFactory>();
        services.AddScoped<IStorageQueueContract>(provider =>
        {
            var serviceFactory = provider.GetRequiredService<IStorageQueueRepositoryFactory>();
            return new StorageQueueService(serviceFactory, queueName);
        });
        return services;
    }
}
