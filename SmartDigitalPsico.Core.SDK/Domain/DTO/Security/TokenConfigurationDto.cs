using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using Sch = SmartCoreHub.Core.SDK.Domain.DTOs.Entities;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Security;

/// <summary>
/// Casca TokenConfigurationDto — herda SCH e implementa contrato SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Entities.TokenConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando TokenConfigurationDto do SCH.")]
public class TokenConfigurationDto : Sch.TokenConfigurationDto, ITokenConfigurationDto
{
}
