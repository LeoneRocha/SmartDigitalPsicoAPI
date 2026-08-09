using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using SmartDigitalPsico.WindowsService.Configure;

namespace SmartDigitalPsico.WindowsService.Test;

[TestFixture]
public class WindowsServiceConfigureServiceCollectionsTests
{
    // Cenário: o serviço Windows inicia com configuração mínima.
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
        WindowsServiceConfigureServiceCollections.Configure(services, configuration, logger);

        // Assert
        services.Should().NotBeEmpty();
    }
}
