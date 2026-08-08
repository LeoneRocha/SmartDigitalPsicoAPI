using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por LeavesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class LeavesService
      : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<Leaves, GetLeavesDto>, ILeavesService
    {
        /// <summary>
        /// Método LeavesService: executa a operação LeavesService.
        /// </summary>
        public LeavesService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            ILeavesRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<Leaves> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        { 
        }  
    }
}
