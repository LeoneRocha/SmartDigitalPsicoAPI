using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class NotificationRule : EntityBase, IEntityBaseDomains
    {
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }
        public bool IsEnabled { get; set; }
        public EIntervalNotificationType IntervalType { get; set; }
        public short IntervalValue { get; set; }
        public bool IsBefore { get; set; }
        public ENotificationServiceType[] ENotificationServiceType { get; set; } = [];
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public ENotificationType NotificationType { get; set; }
    } 
}
