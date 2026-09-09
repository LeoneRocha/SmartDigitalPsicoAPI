using System.Security.Cryptography;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca RSA helpers — delega SCH; mapeia <see cref="RsaCryptoDto"/> SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.RsaCryptoServiceHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para RsaCryptoServiceHelper em SmartCoreHub.Core.SDK.")]
public static class RsaCryptoServiceHelper
{
    public static RsaCryptoDto GenerateKeys(RSAEncryptionPadding rsaSize)
    {
        var sch = Sch.RsaCryptoServiceHelper.GenerateKeys(rsaSize);
        return new RsaCryptoDto
        {
            PublicKey = sch.PublicKey,
            PrivateKey = sch.PrivateKey,
            PublicKeyBase64 = sch.PublicKeyBase64,
            PrivateKeyBase64 = sch.PrivateKeyBase64,
        };
    }

    public static string ConvertToBase64(RSAParameters rsaParameters)
        => Sch.RsaCryptoServiceHelper.ConvertToBase64(rsaParameters);

    public static RSAParameters ConvertFromBase64(string base64Key, RSAEncryptionPadding padding)
        => Sch.RsaCryptoServiceHelper.ConvertFromBase64(base64Key, padding);
}
