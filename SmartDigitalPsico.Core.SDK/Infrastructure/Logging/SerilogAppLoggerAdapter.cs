using Serilog;
using Serilog.Events;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Logging
{
    /// <summary>
    /// Adapter que concentra a dependência de Serilog. Único ponto do SDK que referencia Serilog.ILogger.
    /// </summary>
    public sealed class SerilogAppLoggerAdapter : IAppLogger
    {
        private readonly ILogger _logger;

        public SerilogAppLoggerAdapter(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// Expõe o logger Serilog subjacente apenas para bootstrap de host (UseSerilog / sinks).
        /// </summary>
        public ILogger InnerLogger => _logger;

        public bool IsEnabled(ELogLevel level)
            => _logger.IsEnabled(ToSerilogLevel(level));

        public void Verbose(string messageTemplate, params object?[] propertyValues)
            => _logger.Verbose(messageTemplate, propertyValues);

        public void Debug(string messageTemplate, params object?[] propertyValues)
            => _logger.Debug(messageTemplate, propertyValues);

        public void Information(string messageTemplate, params object?[] propertyValues)
            => _logger.Information(messageTemplate, propertyValues);

        public void Warning(string messageTemplate, params object?[] propertyValues)
            => _logger.Warning(messageTemplate, propertyValues);

        public void Warning(Exception? exception, string messageTemplate, params object?[] propertyValues)
            => _logger.Warning(exception, messageTemplate, propertyValues);

        public void Error(string messageTemplate, params object?[] propertyValues)
            => _logger.Error(messageTemplate, propertyValues);

        public void Error(Exception? exception, string messageTemplate, params object?[] propertyValues)
            => _logger.Error(exception, messageTemplate, propertyValues);

        public void Fatal(string messageTemplate, params object?[] propertyValues)
            => _logger.Fatal(messageTemplate, propertyValues);

        public void Fatal(Exception? exception, string messageTemplate, params object?[] propertyValues)
            => _logger.Fatal(exception, messageTemplate, propertyValues);

        public IAppLogger ForContext(string propertyName, object? value, bool destructureObjects = false)
            => new SerilogAppLoggerAdapter(_logger.ForContext(propertyName, value, destructureObjects));

        public IAppLogger ForContext<TSource>()
            => new SerilogAppLoggerAdapter(_logger.ForContext<TSource>());

        private static LogEventLevel ToSerilogLevel(ELogLevel level) => level switch
        {
            ELogLevel.Verbose => LogEventLevel.Verbose,
            ELogLevel.Debug => LogEventLevel.Debug,
            ELogLevel.Information => LogEventLevel.Information,
            ELogLevel.Warning => LogEventLevel.Warning,
            ELogLevel.Error => LogEventLevel.Error,
            ELogLevel.Fatal => LogEventLevel.Fatal,
            _ => LogEventLevel.Information
        };
    }
}
