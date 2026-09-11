using Microsoft.Extensions.Options;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;
using SdpCache = SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;
using SdpRepo = SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SdpVo = SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager;

/// <summary>
/// Casca CacheService — herda <see cref="LocalCacheService"/> (L1); helpers estáticos usam VO/iface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.LocalCacheService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "EVO.7: casca L1 sobre LocalCacheService; SaveDataToCache/GetDataFromCache com tipos SDP.")]
public class CacheService : LocalCacheService, ICacheService
{
    public CacheService(
        SdpRepo.IMemoryCacheRepository memoryCacheRepository,
        SdpRepo.IDiskCacheRepository diskCacheRepository,
        IOptions<CacheConfigurationDto> cacheConfig)
        : base(memoryCacheRepository, diskCacheRepository, Options.Create(SdpCache.MemoryCacheRepository.Map(cacheConfig.Value)))
    {
    }

    public static async Task SaveDataToCache<T>(string keyCache, T dataToCache, ICacheService cacheService)
    {
        await Task.FromResult(0).ConfigureAwait(false);
        var cacheSave = new SdpVo.ServiceResponseCacheVO<T>(dataToCache, keyCache, cacheService.GetSlidingExpiration());
        cacheService.Set(keyCache, cacheSave);
    }

    public static async Task<SdpVo.ServiceResponse<T>> GetDataFromCache<T>(ICacheService cacheService, string keyCache)
    {
        await Task.FromResult(0).ConfigureAwait(false);
        var result = new SdpVo.ServiceResponse<T>();
        if (cacheService.IsEnable())
        {
            bool existsCache = cacheService.TryGet(keyCache, out SdpVo.ServiceResponseCacheVO<T> cachedResult);
            if (existsCache)
            {
                result.Data = cachedResult.Data;
            }
        }

        return result;
    }
}
