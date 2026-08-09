namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por CalendarDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class CalendarDto
    {
        public long MedicalId { get; set; }
        public string MedicalName { get; set; } = string.Empty;
        public DayCalendarDto[] Days { get; set; } = [];
    }
}
