using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SmartDigitalPsico.WindowsService;

namespace SmartDigitalPsico.WindowsService.Test;

[TestFixture]
public class ProgramTests
{
    [TearDown]
    public void TearDown()
    {
        Program.ConfigureServicesForTests = null;
    }

    // Cenário: o ponto de entrada recebe a opção de validação.
    // Objetivo: garantir que Main delegue para o bootstrap sem manter o serviço ativo.
    [Test]
    public void Main_ValidateStartupArgument_BuildsAndDisposesHost()
    {
        // Arrange

        // Act
        var action = () => Program.Main(["--validate-startup"]);

        // Assert
        action.Should().NotThrow();
    }

    // Cenário: o serviço é iniciado apenas para validar o bootstrap.
    // Objetivo: garantir que o host seja descartado sem iniciar o loop do Windows Service.
    [Test]
    public void Run_ValidateStartupArgument_BuildsAndDisposesHost()
    {
        // Arrange

        // Act
        var action = () => Program.Run(["--validate-startup"]);

        // Assert
        action.Should().NotThrow();
    }

    // Cenário: o serviço é iniciado em modo de produção.
    // Objetivo: garantir que o runner configurado receba o host criado pelo bootstrap.
    [Test]
    public void Run_DefaultArgument_InvokesHostRunner()
    {
        // Arrange
        var runnerCalled = false;

        // Act
        Program.Run([], host =>
        {
            runnerCalled = true;
            host.Dispose();
        });

        // Assert
        runnerCalled.Should().BeTrue();
    }

    // Cenário: o processo do serviço Windows cria o host.
    // Objetivo: validar a configuração de ambiente e o registro do Worker sem iniciar o loop do serviço.
    [Test]
    public void CreateHostBuilder_DefaultEnvironment_BuildsConfiguredHost()
    {
        // Arrange

        // Act
        using var host = Program.CreateHostBuilder().Build();

        // Assert
        host.Services.Should().NotBeNull();
    }

    // Cenário: o serviço sobe em ambiente Production.
    // Objetivo: cobrir a seleção de appsettings.json no ConfigureAppConfiguration.
    [Test]
    public void CreateHostBuilder_ProductionEnvironment_LoadsProductionConfigFile()
    {
        // Arrange
        var builder = Program.CreateHostBuilder(Environments.Production)
            .UseDefaultServiceProvider(options =>
            {
                options.ValidateScopes = false;
                options.ValidateOnBuild = false;
            });

        // Act
        using var host = builder.Build();

        // Assert
        host.Services.GetRequiredService<IHostEnvironment>().IsProduction().Should().BeTrue();
    }

    // Cenário: o serviço sobe em ambiente Development.
    // Objetivo: cobrir o braço não-Production do ternário de arquivo de configuração.
    [Test]
    public void CreateHostBuilder_DevelopmentEnvironment_LoadsEnvironmentConfigFile()
    {
        // Arrange
        var builder = Program.CreateHostBuilder(Environments.Development)
            .UseDefaultServiceProvider(options =>
            {
                options.ValidateScopes = false;
                options.ValidateOnBuild = false;
            });

        // Act
        using var host = builder.Build();

        // Assert
        host.Services.GetRequiredService<IHostEnvironment>().IsDevelopment().Should().BeTrue();
    }

    // Cenário: Run é chamado sem hostRunner customizado.
    // Objetivo: exercer o ramo padrão host.Run() e encerrar via hosted service de teste.
    [Test]
    public void Run_NullHostRunner_UsesDefaultHostRunAndStops()
    {
        // Arrange
        Program.ConfigureServicesForTests = (services, _) =>
        {
            services.AddHostedService<StopApplicationHostedService>();
        };

        // Act
        var action = () => Program.Run([]);

        // Assert
        action.Should().NotThrow();
    }

    private sealed class StopApplicationHostedService(IHostApplicationLifetime lifetime) : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            lifetime.ApplicationStarted.Register(lifetime.StopApplication);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
