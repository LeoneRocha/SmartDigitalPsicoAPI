using Microsoft.Extensions.Configuration;
using Moq;
using Serilog;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using System.Diagnostics;

namespace SmartDigitalPsico.Domain.Test.Helpers;

[TestFixture]
public class LogAppHelperTests
{
    [Test]
    public void GetDurationStopwatch_ElapsedTime_ReturnsHoursMinutesSeconds()
    {
        // Cenário: um cronômetro possui duração conhecida.
        // Objetivo: formatar a duração para log.
        // Arrange
        var stopwatch = Stopwatch.StartNew();
        stopwatch.Stop();

        // Act
        var result = LogAppHelper.GetDurationStopwatch(stopwatch);

        // Assert
        result.Should().MatchRegex(@"\d{2}:\d{2}:\d{2}");
    }

    [Test]
    public void LogException_WarningAndError_UsesExpectedLoggerLevel()
    {
        // Cenário: exceções de aviso e erro são registradas.
        // Objetivo: encaminhar cada tipo ao nível Serilog correto.
        // Arrange
        var logger = new Mock<ILogger>();

        // Act
        LogAppHelper.LogException(logger.Object, new AppWarningException("warning"), "API");
        LogAppHelper.LogException(logger.Object, new InvalidOperationException("error"), "API");

        // Assert
        logger.Verify(x => x.Warning(It.Is<string>(message => message.Contains("API-Warning: warning"))), Times.Once);
        logger.Verify(x => x.Error(It.IsAny<Exception>(), It.Is<string>(message => message.Contains("API-Error: error"))), Times.Once);
    }

    [Test]
    public void CreateLogger_Configuration_ReturnsUsableLogger()
    {
        // Cenário: o logger é criado com configuração mínima.
        // Objetivo: criar uma instância Serilog utilizável.
        // Arrange
        var configuration = new ConfigurationBuilder().AddInMemoryCollection().Build();

        // Act
        using var logger = LogAppHelper.CreateLogger(configuration);

        // Assert
        logger.Should().NotBeNull();
    }

    [Test]
    public void InformationMethods_Logger_DelegatesMessages()
    {
        // Cenário: métodos encapsuladores recebem logger.
        // Objetivo: delegar logs de informação e erro.
        // Arrange
        var logger = new Mock<ILogger>();

        // Act
        LogAppHelper.LogInfo(logger.Object, "Value {Value}", 1);
        LogAppHelper.LogError(logger.Object, new Exception("failure"), "Value {Value}", 1);
        LogAppHelper.PrintLogInformationVersionProduct(logger.Object);

        // Assert
        logger.Verify(x => x.Information("Value {Value}", It.Is<object[]>(args => (int)args[0] == 1)), Times.Once);
        logger.Verify(x => x.Error(It.IsAny<Exception>(), "Value {Value}", It.Is<object[]>(args => (int)args[0] == 1)), Times.Once);
        logger.Verify(x => x.Information("******* PRODUCT INFORMATION *******"), Times.Once);
    }

    // Cenário: ASPNETCORE_ENVIRONMENT está definido.
    // Objetivo: cobrir o ramo que usa a variável de ambiente.
    [Test]
    public void GetInformationVersionProduct_EnvSet_UsesAspNetCoreEnvironment()
    {
        // Arrange
        var previous = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Staging");
        try
        {
            // Act
            var info = LogAppHelper.GetInformationVersionProduct();

            // Assert
            info.EnvironmentName.Should().Be("Staging");
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", previous);
        }
    }

    [Test]
    public void ProductInformation_EnvironmentConfigured_ReturnsVersionAndMessage()
    {
        // Cenário: o ambiente é fornecido pelas configurações.
        // Objetivo: expor as informações de produto e configurar o ambiente.
        // Arrange
        var previousEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["APP_ENVIRONMENT"] = "Testing" })
            .Build();

        try
        {
            // Act
            LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(configuration);
            var information = LogAppHelper.GetInformationVersionProduct();
            var message = LogAppHelper.ShowInformationVersionProductString();

            // Assert
            Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").Should().Be("Testing");
            LogAppHelper.GetAssemblyVersion().Should().NotBeNullOrWhiteSpace();
            information.Message.Should().Contain("PRODUCT INFORMATION");
            message.Should().Contain("PRODUCT INFORMATION");
        }
        finally
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", previousEnvironment);
        }
    }
}
