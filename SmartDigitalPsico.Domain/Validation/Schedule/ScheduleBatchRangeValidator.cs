using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleBatchRangeValidator : AbstractValidator<ScheduleBatch>
    {
        private readonly IScheduleBatchRepository _entityRepository;

        public ScheduleBatchRangeValidator(IScheduleBatchRepository entityRepository)
        {
            _entityRepository = entityRepository;

            RuleFor(m => m)
                .MustAsync(NoDateConflict)
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same doctor.");
        }

        private async Task<bool> NoDateConflict(ScheduleBatch batch, CancellationToken cancellationToken)
        {
            return await ValidConflict(batch, _entityRepository);
        }

        public static async Task<bool> ValidConflict(ScheduleBatch batch, IScheduleBatchRepository _entityRepository)
        {
            var existingBatches = await _entityRepository.GetByMedicalAsync(
                batch.MedicalId, batch.StartPeriod, batch.EndPeriod);

            foreach (var existingBatch in existingBatches)
            {
                if (HasPeriodConflict(batch, existingBatch) && HasScheduleItemConflict(batch, existingBatch))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HasPeriodConflict(ScheduleBatch batch, ScheduleBatch existingBatch)
        {
            return existingBatch.Id != batch.Id &&
                   existingBatch.StartPeriod <= batch.EndPeriod &&
                   batch.StartPeriod <= existingBatch.EndPeriod;
        }

        private static bool HasScheduleItemConflict(ScheduleBatch batch, ScheduleBatch existingBatch)
        {
            return existingBatch.ScheduleData
                .Any(existingItem => batch.ScheduleData.Any(newItem => HasItemOverlap(existingItem, newItem)));

        }

        private static bool HasItemOverlap(ScheduleItem existingItem, ScheduleItem newItem)
        {
            return existingItem.StartDateTime < newItem.EndDateTime && newItem.StartDateTime < existingItem.EndDateTime;
        }
    }
}
