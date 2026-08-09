namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por DayCalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class DayCalendarDto
    {
        public DateTime Date { get; set; }
        public bool IsPast { get; set; }
        public TimeSlotDto[] TimeSlots { get; set; } = [];
    }
}
