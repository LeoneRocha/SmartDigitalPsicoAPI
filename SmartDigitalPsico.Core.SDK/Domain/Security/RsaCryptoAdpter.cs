using System.Security.Cryptography;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Casca RSA (typo Adpter preservado) — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Security.Cryptography.RsaCryptoAdpter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando RsaCryptoAdpter em SmartCoreHub.Core.SDK.")]
public class RsaCryptoAdpter : SmartCoreHub.Core.SDK.Domain.Security.Cryptography.RsaCryptoAdpter, ICryptoAdpter
{
    public RsaCryptoAdpter(RSAParameters publicKey, RSAParameters privateKey) : base(publicKey, privateKey)
    {
    }

    public RsaCryptoAdpter(string publicKeyBase64, string privateKeyBase64) : base(publicKeyBase64, privateKeyBase64)
    {
    }
}
