using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Core.SDK.Domain.Contracts
{
    /// <summary>
    /// Classe responsável por EntityBaseWithNameEmail.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
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
}
