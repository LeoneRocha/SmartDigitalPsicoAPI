using System.Security.Cryptography;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Core.SDK.Domain.Security;

/// <summary>
/// Casca AES (typo Adpter preservado) — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Security.Cryptography.AesCryptoAdpter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando AesCryptoAdpter em SmartCoreHub.Core.SDK.")]
public class AesCryptoAdpter : SmartCoreHub.Core.SDK.Domain.Security.Cryptography.AesCryptoAdpter, ICryptoAdpter
{
    public AesCryptoAdpter(byte[] key, byte[] iv) : base(key, iv)
    {
    }

    public AesCryptoAdpter(string base64Key, string base64IV) : base(base64Key, base64IV)
    {
    }
}
