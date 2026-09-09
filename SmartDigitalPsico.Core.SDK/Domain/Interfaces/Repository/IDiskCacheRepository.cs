using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Casca: contrato de cache em disco — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IDiskCacheRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IDiskCacheRepository em SmartCoreHub.Core.SDK.")]
public interface IDiskCacheRepository : SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IDiskCacheRepository
{
}
