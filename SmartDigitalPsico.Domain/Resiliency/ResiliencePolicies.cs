namespace SmartDigitalPsico.Domain.Resiliency
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ResiliencePolicies
    {
        public static Polly.IAsyncPolicy GetPolicyFromConfig(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig config)
            => SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.GetPolicyFromConfig(config);

        public static Polly.IAsyncPolicy CustomRetryPolicy(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig policyConfig)
            => SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.CustomRetryPolicy(policyConfig);

        public static Polly.Retry.AsyncRetryPolicy CreateRetryPolicy(int retryCount, int retryDelayInSeconds)
            => SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.CreateRetryPolicy(retryCount, retryDelayInSeconds);

        public static Polly.Retry.AsyncRetryPolicy DefaultRetryPolicy
            => SmartDigitalPsico.Core.SDK.Domain.Resiliency.ResiliencePolicies.DefaultRetryPolicy;
    }
}
