using System.Diagnostics.CodeAnalysis;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;
using SchSan = SmartCoreHub.Core.SDK.Domain.Sanitization;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca HtmlSanitizer — preferir <see cref="SchSan.RichContentSanitizerHelper.SanitizeHtml"/>.
/// </summary>
[Obsolete(
    "Use SmartCoreHub.Core.SDK.Domain.Sanitization.RichContentSanitizerHelper.SanitizeHtml. " +
    "Remocao da casca apos OK mantenedor (sunset S.3).")]
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.HtmlSanitizerHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Delega a SCH HtmlSanitizerHelper → RichContentSanitizerHelper.")]
[SuppressMessage(
    "Major Code Smell",
    "S1133:Deprecated code should be removed",
    Justification = "Sunset casca SDP; remocao so com OK mantenedor apos hosts migrados.")]
public static class HtmlSanitizerHelper
{
    public static string Sanitize(string input)
        => Sch.HtmlSanitizerHelper.Sanitize(input);
}
