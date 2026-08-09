using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Leaves;

using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por LeavesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class LeavesService
      : SmartDigitalPsico.Service.EntityBaseService<Leaves, GetLeavesDto>, ILeavesService
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
