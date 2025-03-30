using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleMedicalCalendarCriteriaDto : ActionMedicalCalendarDtoBase, IEntityDtoAdd
    {
        public bool IsUpdate { get; set; } 
    }
}
