using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service;

/// <summary>
/// Casca ICacheService — herda <see cref="ILocalCacheService"/> (nome SDP estável).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.ILocalCacheService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias SDP de ILocalCacheService (não confundir com ICacheService canônico SCH Domain).")]
public interface ICacheService : ILocalCacheService
{
}
