using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.ModelEntity;

using LeavesEntity = SmartDigitalPsico.Domain.ModelEntity.Leaves;

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
