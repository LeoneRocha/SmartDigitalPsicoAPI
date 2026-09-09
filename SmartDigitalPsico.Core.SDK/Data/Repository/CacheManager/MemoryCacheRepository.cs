using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SchCache = SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;

/// <summary>
/// Casca MemoryCache — herda SCH; mapeia <see cref="CacheConfigurationDto"/> → LocalCacheConfigurationDto.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.MemoryCacheRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando MemoryCacheRepository; Options CacheConfigurationDto → LocalCache.")]
public class MemoryCacheRepository : SchCache.MemoryCacheRepository, IMemoryCacheRepository
{
    public MemoryCacheRepository(IMemoryCache memoryCache, IOptions<CacheConfigurationDto> cacheConfig)
        : base(memoryCache, Options.Create(Map(cacheConfig.Value)))
    {
    }

    internal static SchCache.LocalCacheConfigurationDto Map(CacheConfigurationDto config)
    {
        ArgumentNullException.ThrowIfNull(config);
        return new SchCache.LocalCacheConfigurationDto
        {
            AbsoluteExpirationInHours = config.AbsoluteExpirationInHours,
            AbsoluteExpirationInMinutes = config.AbsoluteExpirationInMinutes,
            SlidingExpirationInMinutes = config.SlidingExpirationInMinutes,
            PathCache = config.PathCache,
            ExtensionCache = config.ExtensionCache,
            IsEnable = config.IsEnable,
            TypeCache = (SchEnums.ETypeLocationCache)(int)config.TypeCache,
        };
    }
}
