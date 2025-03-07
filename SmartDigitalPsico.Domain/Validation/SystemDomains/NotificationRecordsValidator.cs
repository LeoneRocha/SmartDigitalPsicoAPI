using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;
namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class NotificationRecordsValidator : AbstractValidator<NotificationRecord>
    {
        public NotificationRecordsValidator()
        { 
            RuleFor(x => x.MedicalCalendarId)
                .GreaterThan(0)
                .When(x => x.MedicalCalendarId.HasValue)
                .WithMessage("NotificationRecords_MedicalCalendarId_Validator_Invalid|If provided, MedicalCalendarId must be greater than 0.");

            // Valida cada item do array de NotificationRules.
            RuleForEach(x => x.NotificationRules).SetValidator(new NotificationRuleStatusValidator());

            RuleFor(x => x.CreatedDate)
                .NotEmpty()
                .WithMessage("NotificationRecords_CreatedAt_Validator_IsRequired|CreatedDate is required.");

            RuleFor(x => x.ModifyDate)
                .NotEmpty()
                .WithMessage("NotificationRecords_UpdatedAt_Validator_IsRequired|ModifyDate is required.");

            // Validação para controle de conclusão:
            When(x => x.IsCompleted, () =>
            {
                RuleFor(x => x.FinalSendDate)
                    .NotNull()
                    .WithMessage("NotificationRecords_FinalSendDate_Validator_IsRequired|FinalSendDate is required when notifications are completed.");

                RuleFor(x => x.FinalSendDate)
                    .GreaterThanOrEqualTo(x => x.CreatedDate)
                    .WithMessage("NotificationRecords_FinalSendDate_Validator_Invalid|FinalSendDate must be equal to or later than CreatedDate.");
            });
        }
    } 
    public class NotificationRuleStatusValidator : AbstractValidator<NotificationRuleStatus>
    {
        public NotificationRuleStatusValidator()
        {
            RuleFor(x => x.NotificationRuleId)
                .GreaterThan(0)
                .WithMessage("NotificationRuleStatus_NotificationRuleId_Validator_IsRequired|NotificationRuleId must be greater than 0.");

            RuleFor(x => x.ScheduledSendTime)
                .NotEmpty()
                .WithMessage("NotificationRuleStatus_ScheduledSendTime_Validator_IsRequired|ScheduledSendTime is required.");

            RuleFor(x => x.IsSent)
                .NotNull()
                .WithMessage("NotificationRuleStatus_IsSent_Validator_IsRequired|IsSent is required.");

            RuleFor(x => x.NotificationMethods)
                .NotEmpty()
                .WithMessage("NotificationRuleStatus_NotificationMethods_Validator_IsRequired|NotificationMethods are required.");
        }
    }

}
