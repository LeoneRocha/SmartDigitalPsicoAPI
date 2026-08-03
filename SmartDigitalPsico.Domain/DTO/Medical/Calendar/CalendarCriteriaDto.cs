namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por CalendarCriteriaDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class CalendarCriteriaDto : CalendarCriteriaDtoBase
    {
        public int IntervalInMinutes { get; set; } // Intervalo em minutos (ex: 30 para 30 minutos, 60 para 1 hora)         
        public bool FilterDaysAndTimesWithAppointments { get; set; } // Filtro para dias com compromissos
        public DateTime? FilterByDate { get; set; } // Filtrar por data específica
    } 
}
