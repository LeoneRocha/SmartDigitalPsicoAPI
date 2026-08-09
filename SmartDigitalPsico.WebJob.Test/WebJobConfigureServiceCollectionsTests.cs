using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SmartDigitalPsico.WebJob.Configure;

namespace SmartDigitalPsico.WebJob.Test;

[TestFixture]
public class WebJobConfigureServiceCollectionsTests
{
    // Cenário: o host WebJob inicia com configuração mínima.
    // Objetivo: garantir que as dependências essenciais são registradas no container.
    [Test]
    public void Configure_ValidConfiguration_RegistersDependencies()
    {
        // Arrange
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>())
            .Build();
        using var logger = new LoggerConfiguration().CreateLogger();

        // Act
        WebJobConfigureServiceCollections.Configure(services, configuration, logger);

        // Assert
        services.Should().NotBeEmpty();
    }
}
