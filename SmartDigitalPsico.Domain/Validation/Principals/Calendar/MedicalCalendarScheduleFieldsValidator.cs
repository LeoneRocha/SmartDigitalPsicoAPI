using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Principals.Calendar
{
    /// <summary>
    /// Medical-host field rules for MedicalCalendar validation shape (Include by MedicalCalendarValidator).
    /// Core schedule validation uses ScheduleCalendarItemValidator / ScheduleCalendarWriteRequestValidator.
    /// </summary>
    public class MedicalCalendarScheduleFieldsValidator : AbstractValidator<MedicalCalendar>
    {
        public MedicalCalendarScheduleFieldsValidator()
        {
            RuleFor(e => e.Title)
                .NotEmpty() 
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.Title.NotEmpty")
                .WithMessage("Title_Validator_IsRequired_Key|Title is required.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.Title.MaxLength")
                .WithMessage("Title_Validator_MaxLength_Key|Title cannot exceed {0} characters.|100");

            RuleFor(e => e.StartDateTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.StartDateTime.NotEmpty")
                .WithMessage("StartDateTime_Validator_IsRequired_Key|Start date and time is required.")
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.StartDateTime.LessThan")
                .WithMessage("StartDateTime_Validator_BeforeEnd_Key|Start time must be before end time.");

            RuleFor(e => e.EndDateTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.EndDateTime.NotEmpty")
                .WithMessage("EndDateTime_Validator_IsRequired_Key|End date and time is required.")
                .GreaterThan(e => e.StartDateTime)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.EndDateTime.GreaterThan")
                .WithMessage("EndDateTime_Validator_AfterStart_Key|End date and time must be after start date and time.");

            RuleFor(e => e.Status)
                .IsInEnum()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.Status.IsInEnum")
                .WithMessage("Status_Validator_Invalid_Key|Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.ColorCategoryHexa.MaxLength")
                .WithMessage("ColorCategoryHexa_Validator_MaxLength_Key|Color category cannot exceed {0} characters.|50");

            RuleFor(e => e.TokenRecurrence)
                .MaximumLength(40)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.TokenRecurrence.MaxLength")
                .WithMessage("TokenRecurrence_Validator_MaxLength_Key|Token recurrence cannot exceed {0} characters.|40");

            RuleFor(e => e.TimeZone)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.TimeZone.NotEmpty")
                .WithMessage("TimeZone_Validator_IsRequired_Key|Time zone is required.")
                .MaximumLength(150)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.TimeZone.MaxLength")
                .WithMessage("TimeZone_Validator_MaxLength_Key|Time zone cannot exceed {0} characters.|150");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays)
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.RecurrenceDays.Must")
                .WithMessage("RecurrenceDays_Validator_Invalid_Key|Invalid recurrence days.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.RecurrenceType.IsInEnum")
                .WithMessage("RecurrenceType_Validator_Invalid_Key|Invalid recurrence type.");

            RuleFor(e => e.RecurrenceCount)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.RecurrenceCount.NotEmpty")
                .WithMessage("RecurrenceCount_Validator_IsRequired_Key|Recurrence count is required.")
                .InclusiveBetween((short)0, (short)999)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarScheduleFieldsValidator.MedicalCalendar.RecurrenceCount.InclusiveBetween")
                .WithMessage("RecurrenceCount_Validator_Range_Key|Recurrence count must be between {0} and {1}.|0|999");
        }

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
            => recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(day));
    }
}
