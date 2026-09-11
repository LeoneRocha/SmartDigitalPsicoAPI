using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Service.Configuration;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca AppConfigConstants — espelho de constantes SCH (nomes públicos SDP preservados).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Configuration.AppConfigConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando AppConfigConstants do SCH; aliases tipográficos SDP → nomes canônicos.")]
public static class AppConfigConstants
{
    public const string ApplicationContentJon = Sch.AppConfigConstants.ApplicationContentJson;
    public const string DATE_FORMAT = Sch.AppConfigConstants.DateFormat;
    public const string DATE_FORMAT2 = Sch.AppConfigConstants.DateFormatIso;
    public const string ConfigurationConfigurationNotBeNull = Sch.AppConfigConstants.ConfigurationCannotBeNull;
}
