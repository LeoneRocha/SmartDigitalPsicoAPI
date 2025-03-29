using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchNotificationDto
    {
        public long Id { get; set; }
        public string BatchToken { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public string MedicalName { get; set; } = string.Empty;
        public long? PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public ENotificationType NotificationType { get; set; }
        public GetScheduleItemDto[] UpcomingItems { get; set; } = Array.Empty<GetScheduleItemDto>();
    }
}
