using SmartDigitalPsico.Domain.Security;

namespace SmartDigitalPsico.Domain.Helpers.Security
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class SecurityHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.VerifyPasswordHash(password, passwordHash, passwordSalt);

        public static string CreateToken(SecurityDto secVo)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.CreateToken(secVo);

        public static bool IsBase64String(string base64)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.Security.SecurityHelper.IsBase64String(base64);
    }
}
