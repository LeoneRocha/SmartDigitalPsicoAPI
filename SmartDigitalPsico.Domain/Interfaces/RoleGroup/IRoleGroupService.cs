using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;

using RoleGroupEntity = SmartDigitalPsico.Domain.EntityModels.RoleGroup;

namespace SmartDigitalPsico.Domain.Interfaces.RoleGroup
{
    /// <summary>
    /// Interface (contrato) responsável por IRoleGroupService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IRoleGroupService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<RoleGroupEntity, GetRoleGroupDto>
    {

    }
}
