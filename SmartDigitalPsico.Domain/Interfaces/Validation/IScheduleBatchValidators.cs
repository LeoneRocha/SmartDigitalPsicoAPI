using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    public interface IScheduleBatchValidators
    {
        IValidator<ScheduleBatch> EntityValidator { get; }
        IValidator<ScheduleItem> ScheduleItemValidator { get; }
        IValidator<ScheduleBatch> ScheduleBatchRangeValidator { get; }
    }
}
