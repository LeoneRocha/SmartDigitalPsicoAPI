using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_CACHE")]
    public class DiskCacheRepository : SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository
    {
        public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationDto> cacheConfig)
            : base(repositoryFileDisk, cacheConfig)
        {
        }
    }
}
