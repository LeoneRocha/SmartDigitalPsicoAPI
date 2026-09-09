using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Caching;

/// <summary>
/// DI cache — SDP adiciona MemoryCache; repos/ICacheService no host ou <c>AddCoreCacheAndStorageRepositories</c>.
/// SCH <c>AddCoreCaching</c> também registra LocalCache stack — aqui só MemoryCache para não duplicar com o host.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreCaching",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreCaching; MemoryCache only — repos/CacheService no host (retenção parcial vs SCH).")]
public static class CachingServiceCollectionExtensions
{
    public static IServiceCollection AddCoreCaching(this IServiceCollection services)
    {
        services.AddMemoryCache();
        return services;
    }
}
