using System.Security.Claims;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers.Security;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;

/// <summary>
/// Casca SecurityHelperApi — delega a SCH com cast de enum.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.Security.SecurityHelperApi",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando SecurityHelperApi ao SCH.")]
public static class SecurityHelperApi
{
    public static long GetUserIdApi(ClaimsPrincipal user, ETypeApiCredential typeApiCredential)
        => Sch.SecurityHelperApi.GetUserIdApi(user, (SchEnums.ETypeApiCredential)(int)typeApiCredential);
}
