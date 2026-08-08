using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationRulesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationRulesService
      : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<NotificationRule, GetNotificationRulesDto>, INotificationRulesService
    {
        /// <summary>
        /// Método NotificationRulesService: executa a operação NotificationRulesService.
        /// </summary>
        public NotificationRulesService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            INotificationRulesRepository entityRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IValidator<NotificationRule> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        { 
        } 
        /// <summary>
        /// Método GetNotificationRulesAsync: consulta e retorna dados.
        /// </summary>
        public async Task<NotificationRule[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId)
        { 
            return await ((INotificationRulesRepository)_entityRepository).GetNotificationRulesAsync(notificationType, isEnabled, medicalId);
        }
    }
}

