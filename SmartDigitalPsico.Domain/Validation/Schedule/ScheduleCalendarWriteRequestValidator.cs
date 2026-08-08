using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;

namespace SmartDigitalPsico.Domain.Validation.Schedule
{
    /// <summary>
    /// Generic write-request validator for ScheduleCalendar SoT.
    /// </summary>
    public class ScheduleCalendarWriteRequestValidator : AbstractValidator<ScheduleCalendarWriteRequest>
    {
        /// <summary>
        /// Método ScheduleCalendarWriteRequestValidator: operação de agendamento.
        /// </summary>
        public ScheduleCalendarWriteRequestValidator(IValidator<SmartDigitalPsico.Domain.ModelEntity.Schedule.ScheduleCalendarItem> itemValidator)
        {
            RuleFor(x => x.UniqueToken)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.UniqueToken.NotEmpty")
                .WithMessage("UniqueToken_Validator_IsRequired_Key|Unique token is required.")
                .MaximumLength(40)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.UniqueToken.MaxLength")
                .WithMessage("UniqueToken_Validator_MaxLength_Key|Unique token cannot exceed {0} characters.|40");

            RuleFor(x => x.OwnerKey)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.OwnerKey.NotEmpty")
                .WithMessage("OwnerKey_Validator_IsRequired_Key|Owner key is required.")
                .MaximumLength(128)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.OwnerKey.MaxLength")
                .WithMessage("OwnerKey_Validator_MaxLength_Key|Owner key cannot exceed {0} characters.|128");

            RuleFor(x => x.TenantKey)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.TenantKey.NotEmpty")
                .WithMessage("TenantKey_Validator_IsRequired_Key|Tenant key is required.")
                .MaximumLength(64)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.TenantKey.MaxLength")
                .WithMessage("TenantKey_Validator_MaxLength_Key|Tenant key cannot exceed {0} characters.|64");

            RuleFor(x => x.Items)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarWriteRequestValidator.ScheduleCalendarWriteRequest.Items.NotEmpty")
                .WithMessage("ScheduleData_Validator_NotEmpty_Key|At least one schedule item is required.");

            RuleForEach(x => x.Items)
                .SetValidator(itemValidator);
        }
    }
}
