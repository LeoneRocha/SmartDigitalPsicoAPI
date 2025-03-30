using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Principals.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    public interface IScheduleBatchCollectionValidators
    {
        IValidator<ScheduleBatch> EntityValidator { get; }
        IValidator<ScheduleItem> ScheduleItemValidator { get; }
        IValidator<ScheduleBatch> ScheduleBatchRangeValidator { get; }
        IValidator<ScheduleItemValidationContext> ScheduleItemOverlapValidator { get; }
        IValidator<ScheduleMedicalCalendarCriteriaDto> ScheduleBatchCalendarDtoValidator { get; } // Novo validador

    }
}
