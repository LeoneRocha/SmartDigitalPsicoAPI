using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.DTOs.Entities;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;

/// <summary>
/// Casca ITokenConfigurationDto — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Entities.ITokenConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando ITokenConfigurationDto do SCH.")]
public interface ITokenConfigurationDto : Sch.ITokenConfigurationDto
{
}
