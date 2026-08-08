using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por RoleGroupService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class RoleGroupService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<RoleGroup, GetRoleGroupDto>, IRoleGroupService

    {
        /// <summary>
        /// Método RoleGroupService: executa a operação RoleGroupService.
        /// </summary>
        public RoleGroupService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IRoleGroupRepository entityRepository,
            IValidator<RoleGroup> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator) { }
    }
}
