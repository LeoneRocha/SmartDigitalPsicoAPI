using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class ScheduleCriteriaDto : CalendarCriteriaDtoWithPatientIdBase
    {
        public DateTime AppointmentDateTime { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public EScheduleCalendarType ScheduleType { get; set; }
    }
}
