using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_CACHE")]
    public class MemoryCacheRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository
    {
        public MemoryCacheRepository(IMemoryCache memoryCache, IOptions<CacheConfigurationDto> cacheConfig)
            : base(memoryCache, cacheConfig)
        {
        }
    }
}
