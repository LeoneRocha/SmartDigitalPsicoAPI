using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{

    /// <summary>
    /// Classe responsável por ScheduleItemValidationContext.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class ScheduleItemValidationContext
    {
        public ScheduleItem? NewItem { get; set; }
        public ScheduleItem[] ExistingItems { get; set; } = [];
        public long MedicalId { get; set; }
    }
}
