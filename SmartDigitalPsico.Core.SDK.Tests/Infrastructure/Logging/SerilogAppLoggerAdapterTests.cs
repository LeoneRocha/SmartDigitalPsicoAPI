using Moq;
using Serilog;
using Serilog.Events;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Core.SDK.Tests.Infrastructure.Logging;

[TestFixture]
public class SerilogAppLoggerAdapterTests
{
    [Test]
    public void Information_ForwardsToSerilog()
    {
        var serilog = new Mock<ILogger>();
        serilog.Setup(x => x.IsEnabled(LogEventLevel.Information)).Returns(true);
        IAppLogger logger = new SerilogAppLoggerAdapter(serilog.Object);

        logger.Information("Hello {Name}", "world");

        serilog.Verify(x => x.Information("Hello {Name}", It.Is<object[]>(a => a.Length == 1 && (string)a[0]! == "world")), Times.Once);
    }

    [Test]
    public void IsEnabled_MapsELogLevelToSerilog()
    {
        var serilog = new Mock<ILogger>();
        serilog.Setup(x => x.IsEnabled(LogEventLevel.Warning)).Returns(true);
        IAppLogger logger = new SerilogAppLoggerAdapter(serilog.Object);

        logger.IsEnabled(ELogLevel.Warning).Should().BeTrue();
        serilog.Verify(x => x.IsEnabled(LogEventLevel.Warning), Times.Once);
    }

    [Test]
    public void ForContext_ReturnsWrappedLogger()
    {
        var inner = new Mock<ILogger>();
        var contextual = new Mock<ILogger>();
        inner.Setup(x => x.ForContext(It.IsAny<string>(), It.IsAny<object?>(), It.IsAny<bool>())).Returns(contextual.Object);
        IAppLogger logger = new SerilogAppLoggerAdapter(inner.Object);

        var next = logger.ForContext("UserId", 42);

        next.Should().BeOfType<SerilogAppLoggerAdapter>();
        ((SerilogAppLoggerAdapter)next).InnerLogger.Should().BeSameAs(contextual.Object);
    }

    [Test]
    public void Constructor_NullLogger_Throws()
    {
        Action act = () => _ = new SerilogAppLoggerAdapter(null!);
        act.Should().Throw<ArgumentNullException>();
    }
}
