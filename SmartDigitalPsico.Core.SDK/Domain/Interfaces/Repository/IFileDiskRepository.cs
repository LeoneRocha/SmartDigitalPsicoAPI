using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Contrato FileDisk — surface SDP com <see cref="FileData"/> EntityBase
/// (não herda SCH: FileData SDP ≠ FileData SCH enxuto).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IFileDiskRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; FileData permanece EntityBase no namespace SDP.")]
public interface IFileDiskRepository
{
    Task<bool> Save(FileData item);
    Task<byte[]?> Get(FileData fileCriteria);
    Task Delete(FileData fileCriteria);
    bool Exists(FileData fileCriteria);
}
