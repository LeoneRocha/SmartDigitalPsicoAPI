namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class DayScheduleDto
    {
        public DateTime Date { get; set; }
        public TimeSlotDto[] TimeSlots { get; set; } = []; 
    }
}