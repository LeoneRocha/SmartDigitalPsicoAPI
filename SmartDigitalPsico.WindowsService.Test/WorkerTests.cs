using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.WindowsService.Test;

[TestFixture]
public class WorkerTests
{
    // Cenário: o construtor recebe logger nulo.
    // Objetivo: cobrir o fallback LogAppHelper.CreateLogger(configuration).
    [Test]
    public void Constructor_NullLogger_CreatesLoggerFromConfiguration()
    {
        // Arrange
        using var provider = new ServiceCollection().BuildServiceProvider();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["Logging:LogLevel:Default"] = "Information"
            })
            .Build();

        // Act
        var worker = new TestableWorker(null!, configuration, provider);

        // Assert
        worker.Should().NotBeNull();
    }

    // Cenário: o cancelamento ocorre após o primeiro delay concluído.
    // Objetivo: garantir que o worker saia normalmente após processar um job.
    [Test]
    public async Task ExecuteAsync_CancelledAfterDelay_ExitsAfterOneExecution()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        var jobService = new Mock<IBackgroundJobService>();
        var services = new ServiceCollection();
        services.AddScoped(_ => jobService.Object);
        await using var provider = services.BuildServiceProvider();
        var worker = new CancellingDelayWorker(
            Mock.Of<IAppLogger>(),
            new ConfigurationBuilder().Build(),
            provider,
            cancellation);

        // Act
        await worker.ExecutePublicAsync(cancellation.Token);

        // Assert
        jobService.Verify(item => item.ExecuteNotificationProcessAsync(), Times.Once);
    }

    // Cenário: o Windows Service já recebeu cancelamento antes do processamento.
    // Objetivo: garantir que o worker encerre sem criar escopo ou executar o job.
    [Test]
    public async Task ExecuteAsync_AlreadyCancelled_ExitsWithoutExecutingJob()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        var jobService = new Mock<IBackgroundJobService>();
        await using var provider = new ServiceCollection().BuildServiceProvider();
        var worker = new TestableWorker(
            Mock.Of<IAppLogger>(),
            new ConfigurationBuilder().Build(),
            provider);

        // Act
        await worker.ExecutePublicAsync(cancellation.Token);

        // Assert
        jobService.Verify(item => item.ExecuteNotificationProcessAsync(), Times.Never);
    }

    // Cenário: o worker recebe cancelamento depois do primeiro processamento.
    // Objetivo: confirmar que o job resolvido pelo escopo é executado.
    [Test]
    public async Task ExecuteAsync_CanceladoAposPrimeiroCiclo_ExecutaJobUmaVez()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        var jobService = new Mock<IBackgroundJobService>();
        jobService
            .Setup(service => service.ExecuteNotificationProcessAsync())
            .Callback(cancellation.Cancel)
            .Returns(Task.CompletedTask);
        var services = new ServiceCollection();
        services.AddScoped(_ => jobService.Object);
        await using var provider = services.BuildServiceProvider();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["TaskDelayMinutes"] = "1" })
            .Build();
        var worker = new TestableWorker(Mock.Of<IAppLogger>(), configuration, provider);

        // Act
        var action = () => worker.ExecutePublicAsync(cancellation.Token);

        // Assert
        await action.Should().ThrowAsync<TaskCanceledException>();
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    // Cenário: ciclo de vida padrão do worker.
    // Objetivo: validar os ganchos de início e parada.
    [Test]
    public async Task StartStopAsync_Cancelado_CompletamSemErro()
    {
        // Arrange
        await using var provider = new ServiceCollection().BuildServiceProvider();
        var worker = new TestableWorker(
            Mock.Of<IAppLogger>(),
            new ConfigurationBuilder().Build(),
            provider);

        // Act
        await worker.StartAsync(CancellationToken.None);
        await worker.StopAsync(CancellationToken.None);

        // Assert
        true.Should().BeTrue();
    }

    // Cenário: o job resolvido pelo escopo lança uma exceção.
    // Objetivo: garantir que o worker trata a falha e aguarda o cancelamento.
    [Test]
    public async Task ExecuteAsync_JobThrows_LogsErrorAndWaitsForCancellation()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        var jobService = new Mock<IBackgroundJobService>();
        jobService
            .Setup(service => service.ExecuteNotificationProcessAsync())
            .Callback(cancellation.Cancel)
            .ThrowsAsync(new InvalidOperationException("Falha simulada"));
        var services = new ServiceCollection();
        services.AddScoped(_ => jobService.Object);
        await using var provider = services.BuildServiceProvider();
        var worker = new TestableWorker(
            Mock.Of<IAppLogger>(),
            new ConfigurationBuilder().AddInMemoryCollection(
                new Dictionary<string, string?> { ["TaskDelayMinutes"] = "1" }).Build(),
            provider);

        // Act
        var action = () => worker.ExecutePublicAsync(cancellation.Token);

        // Assert
        await action.Should().ThrowAsync<TaskCanceledException>();
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    private class TestableWorker(
        IAppLogger logger,
        IConfiguration configuration,
        IServiceProvider serviceProvider) : Worker(logger, configuration, serviceProvider)
    {
        public Task ExecutePublicAsync(CancellationToken cancellationToken) => ExecuteAsync(cancellationToken);
    }

    private sealed class CancellingDelayWorker(
        IAppLogger logger,
        IConfiguration configuration,
        IServiceProvider serviceProvider,
        CancellationTokenSource cancellation) : TestableWorker(logger, configuration, serviceProvider)
    {
        protected override Task DelayAsync(TimeSpan delay, CancellationToken stoppingToken)
        {
            cancellation.Cancel();
            return Task.CompletedTask;
        }
    }
}
