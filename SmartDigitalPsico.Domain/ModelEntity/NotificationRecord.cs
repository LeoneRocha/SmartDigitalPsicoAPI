using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class NotificationRecord : EntityBase 
    {
        #region Relationship   
        public long? MedicalCalendarId { get; set; }
        public MedicalCalendar? MedicalCalendar { get; set; }
        #endregion Relationship
         
        public DateTime? NextScheduledSendTime { get; set; }

        // Armazena as regras e seus status (em JSON no banco)
        public NotificationRuleStatus[] NotificationRules { get; set; } = [];

        // Controle de envio concluído
        public bool IsCompleted { get; set; }

        // Se IsCompleted for true, esta data indica o momento em que todas as notificações foram enviadas.
        public DateTime? FinalSendDate { get; set; }
        public DateTime EventDate { get; set; }
    }
    public class NotificationRuleStatus
    {
        public long NotificationRuleId { get; set; }
        public DateTime ScheduledSendTime { get; set; }
        public DateTime? ActualSendTime { get; set; }
        public bool IsSent { get; set; }
        public ENotificationServiceType[] NotificationMethods { get; set; } = [];
    } 
}
