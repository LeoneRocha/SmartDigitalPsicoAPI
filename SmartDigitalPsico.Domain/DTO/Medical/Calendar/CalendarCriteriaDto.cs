namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class CalendarCriteriaDto : CalendarCriteriaDtoBase
    {
        public int IntervalInMinutes { get; set; } // Intervalo em minutos (ex: 30 para 30 minutos, 60 para 1 hora)         
        public bool FilterDaysAndTimesWithAppointments { get; set; } // Filtro para dias com compromissos
        public DateTime? FilterByDate { get; set; } // Filtrar por data específica
    } 
}