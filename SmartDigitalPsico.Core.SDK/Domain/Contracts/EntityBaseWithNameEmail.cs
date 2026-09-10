using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Contracts;

/// <summary>
/// Casca EntityBaseWithNameEmail — herda <see cref="EntityBase"/> SDP (constraint repos)
/// e espelha propriedades Name/Email do SCH (não herda SCH EntityBaseWithNameEmail
/// para preservar <c>T : EntityBase</c> nos repositórios genéricos).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Contracts.EntityBaseWithNameEmail",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca estrutural; herda EntityBase SDP + propriedades Name/Email alinhadas ao SCH.")]
public abstract class EntityBaseWithNameEmail : EntityBase
{
    [Column("Name", TypeName = "varchar(255)", Order = 2)]
    [MaxLength(255)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [Column("Email", TypeName = "varchar(100)", Order = 3)]
    [MaxLength(100)]
    [Required]
    public string Email { get; set; } = string.Empty;
}
