using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;

/// <summary>
/// Casca DataBaseConfigurationDto — espelho SCH com enum SDP (Enuns).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Domains.DataBaseConfigurationDto",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca com enum SDP ETypeDataBase (namespace Enuns); não herda SCH por tipo de enum.")]
public class DataBaseConfigurationDto
{
    public ETypeDataBase TypeDataBase { get; set; }
}
