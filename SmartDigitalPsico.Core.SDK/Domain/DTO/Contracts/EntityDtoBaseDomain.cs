using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts;

/// <summary>
/// Casca EntityDtoBaseDomain — herda EntityDtoBase SDP + campos alinhados ao SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseDomain",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca estrutural; herda EntityDtoBase SDP para preservar cadeia DTO.")]
public abstract class EntityDtoBaseDomain : EntityDtoBase
{
    public string Description { get; set; } = string.Empty;
    public string Language { get; set; } = "en";
}
