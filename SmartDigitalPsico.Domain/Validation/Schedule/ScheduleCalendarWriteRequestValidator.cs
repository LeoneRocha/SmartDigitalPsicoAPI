using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Schedule
{
    /// <summary>
    /// Generic write-request validator for ScheduleCalendar SoT.
    /// </summary>
    public class ScheduleCalendarWriteRequestValidator : AbstractValidator<ScheduleCalendarWriteRequest>
    {
        public ScheduleCalendarWriteRequestValidator(IValidator<SmartDigitalPsico.Domain.ModelEntity.Schedule.ScheduleCalendarItem> itemValidator)
        {
            RuleFor(x => x.UniqueToken)
                .NotEmpty()
                .MaximumLength(40);

            RuleFor(x => x.OwnerKey)
                .NotEmpty()
                .MaximumLength(128);

            RuleFor(x => x.TenantKey)
                .MaximumLength(64);

            RuleFor(x => x.Items)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.Items.NotEmpty")
                .WithMessage("ScheduleData_Validator_NotEmpty_Key|At least one schedule item is required.");

            RuleForEach(x => x.Items)
                .SetValidator(itemValidator);
        }
    }
}
