using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class ApplicationConfigSettingService
      : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<ApplicationConfigSetting, GetApplicationConfigSettingDto>, IApplicationConfigSettingService
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
