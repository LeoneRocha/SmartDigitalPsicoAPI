using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager
{
    /// <summary>
    /// Classe responsável por MemoryCacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class MemoryCacheRepository : IMemoryCacheRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly MemoryCacheEntryOptions? _cacheOptions;
        /// <summary>
        /// Método MemoryCacheRepository: executa a operação MemoryCacheRepository.
        /// </summary>
        public MemoryCacheRepository(IMemoryCache memoryCache, IOptions<CacheConfigurationDto> cacheConfig)
        {
            _memoryCache = memoryCache;
            CacheConfigurationDto _cacheConfig = cacheConfig.Value;
            if (_cacheConfig != null)
            {
                DateTime absoluteExpiration = DateHelper.GetDateTimeNowFromUtc().AddHours(_cacheConfig.AbsoluteExpirationInHours).AddMinutes(_cacheConfig.AbsoluteExpirationInMinutes);
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

        /// <summary>
        /// Método Remove: remove ou cancela um registro/recurso.
        /// </summary>
        public bool Remove(string cacheKey)
        {
            _memoryCache.Remove(cacheKey);
            return true;
        }   
    }
}
