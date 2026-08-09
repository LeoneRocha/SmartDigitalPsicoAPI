using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging
{
    /// <summary>
    /// Abstração de logging da aplicação. Consumidores devem depender desta interface
    /// (não de Serilog.ILogger). Implementação canônica: SerilogAppLoggerAdapter.
    /// </summary>
    public interface IAppLogger
    {
        bool IsEnabled(ELogLevel level);

        void Verbose(string messageTemplate, params object?[] propertyValues);

        void Debug(string messageTemplate, params object?[] propertyValues);

        void Information(string messageTemplate, params object?[] propertyValues);

        void Warning(string messageTemplate, params object?[] propertyValues);

        void Warning(Exception? exception, string messageTemplate, params object?[] propertyValues);

        void Error(string messageTemplate, params object?[] propertyValues);

        void Error(Exception? exception, string messageTemplate, params object?[] propertyValues);

        void Fatal(string messageTemplate, params object?[] propertyValues);

        void Fatal(Exception? exception, string messageTemplate, params object?[] propertyValues);

        IAppLogger ForContext(string propertyName, object? value, bool destructureObjects = false);

        IAppLogger ForContext<TSource>();
    }
}
