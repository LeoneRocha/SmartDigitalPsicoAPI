using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Domain.Test.Resiliency;

[TestFixture]
public class ResiliencePoliciesTests
{
    // Cenário: configuração customizada usa defaults quando contadores são zero.
    // Objetivo: cobrir ramos RetryCount/RetryDelayInSeconds <= 0.
    [Test]
    public async Task CustomRetryPolicy_ZeroConfig_UsesDefaultRetryValues()
    {
        // Arrange
        var attempts = 0;

        // Act
        await ResiliencePolicies.CustomRetryPolicy(new ResiliencePolicyConfig
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

        // Assert
        attempts.Should().Be(2);
    }

    // Cenário: Políticas padrão e customizada executam uma ação que falha inicialmente.
    // Objetivo: Repetir a ação conforme a configuração.
    [Test]
    public async Task RetryPolicies_FailingAction_RetriesConfiguredNumberOfTimes()
    {
        // Arrange
        var config = new ResiliencePolicyConfig { PolicyName = "CustomRetryPolicy", RetryCount = 2, RetryDelayInSeconds = 0 };
        var attempts = 0;
        // Act
        await ResiliencePolicies.CustomRetryPolicy(config).ExecuteAsync(() =>
        {
            attempts++;
            if (attempts < 3) throw new InvalidOperationException();
            return Task.CompletedTask;
        });
        // Assert
        attempts.Should().Be(3);
    }

    // Cenário: O nome da política é padrão, customizado, vazio ou inválido.
    // Objetivo: Retornar política válida ou rejeitar nome inválido.
    [Test]
    public void GetPolicyFromConfig_PolicyNames_ReturnsPolicyOrThrows()
    {
        // Arrange
        // Act
        var defaultPolicy = ResiliencePolicies.GetPolicyFromConfig(new ResiliencePolicyConfig { PolicyName = "DefaultRetryPolicy" });
        var emptyPolicy = ResiliencePolicies.GetPolicyFromConfig(new ResiliencePolicyConfig());
        // Assert
        using (Assert.EnterMultipleScope())
        {
            defaultPolicy.Should().NotBeNull();
            emptyPolicy.Should().NotBeNull();
            ((Action)(() => ResiliencePolicies.GetPolicyFromConfig(new ResiliencePolicyConfig { PolicyName = "bad" }))).Should().Throw<InvalidOperationException>();
            ResiliencePolicies.CreateRetryPolicy(1, 0).Should().NotBeNull();
            ResiliencePolicies.DefaultRetryPolicy.Should().NotBeNull();
        }
    }
}
