using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Service.Email;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca EmailHelper — delega SCH ReplaceTokens.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.EmailHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para EmailHelper em SmartCoreHub.Core.SDK.")]
public static class EmailHelper
{
    public static string ReplaceTokens(string template, Dictionary<string, string> tokens)
        => Sch.EmailHelper.ReplaceTokens(template, tokens);
}
