using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleBatchCalendarDtoValidator : AbstractValidator<ScheduleMedicalCalendarCriteriaDto>
    {
        private readonly IScheduleBatchRepository _scheduleBatchRepository;
        private readonly IMedicalRepository _medicalRepository;

        public ScheduleBatchCalendarDtoValidator(
            IScheduleBatchRepository scheduleBatchRepository,
            IMedicalRepository medicalRepository)
        {
            _scheduleBatchRepository = scheduleBatchRepository;
            _medicalRepository = medicalRepository;

            // Validações básicas de campos obrigatórios
            RuleFor(m => m.MedicalId)
                .NotEmpty()
                .WithMessage("ErrorValidator_Required_Field|Medical ID is required.")
                .MustAsync(async (medicalId, cancellation) => {
                    var medical = await _medicalRepository.FindByID(medicalId);
                    return medical != null;
                })
                .WithMessage("Medical_Not_Found|The specified medical was not found.");

            RuleFor(m => m.Title)
                .NotEmpty()
                .WithMessage("ErrorValidator_Required_Field|Title is required.")
                .MaximumLength(100)
                .WithMessage("ErrorValidator_Maximum_Length|Title cannot exceed 100 characters.");

            RuleFor(m => m.StartDateTime)
                .NotEmpty()
                .WithMessage("ErrorValidator_Required_Field|Start date and time is required.");

            RuleFor(m => m.EndDateTime)
                .Must((model, endDate) => !endDate.HasValue || endDate.Value > model.StartDateTime)
                .When(x => x.EndDateTime.HasValue)
                .WithMessage("ErrorValidator_Date_Range|End date must be after start date.");

            RuleFor(m => m.TimeZone)
                .NotEmpty()
                .WithMessage("ErrorValidator_Required_Field|Time zone is required.");

            // Validações específicas para recorrência
            When(m => m.RecurrenceType != ERecurrenceCalendarType.None, () => {
                RuleFor(m => m)
                    .Must(ValidateRecurrenceParameters)
                    .WithMessage("ErrorValidator_Recurrence_Parameters|Invalid recurrence parameters.");
                
                When(m => m.RecurrenceType == ERecurrenceCalendarType.Weekly, () => {
                    RuleFor(m => m.RecurrenceDays)
                        .Must(days => days != null && days.Length > 0)
                        .WithMessage("ErrorValidator_Weekly_Recurrence|At least one day of the week must be selected for weekly recurrence.");
                });
            });

            // Validação para verificar conflitos de data/hora
            RuleFor(m => m)
                .MustAsync(NoDateConflict)
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same doctor.");
        }

        private static bool ValidateRecurrenceParameters(ScheduleMedicalCalendarCriteriaDto model)
        {
            // Verificar se pelo menos um dos parâmetros de recorrência está definido
            if (model.RecurrenceEndDate.HasValue)
            {
                return model.RecurrenceEndDate.Value > model.StartDateTime;
            }
            
            if (model.RecurrenceCount > 0)
            {
                return true;
            }
            
            // Se nenhum parâmetro de recorrência estiver definido, é inválido
            return false;
        }

        private async Task<bool> NoDateConflict(ScheduleMedicalCalendarCriteriaDto model, CancellationToken cancellationToken)
        {
            // Se for uma atualização de série existente, não verificar conflito
            if (!string.IsNullOrEmpty(model.TokenRecurrence))
            {
                return true;
            }

            // Verificar conflitos apenas para o primeiro evento da série
            var startDate = model.StartDateTime;
            var endDate = model.EndDateTime ?? model.StartDateTime.AddHours(1);

            // Buscar eventos existentes no mesmo período
            var existingItems = await _scheduleBatchRepository.GetScheduleItemsAsync(
                model.MedicalId, 
                null, 
                startDate.AddMinutes(-30), 
                endDate.AddMinutes(30));

            // Verificar se há sobreposição
            foreach (var item in existingItems)
            {
                if (item.StartDateTime < endDate && startDate < item.EndDateTime)
                {
                    return false; // Conflito encontrado
                }
            }

            return true; // Nenhum conflito encontrado
        }
    }
}
