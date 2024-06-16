using Polly;
using Polly.Retry;
using SmartDigitalPsico.Domain.Interfaces;
using System.Data;

namespace SmartDigitalPsico.Domain.Resiliency
{
    public static class ResiliencePolicies
    {
        public static AsyncRetryPolicy DefaultRetryPolicy => Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(new[]
            {
                    TimeSpan.FromSeconds(1),
                    TimeSpan.FromSeconds(2),
                    TimeSpan.FromSeconds(3)
            });

        public static IAsyncPolicy CustomRetryPolicy(IPolicyConfig policyConfig)
        {
            // Use default values if not specified in the configuration
            var retryCount = policyConfig.RetryCount > 0 ? policyConfig.RetryCount : 3;
            var retryDelayInSeconds = policyConfig.RetryDelayInSeconds > 0 ? policyConfig.RetryDelayInSeconds : 1;

            return CreateRetryPolicy(retryCount, retryDelayInSeconds);
        }

        public static AsyncRetryPolicy CreateRetryPolicy(int retryCount, int retryDelayInSeconds)
        {
            return Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(Enumerable.Range(1, retryCount)
                    .Select(retryAttempt => TimeSpan.FromSeconds(retryDelayInSeconds * retryAttempt)));
        }

        public static IAsyncPolicy GetPolicyFromConfig(IPolicyConfig policyConfig)
        {
            if (!string.IsNullOrEmpty(policyConfig.PolicyName))
            {
                switch (policyConfig.PolicyName)
                {
                    case "DefaultRetryPolicy":
                        return DefaultRetryPolicy;
                    case "CustomRetryPolicy":
                        return CustomRetryPolicy(policyConfig); 
                    default:
                        throw new InvalidOperationException("Invalid policy name");
                }
            }
            return DefaultRetryPolicy;
        }
    }
}