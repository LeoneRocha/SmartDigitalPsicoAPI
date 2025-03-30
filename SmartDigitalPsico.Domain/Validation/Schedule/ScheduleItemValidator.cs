using FluentValidation;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Schedule
{
    public class ScheduleItemValidator : AbstractValidator<ScheduleItem>
    {
        private readonly IMedicalRepository? _medicalRepository;

        public ScheduleItemValidator(IMedicalRepository medicalRepository)
        {
            _medicalRepository = medicalRepository;

            #region Columns
            RuleFor(e => e.Title)
                .NotEmpty()
                .WithMessage("Title_Validator_IsRequired_Key|Title is required.")
                .MaximumLength(100)
                .WithMessage("Title_Validator_MaxLength_Key|Title cannot exceed {0} characters.|100");

            RuleFor(e => e.StartDateTime)
                .NotEmpty()
                .WithMessage("StartDateTime_Validator_IsRequired_Key|Start date and time is required.")
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithMessage("StartDateTime_Validator_BeforeEnd_Key|Start time must be before end time.");

            RuleFor(e => e.EndDateTime)
                .NotEmpty()
                .WithMessage("EndDateTime_Validator_IsRequired_Key|End date and time is required.")
                .GreaterThan(e => e.StartDateTime)
                .WithMessage("EndDateTime_Validator_AfterStart_Key|End date and time must be after start date and time.");

            RuleFor(e => e.Status)
                .Must(status => Enum.IsDefined(typeof(EStatusCalendar), status))
                .WithMessage("Status_Validator_Invalid_Key|Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50)
                .WithMessage("ColorCategoryHexa_Validator_MaxLength_Key|Color category cannot exceed {0} characters.|50");

            RuleFor(e => e.TokenRecurrence)
                .MaximumLength(40)
                .WithMessage("TokenRecurrence_Validator_MaxLength_Key|Token recurrence cannot exceed {0} characters.|40");

            RuleFor(e => e.TimeZone)
                .NotEmpty()
                .WithMessage("TimeZone_Validator_IsRequired_Key|Time zone is required.")
                .MaximumLength(150)
                .WithMessage("TimeZone_Validator_MaxLength_Key|Time zone cannot exceed {0} characters.|150");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays)
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithMessage("RecurrenceDays_Validator_Invalid_Key|Invalid recurrence days.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum()
                .WithMessage("RecurrenceType_Validator_Invalid_Key|Invalid recurrence type.");

            // Validação para RecurrenceCount
            RuleFor(e => e.RecurrenceCount)
                .Cascade(CascadeMode.Stop)
                .InclusiveBetween((short)0, (short)999)
                .When(e => e.RecurrenceCount.HasValue)
                .WithMessage("RecurrenceCount_Validator_Range_Key|Recurrence count must be between {0} and {1}.|0|999");

            RuleFor(e => e.Location)
                .MaximumLength(255)
                .WithMessage("Location_Validator_MaxLength_Key|Location cannot exceed {0} characters.|255");

            RuleFor(e => e.Description)
                .MaximumLength(1000)
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|1000");

            RuleFor(e => e.ReasonCancellation)
                .MaximumLength(1000)
                .WithMessage("ReasonCancellation_Validator_MaxLength_Key|Reason for cancellation cannot exceed {0} characters.|1000");
            #endregion Columns

            // Adicionar validação de horário de trabalho apenas se o repositório médico estiver disponível
            if (_medicalRepository != null)
            {
                RuleFor(e => e)
                    .MustAsync(async (item, cancellationToken) => await BeInWorkingDays(item))
                    .WithMessage("ScheduleItem_Validator_WorkingDay_Key|The schedule item must be on a working day for the doctor.")
                    .MustAsync(async (item, cancellationToken) => await BeInWorkingHours(item))
                    .WithMessage("ScheduleItem_Validator_WorkingHours_Key|The schedule item must be within the doctor's working hours.");
            }
        }

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
        {
            return recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(typeof(DayOfWeek), day));
        }

        private async Task<bool> BeInWorkingDays(ScheduleItem item)
        {
            // Se não temos informações do médico, não podemos validar
            if (_medicalRepository == null || item.MedicalId <= 0)
                return true;

            var medical = await _medicalRepository.FindByID(item.MedicalId);
            if (medical == null)
                return false;

            return medical.WorkingDays.Contains(item.StartDateTime.DayOfWeek);
        }

        private async Task<bool> BeInWorkingHours(ScheduleItem item)
        {
            // Se não temos informações do médico, não podemos validar
            if (_medicalRepository == null || item.MedicalId <= 0)
                return true;

            var medical = await _medicalRepository.FindByID(item.MedicalId);
            if (medical == null)
                return false;

            var startTimeOfDay = item.StartDateTime.TimeOfDay;
            var endTimeOfDay = item.EndDateTime.GetValueOrDefault().TimeOfDay;

            return startTimeOfDay >= medical.StartWorkingTime &&
                   endTimeOfDay <= medical.EndWorkingTime;
        }
    }
}
