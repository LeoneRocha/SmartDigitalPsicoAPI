using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca HtmlSanitizer — delega SCH (whitelist canônica mais restrita; sem style/font livres).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.HtmlSanitizerHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Delega a SCH HtmlSanitizerHelper → RichContentSanitizerHelper (whitelist mais restrita).")]
public static class HtmlSanitizerHelper
{
    public static string Sanitize(string input)
        => Sch.HtmlSanitizerHelper.Sanitize(input);
}
