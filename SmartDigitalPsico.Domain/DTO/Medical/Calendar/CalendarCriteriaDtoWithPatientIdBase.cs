namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public abstract class CalendarCriteriaDtoWithPatientIdBase : CalendarCriteriaDtoBase
    {
        public long PatientId { get; set; }
    }
}
