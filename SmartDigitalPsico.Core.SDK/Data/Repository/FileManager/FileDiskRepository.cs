using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SchFile = SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;

/// <summary>
/// Casca FileDisk — delega SCH; mapeia <see cref="FileData"/> SDP (EntityBase) ↔ SCH enxuto.
/// <see cref="Domain.EntityModels.Contracts.FileBase"/> permanece retenção EntityBase para domínio EF.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.FileDiskRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Bridge FileData SDP↔SCH; OpenReadForTests encaminhado ao SCH.")]
public class FileDiskRepository : Domain.Interfaces.Repository.IFileDiskRepository
{
    private readonly SchFile.FileDiskRepository _inner = new();

    /// <summary>Encaminha hook de teste ao SCH.</summary>
    public static Func<string, Stream>? OpenReadForTests
    {
        get => SchFile.FileDiskRepository.OpenReadForTests;
        set => SchFile.FileDiskRepository.OpenReadForTests = value;
    }

    public Task<bool> Save(FileData item)
        => _inner.Save(ToSch(item));

    public Task<byte[]?> Get(FileData fileCriteria)
        => _inner.Get(ToSch(fileCriteria));

    public Task Delete(FileData fileCriteria)
        => _inner.Delete(ToSch(fileCriteria));

    public bool Exists(FileData fileCriteria)
        => _inner.Exists(ToSch(fileCriteria));

    internal static SchFile.FileData ToSch(FileData item)
    {
        ArgumentNullException.ThrowIfNull(item);
        return new SchFile.FileData
        {
            FileName = item.FileName,
            FilePath = item.FilePath,
            FileData = item.FileData,
            CreatedDate = item.CreatedDate,
            FolderDestination = item.FolderDestination,
        };
    }

    internal static FileData FromSch(SchFile.FileData item)
    {
        ArgumentNullException.ThrowIfNull(item);
        return new FileData
        {
            FileName = item.FileName,
            FilePath = item.FilePath,
            FileData = item.FileData ?? [],
            CreatedDate = item.CreatedDate,
            FolderDestination = item.FolderDestination,
        };
    }
}
