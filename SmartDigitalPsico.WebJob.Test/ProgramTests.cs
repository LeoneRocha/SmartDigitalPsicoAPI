using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using Serilog;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.WebJob.Test;

[TestFixture]
public class ProgramTests
{
    // Cenário: o WebJob é iniciado somente para validar as configurações.
    // Objetivo: garantir que o bootstrap não inicie um host de longa duração.
    [Test]
    public async Task Main_ValidateStartupArgument_BuildsHostWithoutRunningIt()
    {
        // Arrange

        // Act
        var action = async () => await Program.Main(["--validate-startup"]);

        // Assert
        await action.Should().NotThrowAsync();
    }

    // Cenário: o WebJob é iniciado sem a opção de validação.
    // Objetivo: garantir que o runner injetado receba o host sem executar trabalho real.
    [Test]
    public async Task RunAsync_DefaultArgument_InvokesHostRunner()
    {
        // Arrange
        var runnerCalled = false;

        // Act
        await Program.RunAsync([], _ =>
        {
            runnerCalled = true;
            return Task.CompletedTask;
        });

        // Assert
        runnerCalled.Should().BeTrue();
    }

    // Cenário: o WebJob é configurado para processamento contínuo.
    // Objetivo: garantir o registro do hosted service durante o bootstrap.
    [Test]
    public async Task RunAsync_ContinuousMode_RegistersHostedServiceWithoutRunningIt()
    {
        // Arrange
        const string variable = "JobSettings__ExecutionMode";
        var previousValue = Environment.GetEnvironmentVariable(variable);
        Environment.SetEnvironmentVariable(variable, "Continuous");
        try
        {
            // Act
            var action = async () => await Program.RunAsync(["--validate-startup"]);

            // Assert
            await action.Should().NotThrowAsync();
        }
        finally
        {
            Environment.SetEnvironmentVariable(variable, previousValue);
        }
    }

