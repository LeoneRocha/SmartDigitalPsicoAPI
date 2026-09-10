using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces;

/// <summary>
/// Casca ILocationSaveFileConfigurationDto — espelho SCH com enum SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.ILocationSaveFileConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com enum SDP; não herda SCH interface por tipo de enum.")]
public interface ILocationSaveFileConfigurationDto
{
    ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
}
