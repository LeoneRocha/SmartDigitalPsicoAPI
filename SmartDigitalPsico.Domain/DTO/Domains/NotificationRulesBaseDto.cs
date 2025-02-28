using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public abstract class NotificationRulesBaseDto : EntityDtoBaseDomain
    {
        public long MedicalId { get; set; }
        public bool IsEnabled { get; set; }
        public EIntervalNotificationType IntervalType { get; set; }
        public short IntervalValue { get; set; }
        public bool IsBefore { get; set; }
        public ENotificationServiceType[] ENotificationServiceType { get; set; } = [];       
        
    }
}
 
