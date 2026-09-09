using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;
using SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Repository;

/// <summary>
/// DI repos cache/disco + blob Azure (blob é extensão SDP além do SCH AddCoreCacheAndStorageRepositories).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreCacheAndStorageRepositories",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias + AzureStorageBlobAdapter (retenção SDP além do SCH).")]
public static class CacheAndStorageServiceCollectionExtensions
{
    public static IServiceCollection AddCoreCacheAndStorageRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IMemoryCacheRepository, MemoryCacheRepository>();
        services.AddSingleton<IDiskCacheRepository, DiskCacheRepository>();
        services.AddSingleton<IFileDiskRepository, FileDiskRepository>();
        services.AddScoped<IStorageBlobAdapter, AzureStorageBlobAdapter>();
        return services;
    }
}
