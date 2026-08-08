using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationRulesRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class NotificationRulesRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<NotificationRule>, INotificationRulesRepository
    {
        /// <summary>
        /// Método NotificationRulesRepository: executa a operação NotificationRulesRepository.
        /// </summary>
        public NotificationRulesRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método GetNotificationRulesAsync: consulta e retorna dados.
        /// </summary>
        public async Task<NotificationRule[]> GetNotificationRulesAsync(ENotificationType notificationType, bool isEnabled, long medicalId)
        {
            return await _dataset
                .Where(nr => nr.NotificationType == notificationType
                && nr.IsEnabled == isEnabled
                && nr.MedicalId == medicalId)
                .ToArrayAsync();
        }
    }
}
