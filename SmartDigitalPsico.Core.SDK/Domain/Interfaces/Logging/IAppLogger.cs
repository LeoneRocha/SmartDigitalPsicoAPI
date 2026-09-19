using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging
{
    /// <summary>
    /// Superfície Serilog-style retida para EntityBase / ISharedDependenciesConfig (AJ.3).
    /// Hosts independentes usam <c>SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger</c> + extensions (AJ.2).
    /// Não herda <c>ISdpAppLogger</c>: <see cref="ELogLevel"/> SDP ≠ enum SCH.
    /// </summary>
    [SdkWrappedSource(
        targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger",
        targetPackage: "SmartCoreHub.Core.SDK",
        description: "AJ.2: casca conceitual; EntityBase permanece nesta superfície até AJ.3. Canônico = Common.IAppLogger.")]
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
