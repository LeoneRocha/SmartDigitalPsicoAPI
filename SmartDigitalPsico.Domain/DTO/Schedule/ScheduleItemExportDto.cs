namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    /// <summary>
    /// Classe responsável por ScheduleItemExportDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class ScheduleItemExportDto
    {
        public string Title { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;  
        public string End { get; set; } = string.Empty;  
        public bool AllDay { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string RecurrenceRule { get; set; } = string.Empty;  
    }
}
