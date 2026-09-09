using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Casca: contrato base de cache — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.ICacheRepository",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ICacheRepository em SmartCoreHub.Core.SDK.")]
public interface ICacheRepository : SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.ICacheRepository
{
}
