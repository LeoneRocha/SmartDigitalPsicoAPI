using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;

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

            // Verificar se há sobreposição de períodos com outros batches
            foreach (var existingBatch in existingBatches)
            {
                if (existingBatch.Id != batch.Id &&
                    existingBatch.StartPeriod <= batch.EndPeriod &&
                    batch.StartPeriod <= existingBatch.EndPeriod)
                {
                    // Verificar conflitos entre os itens de agendamento
                    foreach (var existingItem in existingBatch.ScheduleData)
                    {
                        foreach (var newItem in batch.ScheduleData)
                        {
                            if (existingItem.StartDateTime < newItem.EndDateTime &&
                                newItem.StartDateTime < existingItem.EndDateTime)
                            {
                                return false; // Conflito encontrado
                            }
                        }
                    }
                }
            }

            return true; // Nenhum conflito encontrado
        }
    }
}
