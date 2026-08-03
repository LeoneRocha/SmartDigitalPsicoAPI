using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains.AddDTOs
{
    /// <summary>
    /// Classe responsável por AddAuditDataSelectiveEntityLogDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto , IEntityDtoAdd
    {  
    }
}
