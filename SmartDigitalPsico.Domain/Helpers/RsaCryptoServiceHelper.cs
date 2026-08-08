using SmartDigitalPsico.Domain.DTO.Security;
using System.Security.Cryptography;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class RsaCryptoServiceHelper
    {
        public static RsaCryptoDto GenerateKeys(RSAEncryptionPadding rsaSize)
        {
            var core = SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.GenerateKeys(rsaSize);
            return new RsaCryptoDto
            {
                PublicKey = core.PublicKey,
                PrivateKey = core.PrivateKey,
                PublicKeyBase64 = core.PublicKeyBase64,
                PrivateKeyBase64 = core.PrivateKeyBase64
            };
        }

        public static string ConvertToBase64(RSAParameters rsaParameters)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertToBase64(rsaParameters);

        public static RSAParameters ConvertFromBase64(string base64String, RSAEncryptionPadding rsaSize)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper.ConvertFromBase64(base64String, rsaSize);
    }
}
