namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class GetScheduleItemDto : ScheduleItemBaseDto
    {
        public long Id { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
        public bool IsPast { get; set; } // Indica se o evento já passou
    }
}
