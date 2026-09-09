using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca: contrato de política de resiliência — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Resilience.IResiliencePolicyConfig",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando IResiliencePolicyConfig em SmartCoreHub.Core.SDK.")]
public interface IResiliencePolicyConfig : SmartCoreHub.Core.SDK.Domain.Interfaces.Resilience.IResiliencePolicyConfig
{
}
