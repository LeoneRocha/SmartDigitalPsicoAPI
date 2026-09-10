using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca CultureConstants — espelho de constantes SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.CultureConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando CultureConstants do SCH.")]
public static class CultureConstants
{
    public const string LanguagePTBR = Sch.CultureConstants.LanguagePTBR;
    public const string TimeZoneBrazilWindows = Sch.CultureConstants.TimeZoneBrazilWindows;
}
