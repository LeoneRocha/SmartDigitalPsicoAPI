using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO;

/// <summary>
/// Casca BlobFileDto — herda SCH Domain.DTOs.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.BlobFileDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando BlobFileDto do SCH.")]
public class BlobFileDto : SmartCoreHub.Core.SDK.Domain.DTOs.BlobFileDto
{
}
