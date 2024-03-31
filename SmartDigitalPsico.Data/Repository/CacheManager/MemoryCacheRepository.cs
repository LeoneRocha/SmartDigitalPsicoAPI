using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.VO.Domains;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    public class MemoryCacheRepository : IMemoryCacheRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly CacheConfigurationVO? _cacheConfig;
        private readonly MemoryCacheEntryOptions? _cacheOptions;
        public MemoryCacheRepository(IMemoryCache memoryCache, IOptions<CacheConfigurationVO> cacheConfig)
        {
            _memoryCache = memoryCache;
            _cacheConfig = cacheConfig.Value;
            if (_cacheConfig != null)
            {
                DateTime absoluteExpiration = CultureDateTimeHelper.GetDateTimeNow().AddHours(_cacheConfig.AbsoluteExpirationInHours);
                absoluteExpiration = CultureDateTimeHelper.GetDateTimeNow().AddMinutes(_cacheConfig.AbsoluteExpirationInMinutes);

                _cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = absoluteExpiration,
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(_cacheConfig.SlidingExpirationInMinutes)
                };
            }
        }
        public bool TryGet<T>(string cacheKey, out T value)
        {
            bool isSuccessGet = false;
            value = _memoryCache.Get<T>(cacheKey);

            _memoryCache.TryGetValue(cacheKey, out value);
            if (value != null)
            {
                isSuccessGet = true;
            }

            return isSuccessGet;
        }

        public bool Set<T>(string cacheKey, T value)
        {
            try
            {
                _memoryCache.Set(cacheKey, value, _cacheOptions);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Remove(string cacheKey)
        {
            try
            {
                _memoryCache.Remove(cacheKey);

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
