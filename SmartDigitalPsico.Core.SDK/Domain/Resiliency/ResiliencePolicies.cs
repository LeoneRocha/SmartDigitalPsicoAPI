using Polly;
using Polly.Retry;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Resilience;

namespace SmartDigitalPsico.Core.SDK.Domain.Resiliency;

/// <summary>
/// Casca: políticas Polly — delega a <see cref="Sch.ResiliencePolicies"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Resilience.ResiliencePolicies",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para ResiliencePolicies em SmartCoreHub.Core.SDK.")]
public static class ResiliencePolicies
{
    public static AsyncRetryPolicy DefaultRetryPolicy => Sch.ResiliencePolicies.DefaultRetryPolicy;

    public static IAsyncPolicy CustomRetryPolicy(IResiliencePolicyConfig policyConfig)
        => Sch.ResiliencePolicies.CustomRetryPolicy(policyConfig);

    public static AsyncRetryPolicy CreateRetryPolicy(int retryCount, int retryDelayInSeconds)
        => Sch.ResiliencePolicies.CreateRetryPolicy(retryCount, retryDelayInSeconds);

    public static IAsyncPolicy GetPolicyFromConfig(IResiliencePolicyConfig policyConfig)
        => Sch.ResiliencePolicies.GetPolicyFromConfig(policyConfig);
}
