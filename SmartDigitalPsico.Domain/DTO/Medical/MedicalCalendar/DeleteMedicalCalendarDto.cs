namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class DeleteMedicalCalendarDto
    {
        public long Id { get; set; }
        public bool DeleteSeries { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public long PatientId { get; set; }
    }
}
