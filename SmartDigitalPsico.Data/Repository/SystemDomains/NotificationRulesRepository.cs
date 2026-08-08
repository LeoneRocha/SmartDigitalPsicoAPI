using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por NotificationRulesRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class NotificationRulesRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<NotificationRule>, INotificationRulesRepository
    {
        /// <summary>
        /// Método NotificationRulesRepository: executa a operação NotificationRulesRepository.
        /// </summary>
        public NotificationRulesRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

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
