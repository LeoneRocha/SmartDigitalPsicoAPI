using Microsoft.Extensions.Options;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_CACHE")]
    public class DiskCacheRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository
    {
        public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationDto> cacheConfig)
            : base(repositoryFileDisk, cacheConfig)
        {
        }
    }
}
