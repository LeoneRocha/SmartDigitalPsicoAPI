using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class ApplicationConfigSettingService
      : SmartDigitalPsico.Service.EntityBaseService<ApplicationConfigSetting, GetApplicationConfigSettingDto>, IApplicationConfigSettingService
    {
        /// <summary>
        /// Método ApplicationConfigSettingService: executa a operação ApplicationConfigSettingService.
        /// </summary>
        public ApplicationConfigSettingService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IApplicationConfigSettingRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<ApplicationConfigSetting> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }
    }
}
