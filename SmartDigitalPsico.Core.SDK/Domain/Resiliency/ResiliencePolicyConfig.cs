using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.Resiliency;

/// <summary>
/// Casca: POCO de resiliência — herda SCH e satisfaz iface SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Resilience.ResiliencePolicyConfig",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ResiliencePolicyConfig em SmartCoreHub.Core.SDK.")]
public class ResiliencePolicyConfig
    : SmartCoreHub.Core.SDK.Infrastructure.Resilience.ResiliencePolicyConfig,
      IResiliencePolicyConfig
{
}
