using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de níveis de log SDP/Serilog-like.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ELogLevel",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH ELogLevel.")]
public enum ELogLevel
{
    Verbose = (int)SchEnums.ELogLevel.Verbose,
    Debug = (int)SchEnums.ELogLevel.Debug,
    Information = (int)SchEnums.ELogLevel.Information,
    Warning = (int)SchEnums.ELogLevel.Warning,
    Error = (int)SchEnums.ELogLevel.Error,
    Fatal = (int)SchEnums.ELogLevel.Fatal,
}
