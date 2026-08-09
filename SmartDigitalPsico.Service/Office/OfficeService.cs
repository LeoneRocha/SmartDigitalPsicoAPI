using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Office;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por OfficeService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class OfficeService : SmartDigitalPsico.Service.EntityBaseService<Office, GetOfficeDto>, IOfficeService

    {
        /// <summary>
        /// Método OfficeService: executa a operação OfficeService.
        /// </summary>
        public OfficeService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IOfficeRepository entityRepository,
            IValidator<Office> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator) { }
    }
}
