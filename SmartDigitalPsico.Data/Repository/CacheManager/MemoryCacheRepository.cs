using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.DTO.Domains;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    public class MemoryCacheRepository : IMemoryCacheRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions? _cacheOptions;
        public MemoryCacheRepository(IMemoryCache memoryCache, IOptions<CacheConfigurationDto> cacheConfig)
        {
            _memoryCache = memoryCache;
            CacheConfigurationDto _cacheConfig = cacheConfig.Value;
            if (_cacheConfig != null)
            {
                DateTime absoluteExpiration = DataHelper.GetDateTimeNow().AddHours(_cacheConfig.AbsoluteExpirationInHours).AddMinutes(_cacheConfig.AbsoluteExpirationInMinutes);
                _cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = absoluteExpiration,
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(_cacheConfig.SlidingExpirationInMinutes)
                };
            }
        }
        public bool TryGet<T>(string cacheKey, out T? value)
        {
            bool isSuccessGet;
            isSuccessGet = _memoryCache.TryGetValue(cacheKey, out value);
            return isSuccessGet;
        }

        public bool Set<T>(string cacheKey, T value)
        {
            _memoryCache.Set(cacheKey, value, _cacheOptions);
            return true;
        }
        public bool Set<T>(string cacheKey, T value, MemoryCacheEntryOptions memoryCacheEntryOptions)
        {
            _memoryCache.Set(cacheKey, value, memoryCacheEntryOptions);
            return true;
        }

        public bool Remove(string cacheKey)
        {
            _memoryCache.Remove(cacheKey);
            return true;
        }   
    }
}