    // Cenário: o WebJob está configurado para execução única.
    // Objetivo: garantir que o serviço de notificações seja executado e o host finalize.
    [Test]
    public async Task RunHostAsync_OneTimeMode_ExecutesBackgroundJob()
    {
        // Arrange
        var jobService = new Mock<IBackgroundJobService>();
        var host = CreateHost("OneTime", jobService.Object);
        using var logger = new LoggerConfiguration().CreateLogger();

        // Act
        await Program.RunHostAsync(host.Object, loggerOverride: logger);

        // Assert
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    // Cenário: o WebJob está configurado para execução contínua.
    // Objetivo: garantir que o runner do host seja acionado sem bloquear o teste.
    [Test]
    public async Task RunHostAsync_ContinuousMode_InvokesContinuousRunner()
    {
        // Arrange
        var host = CreateHost("Continuous");
        using var logger = new LoggerConfiguration().CreateLogger();
        var runnerCalled = false;

        // Act
        await Program.RunHostAsync(
            host.Object,
            _ =>
            {
                runnerCalled = true;
                return Task.CompletedTask;
            },
            logger);

        // Assert
        runnerCalled.Should().BeTrue();
    }

    // Cenário: a execução única não possui o serviço obrigatório registrado.
    // Objetivo: garantir que a falha de configuração seja explícita.
    [Test]
    public async Task RunHostAsync_OneTimeModeWithoutJobService_ThrowsConfigurationException()
    {
        // Arrange
        var host = CreateHost("OneTime");
        using var logger = new LoggerConfiguration().CreateLogger();

        // Act
        var action = async () => await Program.RunHostAsync(host.Object, loggerOverride: logger);

        // Assert
        await action.Should().ThrowAsync<InvalidOperationException>();
    }

    // Cenário: o WebJob sobe em ambiente Production.
    // Objetivo: cobrir a seleção de appsettings.json no ConfigureAppConfiguration.
    [Test]
    public async Task RunAsync_ProductionEnvironment_LoadsProductionConfigFile()
    {
        // Arrange
        var isProduction = false;

        // Act
        await Program.RunAsync([], host =>
        {
            isProduction = host.Services.GetRequiredService<IHostEnvironment>().IsProduction();
            return Task.CompletedTask;
        }, Environments.Production);

        // Assert
        isProduction.Should().BeTrue();
    }

    // Cenário: o WebJob sobe em ambiente Development.
    // Objetivo: cobrir a seleção de appsettings.{Environment}.json quando não é Production.
    [Test]
    public async Task RunAsync_DevelopmentEnvironment_LoadsEnvironmentConfigFile()
    {
        // Arrange
        Program.ConfigureHostForTests = builder =>
            builder.UseDefaultServiceProvider(options =>
            {
                options.ValidateScopes = false;
                options.ValidateOnBuild = false;
            });
        var isDevelopment = false;
        try
        {
            // Act
            await Program.RunAsync([], host =>
            {
                isDevelopment = host.Services.GetRequiredService<IHostEnvironment>().IsDevelopment();
                return Task.CompletedTask;
            }, Environments.Development);

            // Assert
            isDevelopment.Should().BeTrue();
        }
        finally
        {
            Program.ConfigureHostForTests = null;
        }
    }

    // Cenário: RunAsync sem hostRunner customizado em OneTime.
    // Objetivo: cobrir o coalescing padrão que delega para RunHostAsync.
    [Test]
    public async Task RunAsync_NullHostRunner_UsesDefaultRunHostAsync()
    {
        // Arrange
        Program.ConfigureHostForTests = builder =>
            builder.ConfigureServices(services =>
            {
                var existing = services.Where(d => d.ServiceType == typeof(IBackgroundJobService)).ToList();
                foreach (var descriptor in existing)
                {
                    services.Remove(descriptor);
                }
                services.AddSingleton(_ => Mock.Of<IBackgroundJobService>());
            });
        try
        {
            // Act
            var action = async () => await Program.RunAsync([], hostRunner: null, Environments.Production);

            // Assert
            await action.Should().NotThrowAsync();
        }
        finally
        {
            Program.ConfigureHostForTests = null;
        }
    }

    // Cenário: RunHostAsync contínuo sem continuousHostRunner.
    // Objetivo: cobrir o coalescing padrão currentHost.RunAsync() e encerrar via lifetime.
    [Test]
    public async Task RunHostAsync_ContinuousNullRunner_UsesDefaultHostRunAsync()
    {
        // Arrange
        using var logger = new LoggerConfiguration().CreateLogger();
        var lifetime = new FakeHostApplicationLifetime();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["JobSettings:ExecutionMode"] = "Continuous"
            })
            .Build();
        var services = new ServiceCollection()
            .AddSingleton<IConfiguration>(configuration)
            .AddSingleton<IHostApplicationLifetime>(lifetime);
        var host = new Mock<IHost>();
        host.SetupGet(h => h.Services).Returns(services.BuildServiceProvider());
        host.Setup(h => h.StartAsync(It.IsAny<CancellationToken>()))
            .Callback(() => lifetime.StopApplication())
            .Returns(Task.CompletedTask);
        host.Setup(h => h.StopAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

        // Act
        await Program.RunHostAsync(host.Object, continuousHostRunner: null, loggerOverride: logger);

        // Assert
        host.Verify(h => h.StartAsync(It.IsAny<CancellationToken>()), Times.Once);
        host.Verify(h => h.StopAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    // Cenário: RunHostAsync reutiliza o logger criado no bootstrap.
    // Objetivo: cobrir loggerOverride nulo com _logger já inicializado.
    [Test]
    public async Task RunHostAsync_WithoutLoggerOverride_UsesBootstrapLogger()
    {
        // Arrange
        await Program.RunAsync(["--validate-startup"]);
        var jobService = new Mock<IBackgroundJobService>();
        var host = CreateHost("OneTime", jobService.Object);

        // Act
        await Program.RunHostAsync(host.Object);

        // Assert
        jobService.Verify(service => service.ExecuteNotificationProcessAsync(), Times.Once);
    }

    private sealed class FakeHostApplicationLifetime : IHostApplicationLifetime
    {
        private readonly CancellationTokenSource _stopping = new();
        public CancellationToken ApplicationStarted => CancellationToken.None;
        public CancellationToken ApplicationStopping => _stopping.Token;
        public CancellationToken ApplicationStopped => CancellationToken.None;
        public void StopApplication()
        {
            if (!_stopping.IsCancellationRequested)
            {
                _stopping.Cancel();
            }
        }
    }

    // Cenário: RunHostAsync é chamado sem logger configurado.
    // Objetivo: cobrir o throw do coalescing quando loggerOverride e _logger são nulos.
    [Test]
    public async Task RunHostAsync_WithoutAnyLogger_ThrowsInvalidOperationException()
    {
        // Arrange
        typeof(Program)
            .GetField("_logger", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)!
            .SetValue(null, null);
        var host = CreateHost("OneTime");

        // Act
        var action = async () => await Program.RunHostAsync(host.Object);

        // Assert
        await action.Should().ThrowAsync<InvalidOperationException>()
            .WithMessage("*logger was not configured*");
    }

    private static Mock<IHost> CreateHost(string executionMode, IBackgroundJobService? jobService = null)
    {
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["JobSettings:ExecutionMode"] = executionMode
            })
            .Build();
        var services = new ServiceCollection()
            .AddSingleton<IConfiguration>(configuration);
        if (jobService != null)
        {
            services.AddSingleton(jobService);
        }

        var host = new Mock<IHost>();
        host.SetupGet(currentHost => currentHost.Services).Returns(services.BuildServiceProvider());
        return host;
    }
}
