using Microsoft.Extensions.Options;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SchCache = SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;

/// <summary>
/// Casca DiskCache — herda SCH; adapta <see cref="IFileDiskRepository"/> SDP → SCH via bridge FileData.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.DiskCacheRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca DiskCacheRepository; FileDiskBridge mapeia FileData SDP↔SCH.")]
public class DiskCacheRepository : SchCache.DiskCacheRepository, IDiskCacheRepository
{
    public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationDto> cacheConfig)
        : base(new FileDiskBridge(repositoryFileDisk), Options.Create(MemoryCacheRepository.Map(cacheConfig.Value)))
    {
    }

    private sealed class FileDiskBridge : SchCache.IFileDiskRepository
    {
        private readonly IFileDiskRepository _inner;

        public FileDiskBridge(IFileDiskRepository inner)
            => _inner = inner ?? throw new ArgumentNullException(nameof(inner));

        public Task<bool> Save(SchCache.FileData item)
            => _inner.Save(FileDiskRepository.FromSch(item));

        public Task<byte[]?> Get(SchCache.FileData fileCriteria)
            => _inner.Get(FileDiskRepository.FromSch(fileCriteria));

        public Task Delete(SchCache.FileData fileCriteria)
            => _inner.Delete(FileDiskRepository.FromSch(fileCriteria));

        public bool Exists(SchCache.FileData fileCriteria)
            => _inner.Exists(FileDiskRepository.FromSch(fileCriteria));
    }
}
