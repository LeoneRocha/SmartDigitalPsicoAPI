using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Service.Infrastructure.CacheManager
{
    /// <summary>
    /// Bridge de produto sobre CacheService do Core — adiciona ApplicationCacheLog.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — lógica canônica no pacote Core; host mantém auditoria ApplicationCacheLog.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK (ou este bridge apenas se precisar de ApplicationCacheLog).", error: false, DiagnosticId = "SDP_CORE_SDK_CACHE")]
    public class CacheService : SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.CacheManager.CacheService
    {
        private readonly IApplicationCacheLogRepository _applicationCacheLogRepository;

        public CacheService(
            SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository memoryCacheRepository,
            SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository diskCacheRepository,
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
