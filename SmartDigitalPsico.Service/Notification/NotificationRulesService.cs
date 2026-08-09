using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por NotificationRulesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationRulesService
      : SmartDigitalPsico.Service.EntityBaseService<NotificationRule, GetNotificationRulesDto>, INotificationRulesService
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

