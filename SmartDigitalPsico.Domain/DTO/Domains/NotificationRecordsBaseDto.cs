using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.DTO.Domains
{

    public abstract class NotificationRecordsBaseDto : EntityDtoBaseDomain
    {  
        /// <summary>
        /// ID opcional do calendário médico.
        /// </summary>
        public long? MedicalCalendarId { get; set; }

        /// <summary>
        /// Indica a próxima data/hora agendada para envio da notificação, em UTC.
        /// Este campo deve ser calculado de acordo com o fuso horário do apontamento.
        /// Exemplo: se o apontamento está no horário de Brasília (UTC-3) e a notificação deve ser enviada 24 horas antes,
        /// o NextScheduledSendTime deverá ser calculado subtraindo 24h do horário local e convertendo para UTC.
        /// </summary> 
        public DateTime? NextScheduledSendTime { get; set; }

        /// <summary>
        /// Array de regras e seus status para envio da notificação.
        /// </summary>
        public NotificationRuleStatus[] NotificationRules { get; set; } = [];

        /// <summary>
        /// Indica se todos os envios de notificação foram concluídos.
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Data final que marca quando todos os envios foram concluídos (apenas quando IsCompleted for true).
        /// </summary>
        public DateTime? FinalSendDate { get; set; }

        public DateTime EventDate { get; set; }

        public DateTime CreatedDate { get; set; }
         
        public DateTime ModifyDate { get; set; }
    }
}
