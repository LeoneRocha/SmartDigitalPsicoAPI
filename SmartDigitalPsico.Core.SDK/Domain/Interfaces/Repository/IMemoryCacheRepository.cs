using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Casca: contrato de cache em memória — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IMemoryCacheRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IMemoryCacheRepository em SmartCoreHub.Core.SDK.")]
public interface IMemoryCacheRepository : SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IMemoryCacheRepository
{
}
