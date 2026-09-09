using System.Security.Cryptography;
using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Security;

/// <summary>
/// Casca DTO RSA — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Security.RsaCryptoDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando RsaCryptoDto em SmartCoreHub.Core.SDK.")]
public class RsaCryptoDto : SmartCoreHub.Core.SDK.Domain.DTOs.Security.RsaCryptoDto
{
}
