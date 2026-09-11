using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Caching.Local;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca IDataCacheDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.IDataCacheDto`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IDataCacheDto&lt;T&gt; do SCH.")]
public interface IDataCacheDto<T> : Sch.IDataCacheDto<T>
{
}
