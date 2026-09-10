using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts;

/// <summary>
/// Casca EntityDtoBaseName — herda EntityDtoBase SDP + Name/Email alinhados ao SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.DTOs.Contracts.EntityDtoBaseName",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca estrutural; herda EntityDtoBase SDP para preservar cadeia DTO.")]
public abstract class EntityDtoBaseName : EntityDtoBase
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
