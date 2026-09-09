using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.AppException;

/// <summary>
/// Casca AppWarningException — herda SCH Common.Exceptions (namespace SDP estável).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Common.Exceptions.AppWarningException",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando AppWarningException em SmartCoreHub.Core.SDK.")]
public class AppWarningException : SmartCoreHub.Core.SDK.Common.Exceptions.AppWarningException
{
    public AppWarningException()
    {
    }

    public AppWarningException(string? message) : base(message)
    {
    }

    public AppWarningException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
