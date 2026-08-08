using Microsoft.Extensions.Options;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service;
using SmartDigitalPsicoAPI.Core.SDK.Domain.ModelEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using System.Globalization;
using System.Reflection;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.CacheManager
{
    /// <summary>
    /// Classe responsável por CacheService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class CacheService : ICacheService
    {
        private readonly IMemoryCacheRepository _memoryCacheRepository;
        private readonly IDiskCacheRepository _diskCacheRepository;
        private readonly CacheConfigurationDto _cacheConfig;
        private readonly ETypeLocationCache _eTypeLocationCache;


        /// <summary>
        /// Método CacheService: executa a operação CacheService.
        /// </summary>
        public CacheService(IMemoryCacheRepository memoryCacheRepository
            , IDiskCacheRepository diskCacheRepository
            , IOptions<CacheConfigurationDto> cacheConfig)
        {
            _memoryCacheRepository = memoryCacheRepository;
            _diskCacheRepository = diskCacheRepository;
            _cacheConfig = cacheConfig.Value;
            _eTypeLocationCache = _cacheConfig.TypeCache;
        }

        public bool Remove<T>(string? cacheKey)
        {
            bool result = false;
            cacheKey = getCacheKey<T>(cacheKey);

            switch (_eTypeLocationCache)
            {
                case ETypeLocationCache.Disk:
                    break;
                case ETypeLocationCache.Memory:
                    result = _memoryCacheRepository.Remove(cacheKey);
                    break;
                case ETypeLocationCache.MongoDB:
                    break;
                case ETypeLocationCache.AzureStorage:
                    break;
                case ETypeLocationCache.AzureCosmoDB:
                    break;
                case ETypeLocationCache.AzureRedis:
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public bool Set<T>(string? cacheKey, T value)
        {
            cacheKey = getCacheKey<T>(cacheKey);
            bool result = false;
            switch (_eTypeLocationCache)
            {
                case ETypeLocationCache.Disk:
                    result = processCacheRepositoryDisk(cacheKey, value);
                    break;
                case ETypeLocationCache.Memory:
                    result = _memoryCacheRepository.Set(cacheKey, value);
                    break;
                case ETypeLocationCache.MongoDB:
                    break;
                case ETypeLocationCache.AzureStorage:
                    break;
                case ETypeLocationCache.AzureCosmoDB:
                    break;
                case ETypeLocationCache.AzureRedis:
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public bool Exists<T>(string? cacheKey) where T : class, new()
        { 
            bool result = false;
            try
            {
                cacheKey = getCacheKey<T>(cacheKey);
                switch (_eTypeLocationCache)
                {
                    case ETypeLocationCache.Disk:
                        var resultDisk = _diskCacheRepository.TryGetAsync<T>(cacheKey).GetAwaiter().GetResult();
                        result = checkCacheIsValid(resultDisk, cacheKey);
                        break;
                    case ETypeLocationCache.Memory:
                        result = _memoryCacheRepository.TryGet(cacheKey, out T? _);
                        break;
                    case ETypeLocationCache.MongoDB:
                        break;
                    case ETypeLocationCache.AzureStorage:
                        break;
                    case ETypeLocationCache.AzureCosmoDB:
                        break;
                    case ETypeLocationCache.AzureRedis:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                return result;
            }
            return result;
        }

        public bool TryGet<T>(string? cacheKey, out T value) where T : class, new()
        {
            T? _valueResult = new T();

            bool result = false;
            try
            {
                cacheKey = getCacheKey<T>(cacheKey);
                switch (_eTypeLocationCache)
                {
                    case ETypeLocationCache.Disk:
                        var resultDisk = _diskCacheRepository.TryGetAsync<T>(cacheKey).GetAwaiter().GetResult();
                        result = checkCacheIsValid(resultDisk, cacheKey);
                        _valueResult = checkCacheIsValid(resultDisk, cacheKey) ? resultDisk.Value : _valueResult;
                        break;
                    case ETypeLocationCache.Memory:
                        result = _memoryCacheRepository.TryGet(cacheKey, out _valueResult);
                        break;
                    case ETypeLocationCache.MongoDB:
                        break;
                    case ETypeLocationCache.AzureStorage:
                        break;
                    case ETypeLocationCache.AzureCosmoDB:
                        break;
                    case ETypeLocationCache.AzureRedis:
                        break;
                    default:
                        break;
                }
                value = _valueResult ?? new T();
            }
            catch (Exception)
            {
                value = _valueResult ?? new T();
                return result;
            }
            return result;
        }

        /// <summary>
        /// Método IsEnable: executa a operação IsEnable.
        /// </summary>
        public bool IsEnable()
        {
            bool isEnable = _cacheConfig.IsEnable;

            return isEnable;
        }

        /// <summary>
        /// Método GetSlidingExpiration: consulta e retorna dados.
        /// </summary>
        public DateTime GetSlidingExpiration()
        {
            return DateTime.Now.AddHours(_cacheConfig.AbsoluteExpirationInHours).AddMinutes(_cacheConfig.SlidingExpirationInMinutes);
        }

        public static async Task SaveDataToCache<T>(string keyCache, T dataToCache, ICacheService cacheService)
        {
            await Task.FromResult(0);

            ServiceResponseCacheVO<T> cacheSave = new ServiceResponseCacheVO<T>(dataToCache, keyCache, cacheService.GetSlidingExpiration());
            cacheService.Set(keyCache, cacheSave);
        }
        public static async Task<ServiceResponse<T>> GetDataFromCache<T>(ICacheService cacheService, string keyCache)
        {
            await Task.FromResult(0);

            ServiceResponse<T> result = new ServiceResponse<T>();

            if (cacheService.IsEnable())
            {
                bool existsCache = cacheService.TryGet(keyCache, out ServiceResponseCacheVO<T> cachedResult);
                if (existsCache)
                {
                    result.Data = cachedResult.Data;
                }
            }
            return result;
        }

        #region PRIVATES
        private bool processCacheRepositoryDisk<T>(string cacheKey, T? value)
        {
            if (!EqualityComparer<T>.Default.Equals(value, default))
            {
                var result = _diskCacheRepository.SetAsync(cacheKey, value).GetAwaiter().GetResult();

                if (result)
                {
                    var dateTimeObj = getPropValue(value!, "DateTimeSlidingExpiration");
                    string dateTimeStr = dateTimeObj?.ToString() ?? string.Empty;

                    var cacheIdObj = getPropValue(value!, "CacheId");
                    string cacheId = cacheIdObj?.ToString() ?? string.Empty;

                    DateTime dateTimeSlidingExpiration;
                    DateTime.TryParseExact(dateTimeStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTimeSlidingExpiration);
                    OnDiskCacheSaved(cacheKey, cacheId, dateTimeSlidingExpiration);
                }
                return result;
            }
            return false;
        }

        /// <summary>
        /// Hook para auditoria de produto (ex.: ApplicationCacheLog no host).
        /// </summary>
        protected virtual void OnDiskCacheSaved(string cacheKey, string cacheId, DateTime dateTimeSlidingExpiration)
        {
        }

        /// <summary>
        /// Hook para auditoria de produto ao expirar item em disco.
        /// </summary>
        protected virtual void OnDiskCacheExpired(string cacheKey)
        {
        }

        private bool checkCacheIsValid<T>(KeyValuePair<bool, T> resultDisk, string cacheKey) where T : class, new()
        {
            if (resultDisk.Value != null)
            {
                var valorData = getPropValue(resultDisk.Value, "Data");

                if (valorData != null)
                {
                    var valorExpiracao = getPropValue(resultDisk.Value, "DateTimeSlidingExpiration");
                    DateTime dataExpiracao;

                    bool temData = DateTime.TryParseExact(valorExpiracao?.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataExpiracao);

                    if (temData && dataExpiracao != DateTime.MinValue && DateTime.Now >= dataExpiracao)
                    {
                        _diskCacheRepository.RemoveAsync(cacheKey).GetAwaiter().GetResult();
                        OnDiskCacheExpired(cacheKey);

                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        private static object? getPropValue(object source, string propertyName)
        {
            var property = source.GetType().GetRuntimeProperties().FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase));
            if (property == null)
                return new object();
            return property.GetValue(source);
        }

        private static string getCacheKey<T>(string? cacheKey)
        {
            if (string.IsNullOrEmpty(cacheKey))
            {
                cacheKey = $"{typeof(T)}";
            }
            return cacheKey;
        }
        #endregion
    }
}
