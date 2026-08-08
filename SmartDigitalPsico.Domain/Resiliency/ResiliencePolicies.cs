using System;

namespace SmartDigitalPsico.Domain.Resiliency
{
    [Obsolete("Use SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency.ResiliencePolicies instead.")]
    public static class ResiliencePolicies
    {
                public static Polly.IAsyncPolicy GetPolicyFromConfig(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig config) 
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency.ResiliencePolicies.GetPolicyFromConfig(config);

        public static Polly.IAsyncPolicy CustomRetryPolicy(SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig policyConfig)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency.ResiliencePolicies.CustomRetryPolicy(policyConfig);

        public static Polly.Retry.AsyncRetryPolicy CreateRetryPolicy(int retryCount, int retryDelayInSeconds)
            => SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency.ResiliencePolicies.CreateRetryPolicy(retryCount, retryDelayInSeconds);

        public static Polly.Retry.AsyncRetryPolicy DefaultRetryPolicy => SmartDigitalPsicoAPI.Core.SDK.Domain.Resiliency.ResiliencePolicies.DefaultRetryPolicy;
    }
}

