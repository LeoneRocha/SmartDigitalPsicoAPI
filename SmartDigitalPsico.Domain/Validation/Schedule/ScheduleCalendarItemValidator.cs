using FluentValidation;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Generic validator for ScheduleCalendarItem (no Medical/Patient rules).
    /// </summary>
    public class ScheduleCalendarItemValidator : AbstractValidator<ScheduleCalendarItem>
    {
        /// <summary>
        /// Método ScheduleCalendarItemValidator: operação de agendamento.
        /// </summary>
        public ScheduleCalendarItemValidator()
        {
            RuleFor(e => e.Title)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.Title.NotEmpty")
                .WithMessage("Title_Validator_IsRequired_Key|Title is required.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.Title.MaxLength")
                .WithMessage("Title_Validator_MaxLength_Key|Title cannot exceed {0} characters.|100");

            RuleFor(e => e.StartDateTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.StartDateTime.NotEmpty")
                .WithMessage("StartDateTime_Validator_IsRequired_Key|Start date and time is required.")
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.StartDateTime.LessThan")
                .WithMessage("StartDateTime_Validator_BeforeEnd_Key|Start time must be before end time.");

            RuleFor(e => e.EndDateTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.EndDateTime.NotEmpty")
                .WithMessage("EndDateTime_Validator_IsRequired_Key|End date and time is required.")
                .GreaterThan(e => e.StartDateTime)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.EndDateTime.GreaterThan")
                .WithMessage("EndDateTime_Validator_AfterStart_Key|End date and time must be after start date and time.");

            RuleFor(e => e.Status)
                .IsInEnum()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.Status.IsInEnum")
                .WithMessage("Status_Validator_Invalid_Key|Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.ColorCategoryHexa.MaxLength")
                .WithMessage("ColorCategoryHexa_Validator_MaxLength_Key|Color category cannot exceed {0} characters.|50");

            RuleFor(e => e.TokenRecurrence)
                .MaximumLength(40)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.TokenRecurrence.MaxLength")
                .WithMessage("TokenRecurrence_Validator_MaxLength_Key|Token recurrence cannot exceed {0} characters.|40");

            RuleFor(e => e.TimeZone)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.TimeZone.NotEmpty")
                .WithMessage("TimeZone_Validator_IsRequired_Key|Time zone is required.")
                .MaximumLength(150)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.TimeZone.MaxLength")
                .WithMessage("TimeZone_Validator_MaxLength_Key|Time zone cannot exceed {0} characters.|150");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays)
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.RecurrenceDays.Must")
                .WithMessage("RecurrenceDays_Validator_Invalid_Key|Invalid recurrence days.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.RecurrenceType.IsInEnum")
                .WithMessage("RecurrenceType_Validator_Invalid_Key|Invalid recurrence type.");

            RuleFor(e => e.RecurrenceCount)
                .Cascade(CascadeMode.Stop)
                .InclusiveBetween((short)0, (short)999)
                .When(e => e.RecurrenceCount.HasValue)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.RecurrenceCount.InclusiveBetween")
                .WithMessage("RecurrenceCount_Validator_Range_Key|Recurrence count must be between {0} and {1}.|0|999");

            RuleFor(e => e.Location)
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.Location.MaxLength")
                .WithMessage("Location_Validator_MaxLength_Key|Location cannot exceed {0} characters.|255");

            RuleFor(e => e.Description)
                .MaximumLength(1000)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|1000");

            RuleFor(e => e.ReasonCancellation)
                .MaximumLength(1000)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarItemValidator.ScheduleCalendarItem.ReasonCancellation.MaxLength")
                .WithMessage("ReasonCancellation_Validator_MaxLength_Key|Reason for cancellation cannot exceed {0} characters.|1000");
        }

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
            => recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(day));
    }
}
