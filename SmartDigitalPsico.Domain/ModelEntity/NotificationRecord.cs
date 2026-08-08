using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por NotificationRecord.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class NotificationRecord : EntityBase 
    {
        /// <summary>
        /// Opaque schedule token (ScheduleCalendar.UniqueToken as Guid). No FK to schedule tables.
        /// </summary>
        public Guid TokenId { get; set; }

        /// <summary>
        /// Occurrence datetime that was notified (logical key with TokenId).
        /// </summary>
        public DateTime EventDate { get; set; }

        public DateTime? NextScheduledSendTime { get; set; }

        // Armazena as regras e seus status (em JSON no banco)
        public NotificationRuleStatus[] NotificationRules { get; set; } = [];

        // Controle de envio concluído
        public bool IsCompleted { get; set; }

        // Se IsCompleted for true, esta data indica o momento em que todas as notificações foram enviadas.
        public DateTime? FinalSendDate { get; set; }
    }
    /// <summary>
    /// Classe responsável por NotificationRuleStatus.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class NotificationRuleStatus
    {
        public long NotificationRuleId { get; set; }
        public DateTime ScheduledSendTime { get; set; }
        public DateTime? ActualSendTime { get; set; }
        public bool IsSent { get; set; }
        public ENotificationServiceType[] NotificationMethods { get; set; } = [];
    } 
}
