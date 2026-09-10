using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

/// <summary>
/// Casca LocationSaveFileConfigurationDto — espelho SCH com enum SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Domains.LocationSaveFileConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com enum SDP ETypeLocationSaveFiles; não herda SCH por tipo de enum.")]
public class LocationSaveFileConfigurationDto : ILocationSaveFileConfigurationDto
{
    public ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
}
