namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class UpdateMedicalCalendarDto : ActionMedicalCalendarDtoBase
    {
        public bool UpdateSeries { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
    } 
}