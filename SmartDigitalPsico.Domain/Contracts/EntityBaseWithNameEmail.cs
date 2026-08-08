using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.Contracts
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBaseWithNameEmail.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
