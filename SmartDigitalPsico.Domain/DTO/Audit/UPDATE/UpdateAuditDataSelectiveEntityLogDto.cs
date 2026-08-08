using SmartDigitalPsico.Domain.DTO.Audit.Common;
namespace SmartDigitalPsico.Domain.DTO.Audit.UPDATE
{
    /// <summary>
    /// Classe responsável por UpdateAuditDataSelectiveEntityLogDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto
    {
        public long Id { get; set; }
    }
}
