using SmartDigitalPsico.Domain.DTO.Leaves.Common;
namespace SmartDigitalPsico.Domain.DTO.Leaves.ADD
{
    /// <summary>
    /// Classe responsável por AddLeavesDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddLeavesDto : LeavesBaseDto, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDtoAdd
    {
    }
}
