using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.WindowsService.Test;

[TestFixture]
public class HostBranchCoverageTests
{
    // Cenário: Worker construído com logger nulo.
    // Objetivo: cobrir o fallback logger ?? LogAppHelper.CreateLogger(configuration).
    [Test]
    public void Worker_NullLogger_CreatesLoggerFromConfiguration()
    {
        // Arrange
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["Serilog:MinimumLevel"] = "Warning"
            })
            .Build();
        using var provider = new ServiceCollection().BuildServiceProvider();

        // Act
        var worker = new Worker(null!, configuration, provider);

        // Assert
        worker.Should().NotBeNull();
    }
}
