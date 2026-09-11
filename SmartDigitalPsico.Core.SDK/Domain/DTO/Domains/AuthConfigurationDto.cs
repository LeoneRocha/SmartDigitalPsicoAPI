using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

/// <summary>
/// Casca AuthConfigurationDto — espelho SCH com enum SDP (Enuns).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Security.AuthConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com enum SDP ETypeApiCredential (namespace Enuns); não herda SCH por tipo de enum.")]
public class AuthConfigurationDto
{
    public bool IsEnable { get; set; }
    public ETypeApiCredential TypeApiCredential { get; set; }
}
