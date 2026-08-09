using SmartDigitalPsico.Domain.DTO.Audit.Common;
namespace SmartDigitalPsico.Domain.DTO.Audit.ADD
{
    /// <summary>
    /// Classe responsável por AddAuditDataSelectiveEntityLogDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddAuditDataSelectiveEntityLogDto : AuditDataSelectiveEntityLogBaseDto, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
    }
}
