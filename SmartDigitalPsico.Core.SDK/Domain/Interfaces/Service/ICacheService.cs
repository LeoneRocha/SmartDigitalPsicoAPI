using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;

/// <summary>
/// Casca ICacheService — alias SDP do cache <b>L1</b> (<see cref="ILocalCacheService"/>).
/// Não confundir com <c>SmartCoreHub.Core.SDK.Domain.Interfaces.Common.ICacheService</c> (L2).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.ILocalCacheService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "EVO.7: alias SDP de ILocalCacheService (L1); Domain.ICacheService SCH = L2.")]
public interface ICacheService : ILocalCacheService
{
}
