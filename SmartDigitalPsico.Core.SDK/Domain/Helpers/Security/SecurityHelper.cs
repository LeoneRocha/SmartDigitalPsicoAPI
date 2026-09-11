using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers.Security;

/// <summary>
/// Helpers de segurança — casca 100% delegada ao SCH (EVO.8).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.Security.SecurityHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "EVO.8: IsBase64String / CreatePasswordHash / VerifyPasswordHash / CreateToken → SCH.")]
public static class SecurityHelper
{
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        => Sch.SecurityHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        => Sch.SecurityHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);

    public static string CreateToken(SmartDigitalPsico.Core.SDK.Domain.Security.SecurityDto secVo)
        => Sch.SecurityHelper.CreateToken(secVo);

    public static bool IsBase64String(string base64)
        => Sch.SecurityHelper.IsBase64String(base64);
}
