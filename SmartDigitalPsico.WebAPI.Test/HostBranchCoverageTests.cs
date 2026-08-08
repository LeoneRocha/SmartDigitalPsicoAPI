using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using Serilog;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI.Test;

[TestFixture]
public class HostBranchCoverageTests
{
    [TearDown]
    public void TearDown()
    {
        WebApplicationConfigureBuilder.ConfigureBuilderForTests = null;
        WebApplicationConfigureBuilder.EntityDataContextOverrideForTests = null;
    }

    // Cenário: Program.Run sem runner customizado.
    // Objetivo: exercer o coalescing padrão que delega para BuildAndRunAPP e encerra via hosted service.
    [Test]
    public void Program_RunWithNullApplicationRunner_UsesDefaultBuildAndRun()
    {
        // Arrange
        WebApplicationConfigureBuilder.ConfigureBuilderForTests = builder =>
        {
            builder.WebHost.UseUrls("http://127.0.0.1:0");
            builder.Services.AddScoped<IEntityDataContext>(_ => null!);
            builder.Services.AddHostedService<StopApplicationHostedService>();
        };

        // Act
        var action = () => SmartDigitalPsico.WebAPI.Program.Run([]);

        // Assert
        action.Should().NotThrow();
    }

    // Cenário: BuildAndRunAPP sem applicationRunner.
    // Objetivo: cobrir o ramo padrão currentApplication.Run() e encerrar o host imediatamente.
    [Test]
    public void BuildAndRunAPP_NullApplicationRunner_RunsUntilStopped()
    {
        // Arrange
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
        host.Item1.WebHost.UseUrls("http://127.0.0.1:0");
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => null!);
        host.Item1.Services.AddHostedService<StopApplicationHostedService>();
        using var logger = new LoggerConfiguration().CreateLogger();

        // Act
        var action = () => WebApplicationConfigureBuilder.BuildAndRunAPP(host.Item1, logger);

        // Assert
        action.Should().NotThrow();
    }

    // Cenário: addAutoMigrate resolve um contexto próprio e o descarta no finally.
    // Objetivo: cobrir context?.Dispose() com context não nulo e ownsContext=true.
    [Test]
    public void Configure_OwnedNonNullContext_DisposesContextInFinally()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase($"webapi-owned-dispose-{Guid.NewGuid():N}")
            .Options;
        using var inMemoryContext = new SmartDigitalPsicoDataContextMySql(options);
        var host = WebApplicationConfigureBuilder.CreateHostBuilder(["--environment", "Production"]);
        host.Item1.Services.AddScoped<IEntityDataContext>(_ => inMemoryContext);

        // Act
        using var app = WebApplicationConfigureBuilder.BuildAndConfigure(host.Item1);

        // Assert
        app.Services.Should().NotBeNull();
    }

    // Cenário: middleware de correlação com Activity.Current nula e não nula.
    // Objetivo: cobrir activity?.TraceId/SpanId e os fallbacks ?? TraceIdentifier/Empty.
    [Test]
    public async Task PushCorrelationLogProperties_WithAndWithoutActivity_CoversAllBranches()
    {
        // Arrange
        var context = new DefaultHttpContext();
        context.TraceIdentifier = "trace-fallback";
        var nextCalled = 0;
        Func<Task> next = () =>
        {
            nextCalled++;
            return Task.CompletedTask;
        };

        // Act
        System.Diagnostics.Activity.Current = null;
        await WebApplicationConfigureBuilder.PushCorrelationLogPropertiesAsync(context, next);
        using (var activity = new System.Diagnostics.Activity("webapi-branch-coverage").Start())
        {
            await WebApplicationConfigureBuilder.PushCorrelationLogPropertiesAsync(context, next);
        }

        // Assert
        nextCalled.Should().Be(2);
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
