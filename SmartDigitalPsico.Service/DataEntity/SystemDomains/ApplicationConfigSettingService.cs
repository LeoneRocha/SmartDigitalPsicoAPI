using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
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
