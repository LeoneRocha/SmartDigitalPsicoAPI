using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleBatchValidator : MedicalBaseValidator<ScheduleBatch>
    {
        private readonly IScheduleBatchRepository _repository;
        private readonly ScheduleItemValidator _scheduleItemValidator;

        public ScheduleBatchValidator(
            IConfiguration configuration,
            IScheduleBatchRepository entityRepository,
            IMedicalRepository medicalRepository,
            IUserRepository userRepository)
            : base(medicalRepository, entityRepository, userRepository)
        {
            _repository = entityRepository;
            _scheduleItemValidator = new ScheduleItemValidator(medicalRepository);

            #region Columns
            RuleFor(e => e.BatchToken)
                .NotEmpty()
                .WithMessage("BatchToken_Validator_IsRequired_Key|Batch token is required.")
                .MaximumLength(40)
                .WithMessage("BatchToken_Validator_MaxLength_Key|Batch token cannot exceed {0} characters.|40");

            RuleFor(e => e.StartPeriod)
                .NotEmpty()
                .WithMessage("StartPeriod_Validator_IsRequired_Key|Start period is required.")
                .LessThan(e => e.EndPeriod)
                .WithMessage("StartPeriod_Validator_BeforeEnd_Key|Start period must be before end period.");

            RuleFor(e => e.EndPeriod)
                .NotEmpty()
                .WithMessage("EndPeriod_Validator_IsRequired_Key|End period is required.")
                .GreaterThan(e => e.StartPeriod)
                .WithMessage("EndPeriod_Validator_AfterStart_Key|End period must be after start period.");

            RuleFor(e => e.ScheduleData)
                .NotNull()
                .WithMessage("ScheduleData_Validator_NotNull_Key|Schedule data cannot be null.")
                .Must(data => data.Length > 0)
                .WithMessage("ScheduleData_Validator_NotEmpty_Key|Schedule data cannot be empty.")
                .Must(HaveValidScheduleItems)
                .WithMessage("ScheduleData_Validator_InvalidItems_Key|One or more schedule items are invalid.");
            #endregion Columns

            #region Relationship
            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithMessage("ErrorValidator_PatientId_Null|Patient is required.");

            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithMessage("ErrorValidator_MedicalId_Null|Doctor is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithMessage("ErrorValidator_MedicalId_NotFound|Doctor not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithMessage("ErrorValidator_Medical_Changed|Doctor has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithMessage("ErrorValidator_MedicalCreated_Invalid|Doctor creation is invalid.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithMessage("ErrorValidator_MedicalModify_Invalid|Doctor modification is invalid.");
            #endregion Relationship

            RuleFor(x => x)
                .MustAsync(NoScheduleConflict)
                .WithMessage("ScheduleConflict_Validator_Key|There is a scheduling conflict for the specified time.");
        }

        private bool HaveValidScheduleItems(ScheduleItem[] scheduleItems)
        {
            if (scheduleItems == null || scheduleItems.Length == 0)
                return false;

            foreach (var item in scheduleItems)
            {
                var validationResult = _scheduleItemValidator.Validate(item);
                if (!validationResult.IsValid)
                    return false;
            }

            return true;
        }

        private async Task<bool> NoScheduleConflict(ScheduleBatch batch, CancellationToken cancellationToken)
        {
            // Verificar se há conflitos entre os itens do próprio batch
            var items = batch.ScheduleData;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i].StartDateTime < items[j].EndDateTime &&
                        items[j].StartDateTime < items[i].EndDateTime)
                    {
                        return false; // Conflito encontrado
                    }
                }
            }

            // Verificar se há conflitos com outros batches
            var existingBatches = await _repository.GetByMedicalAsync(
                batch.MedicalId, batch.StartPeriod, batch.EndPeriod);

            foreach (var existingBatch in existingBatches)
            {
                if (existingBatch.Id == batch.Id)
                    continue; // Ignorar o próprio batch

                // Verificar se há sobreposição de períodos
                if (existingBatch.StartPeriod <= batch.EndPeriod &&
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
