using Serilog;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartCoreHub.Core.SDK.Domain.Interfaces.Common;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SdpAppLogger = SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging.IAppLogger;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Logging;
using SchLogger = SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

/// <summary>
/// Adapter SDP sobre Serilog — herda <see cref="Sch.SerilogAdapter"/> (IAppLogger canônico) e expõe a superfície SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Logging.SerilogAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.2: herda SerilogAdapter SCH; implementa IAppLogger SDP (Information/ForContext).")]
public sealed class SerilogAppLoggerAdapter : Sch.SerilogAdapter, SdpAppLogger
{
    private readonly ILogger _logger;

    /// <summary>Cria o adapter reutilizando <see cref="Sch.SerilogAdapter"/>.</summary>
    public SerilogAppLoggerAdapter(ILogger logger)
        : base(logger)
    {
        _logger = logger;
    }

    /// <summary>Expõe o Serilog subjacente (bootstrap / sinks).</summary>
    public ILogger Logger => _logger;

    /// <summary>O próprio adapter é o canônico SCH.</summary>
    public SchLogger CanonicalLogger => this;

    /// <inheritdoc />
    public bool IsEnabled(ELogLevel level) => IsEnabled(ToAppLogLevel(level));

    /// <inheritdoc />
    public void Verbose(string messageTemplate, params object?[] propertyValues)
        => LogTrace(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Debug(string messageTemplate, params object?[] propertyValues)
        => LogDebug(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Information(string messageTemplate, params object?[] propertyValues)
        => LogInfo(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Warning(string messageTemplate, params object?[] propertyValues)
        => LogWarning(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Warning(Exception? exception, string messageTemplate, params object?[] propertyValues)
    {
        if (exception is null)
            LogWarning(messageTemplate, propertyValues);
        else
            LogWarning(exception, messageTemplate, propertyValues);
    }

    /// <inheritdoc />
    public void Error(string messageTemplate, params object?[] propertyValues)
        => LogError(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Error(Exception? exception, string messageTemplate, params object?[] propertyValues)
    {
        if (exception is null)
            LogError(messageTemplate, propertyValues);
        else
            LogError(exception, messageTemplate, propertyValues);
    }

    /// <inheritdoc />
    public void Fatal(string messageTemplate, params object?[] propertyValues)
        => LogCritical(messageTemplate, propertyValues);

    /// <inheritdoc />
    public void Fatal(Exception? exception, string messageTemplate, params object?[] propertyValues)
    {
        if (exception is null)
            LogCritical(messageTemplate, propertyValues);
        else
            LogCritical(exception, messageTemplate, propertyValues);
    }

    /// <inheritdoc />
    public SdpAppLogger ForContext(string propertyName, object? value, bool destructureObjects = false)
        => new SerilogAppLoggerAdapter(_logger.ForContext(propertyName, value, destructureObjects));

    /// <inheritdoc />
    public SdpAppLogger ForContext<TSource>()
        => new SerilogAppLoggerAdapter(_logger.ForContext<TSource>());

    private static AppLogLevel ToAppLogLevel(ELogLevel level) => level switch
    {
        ELogLevel.Verbose => AppLogLevel.Trace,
        ELogLevel.Debug => AppLogLevel.Debug,
        ELogLevel.Information => AppLogLevel.Information,
        ELogLevel.Warning => AppLogLevel.Warning,
        ELogLevel.Error => AppLogLevel.Error,
        ELogLevel.Fatal => AppLogLevel.Critical,
        _ => AppLogLevel.Information
    };
}
