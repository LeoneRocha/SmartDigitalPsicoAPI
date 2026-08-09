using SmartDigitalPsico.Domain.DTO.Leaves.GET;

using LeavesEntity = SmartDigitalPsico.Domain.EntityModels.Leaves;

namespace SmartDigitalPsico.Domain.Interfaces.Leaves
{
    /// <summary>
    /// Interface (contrato) responsável por ILeavesService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface ILeavesService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<LeavesEntity, GetLeavesDto>
    {
    }
}
