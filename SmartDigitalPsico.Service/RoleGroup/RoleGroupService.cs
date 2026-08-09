using FluentValidation;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.RoleGroup;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por RoleGroupService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class RoleGroupService : SmartDigitalPsico.Service.EntityBaseService<RoleGroup, GetRoleGroupDto>, IRoleGroupService

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
