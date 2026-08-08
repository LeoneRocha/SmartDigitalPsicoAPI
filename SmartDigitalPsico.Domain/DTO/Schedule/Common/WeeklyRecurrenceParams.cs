using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Classe responsável por WeeklyRecurrenceParams.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class WeeklyRecurrenceParams
    {
        public required ScheduleItem Template { get; set; }
        public List<ScheduleItem> Items { get; set; } = new List<ScheduleItem>();
        public DateTime? EndDate { get; set; }
        public short? Count { get; set; }
        public DayOfWeek[] Days { get; set; } = [];
    }
    /// <summary>
    /// Classe responsável por RecurrenceContext.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class RecurrenceContext
    {
        public DateTime CurrentDate { get; set; }
        public int ItemCount { get; set; }
        public TimeSpan Duration { get; set; }
    }

}
