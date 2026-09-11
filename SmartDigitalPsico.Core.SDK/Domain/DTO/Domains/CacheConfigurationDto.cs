using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

/// <summary>
/// Casca CacheConfigurationDto — espelho SCH LocalCacheConfigurationDto com enum SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Caching.Local.LocalCacheConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca estrutural do LocalCacheConfigurationDto; enum Enuns; não herda CacheConfigurationDto canônico SCH.")]
public class CacheConfigurationDto
{
    public int AbsoluteExpirationInHours { get; set; }
    public int SlidingExpirationInMinutes { get; set; }
    public int AbsoluteExpirationInMinutes { get; set; }
    public string PathCache { get; set; } = string.Empty;
    public string ExtensionCache { get; set; } = string.Empty;
    public bool IsEnable { get; set; }
    public ETypeLocationCache TypeCache { get; set; }
}
