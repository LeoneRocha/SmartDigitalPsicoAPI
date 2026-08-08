using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs
{
    /// <summary>
    /// Classe responsável por UpdateAuditDataSelectiveEntityLogDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityDto
    {
        public long Id { get; set; }
    }
}
