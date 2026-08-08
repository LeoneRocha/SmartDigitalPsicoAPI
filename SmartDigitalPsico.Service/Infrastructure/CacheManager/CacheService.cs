using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Infrastructure.CacheManager
{
    /// <summary>
    /// Bridge de produto sobre CacheService do Core — adiciona ApplicationCacheLog.
    /// DI deve registrar este tipo (não o Core direto) para manter auditoria de cache.
    /// </summary>
    public class CacheService : SmartDigitalPsico.Core.SDK.Service.Infrastructure.CacheManager.CacheService
    {
        private readonly IApplicationCacheLogRepository _applicationCacheLogRepository;

        public CacheService(
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository memoryCacheRepository,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository diskCacheRepository,
            IApplicationCacheLogRepository applicationCacheLogRepository,
            IOptions<CacheConfigurationDto> cacheConfig)
            : base(memoryCacheRepository, diskCacheRepository, cacheConfig)
        {
            _applicationCacheLogRepository = applicationCacheLogRepository;
        }

        protected override void OnDiskCacheSaved(string cacheKey, string cacheId, DateTime dateTimeSlidingExpiration)
        {
            var addLogCache = new ApplicationCacheLog()
            {
                CacheKey = cacheKey,
                CacheId = cacheId,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc(),
                ModifyDate = DateHelper.GetDateTimeNowFromUtc(),
                LastAccessDate = DateHelper.GetDateTimeNowFromUtc(),
                DateTimeSlidingExpiration = dateTimeSlidingExpiration,
                Enable = true
            };
            _applicationCacheLogRepository.Create(addLogCache).GetAwaiter().GetResult();
        }

        protected override void OnDiskCacheExpired(string cacheKey)
        {
            _applicationCacheLogRepository.Delete(cacheKey).GetAwaiter().GetResult();
        }
    }
}
