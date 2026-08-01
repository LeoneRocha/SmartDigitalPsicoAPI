using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    public interface IScheduleBatchCollectionValidators
    {
        IValidator<ScheduleBatch> ScheduleBatchValidator { get; }
        IValidator<ScheduleItem> ScheduleItemValidator { get; }
        IValidator<ScheduleBatch> ScheduleBatchRangeValidator { get; }
        IValidator<ScheduleItemValidationContext> ScheduleItemValidationContextValidator { get; }
        IValidator<ScheduleMedicalCalendarCriteriaDto> ScheduleMedicalCalendarCriteriaDtoValidator { get; } // Novo validador

    }
}
