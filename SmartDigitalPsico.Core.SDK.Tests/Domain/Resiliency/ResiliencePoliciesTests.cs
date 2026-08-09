using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Resiliency;

[TestFixture]
public class ResiliencePoliciesTests
{
    private sealed class PolicyConfig : IResiliencePolicyConfig
    {
        public string PolicyName { get; set; } = string.Empty;
        public int RetryCount { get; set; }
        public int RetryDelayInSeconds { get; set; }
    }

    [Test]
    public async Task CustomRetryPolicy_ZeroConfig_UsesDefaultRetryValues()
    {
        var attempts = 0;
        await ResiliencePolicies.CustomRetryPolicy(new PolicyConfig
        {
            PolicyName = "CustomRetryPolicy",
            RetryCount = 0,
            RetryDelayInSeconds = 0
        }).ExecuteAsync(() =>
        {
            attempts++;
            if (attempts < 2) throw new InvalidOperationException();
            return Task.CompletedTask;
        });

        attempts.Should().Be(2);
    }

    [Test]
    public async Task RetryPolicies_FailingAction_RetriesConfiguredNumberOfTimes()
    {
        var config = new PolicyConfig { PolicyName = "CustomRetryPolicy", RetryCount = 2, RetryDelayInSeconds = 0 };
        var attempts = 0;
        await ResiliencePolicies.CustomRetryPolicy(config).ExecuteAsync(() =>
        {
            attempts++;
            if (attempts < 3) throw new InvalidOperationException();
            return Task.CompletedTask;
        });
        attempts.Should().Be(3);
    }

    [Test]
    public void GetPolicyFromConfig_PolicyNames_ReturnsPolicyOrThrows()
    {
        var defaultPolicy = ResiliencePolicies.GetPolicyFromConfig(new PolicyConfig { PolicyName = "DefaultRetryPolicy" });
        var emptyPolicy = ResiliencePolicies.GetPolicyFromConfig(new PolicyConfig());
        var custom = ResiliencePolicies.GetPolicyFromConfig(new PolicyConfig
        {
            PolicyName = "CustomRetryPolicy",
            RetryCount = 1,
            RetryDelayInSeconds = 0
        });

        using (Assert.EnterMultipleScope())
        {
            defaultPolicy.Should().NotBeNull();
            emptyPolicy.Should().NotBeNull();
            custom.Should().NotBeNull();
            ((Action)(() => ResiliencePolicies.GetPolicyFromConfig(new PolicyConfig { PolicyName = "bad" })))
                .Should().Throw<InvalidOperationException>();
            ResiliencePolicies.CreateRetryPolicy(1, 0).Should().NotBeNull();
            ResiliencePolicies.DefaultRetryPolicy.Should().NotBeNull();
        }
    }
}
