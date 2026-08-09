using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Specialty;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por SpecialtyService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class SpecialtyService
        : SmartDigitalPsico.Service.EntityBaseService<Specialty, GetSpecialtyDto>, ISpecialtyService
    {
        /// <summary>
        /// Método SpecialtyService: executa a operação SpecialtyService.
        /// </summary>
        public SpecialtyService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            ISpecialtyRepository entityRepository,
            IValidator<Specialty> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator) { }
    }
}
