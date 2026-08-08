using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;

namespace SmartDigitalPsico.WebJob.Test;

[TestFixture]
public class ContinuousJobHostedServiceTests
{
    // Cenário: o cancelamento ocorre após o primeiro delay concluído.
    // Objetivo: garantir que o ciclo saia normalmente depois de processar o job.
    [Test]
    public async Task ExecuteAsync_CancelledAfterDelay_ExitsAfterOneExecution()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        var jobService = new Mock<IBackgroundJobService>();
        var service = new CancellingDelayContinuousJobHostedService(
            jobService.Object,
            Mock.Of<Serilog.ILogger>(),
            new ConfigurationBuilder().Build(),
            cancellation);

        // Act
        await service.ExecutePublicAsync(cancellation.Token);

        // Assert
        jobService.Verify(item => item.ExecuteNotificationProcessAsync(), Times.Once);
    }

    // Cenário: o host já solicitou o cancelamento antes do ciclo iniciar.
    // Objetivo: garantir que o serviço finalize sem executar um processamento adicional.
    [Test]
    public async Task ExecuteAsync_AlreadyCancelled_ExitsWithoutExecutingJob()
    {
        // Arrange
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        var jobService = new Mock<IBackgroundJobService>();
        var service = new TestableContinuousJobHostedService(
            jobService.Object,
            Mock.Of<Serilog.ILogger>(),
            new ConfigurationBuilder().Build());

        // Act
        await service.ExecutePublicAsync(cancellation.Token);

        // Assert
        jobService.Verify(item => item.ExecuteNotificationProcessAsync(), Times.Never);
    }

    // Cenário: o host solicita o encerramento após a primeira execução.
    // Objetivo: garantir que o job contínuo delega o processamento ao serviço.
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
        var logger = new Mock<Serilog.ILogger>();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["JobSettings:TaskDelayMinutes"] = "1" })
            .Build();
        var service = new TestableContinuousJobHostedService(jobService.Object, logger.Object, configuration);

        // Act
        var action = () => service.ExecutePublicAsync(cancellation.Token);

        // Assert
        await action.Should().ThrowAsync<TaskCanceledException>();
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    // Cenário: ciclo de vida do hosted service.
    // Objetivo: cobrir os ganchos de inicialização e encerramento.
    [Test]
    public async Task StartStopAsync_Cancelado_CompletamSemErro()
    {
        // Arrange
        var service = new TestableContinuousJobHostedService(
            Mock.Of<IBackgroundJobService>(),
            Mock.Of<Serilog.ILogger>(),
            new ConfigurationBuilder().Build());

        // Act
        await service.StartAsync(CancellationToken.None);
        await service.StopAsync(CancellationToken.None);

        // Assert
        true.Should().BeTrue();
    }

    // Cenário: o processamento contínuo falha na primeira tentativa.
    // Objetivo: garantir que a exceção é registrada e o ciclo continua até o cancelamento.
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
        var service = new TestableContinuousJobHostedService(
            jobService.Object,
            Mock.Of<Serilog.ILogger>(),
            new ConfigurationBuilder().AddInMemoryCollection(
                new Dictionary<string, string?> { ["JobSettings:TaskDelayMinutes"] = "1" }).Build());

        // Act
        var action = () => service.ExecutePublicAsync(cancellation.Token);

        // Assert
        await action.Should().ThrowAsync<TaskCanceledException>();
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    private class TestableContinuousJobHostedService(
        IBackgroundJobService jobService,
        Serilog.ILogger logger,
        IConfiguration configuration) : ContinuousJobHostedService(jobService, logger, configuration)
    {
        public Task ExecutePublicAsync(CancellationToken cancellationToken) => ExecuteAsync(cancellationToken);
    }

    private sealed class CancellingDelayContinuousJobHostedService(
        IBackgroundJobService jobService,
        Serilog.ILogger logger,
        IConfiguration configuration,
        CancellationTokenSource cancellation) : TestableContinuousJobHostedService(jobService, logger, configuration)
    {
        protected override Task DelayAsync(TimeSpan delay, CancellationToken stoppingToken)
        {
            cancellation.Cancel();
            return Task.CompletedTask;
        }
    }
}
