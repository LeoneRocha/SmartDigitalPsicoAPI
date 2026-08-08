using SmartDigitalPsico.Service.Common;
using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Gender.GET;
using SmartDigitalPsico.Domain.DTO.Office.GET;
using SmartDigitalPsico.Domain.DTO.RoleGroup.GET;
using SmartDigitalPsico.Domain.DTO.Leaves.GET;
using SmartDigitalPsico.Domain.DTO.Specialty.GET;
using SmartDigitalPsico.Domain.DTO.Notification.GET;
using SmartDigitalPsico.Domain.DTO.Application.GET;
using SmartDigitalPsico.Domain.DTO.Audit.GET;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Notification
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
                                        /// <summary>
    /// Classe responsável por NotificationRulesService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class NotificationRulesService
      : SmartDigitalPsico.Service.Common.EntityBaseService<NotificationRule, GetNotificationRulesDto>, INotificationRulesService
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

