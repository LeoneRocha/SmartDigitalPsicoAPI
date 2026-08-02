using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;
namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class NotificationRecordsValidator : AbstractValidator<NotificationRecord>
    {
        public NotificationRecordsValidator()
        { 
            RuleFor(x => x.TokenId)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.TokenId.NotEmpty")
                .WithMessage("NotificationRecords_TokenId_Validator_Invalid|TokenId is required.");

            RuleFor(x => x.EventDate)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.EventDate.NotEmpty")
                .WithMessage("NotificationRecords_EventDate_Validator_IsRequired|EventDate is required.");

            // Valida cada item do array de NotificationRules.
            RuleForEach(x => x.NotificationRules).SetValidator(new NotificationRuleStatusValidator());

            RuleFor(x => x.CreatedDate)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.CreatedDate.NotEmpty")
                .WithMessage("NotificationRecords_CreatedAt_Validator_IsRequired|CreatedDate is required.");

            RuleFor(x => x.ModifyDate)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.ModifyDate.NotEmpty")
                .WithMessage("NotificationRecords_UpdatedAt_Validator_IsRequired|ModifyDate is required.");

            // Validação para controle de conclusão:
            When(x => x.IsCompleted, () =>
            {
                RuleFor(x => x.FinalSendDate)
                    .NotNull()
                    .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.FinalSendDate.NotNull")
                    .WithMessage("NotificationRecords_FinalSendDate_Validator_IsRequired|FinalSendDate is required when notifications are completed.");

                RuleFor(x => x.FinalSendDate)
                    .GreaterThanOrEqualTo(x => x.CreatedDate)
                    .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.FinalSendDate.GreaterThanOrEqualTo")
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
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.NotificationRuleId.GreaterThan")
                .WithMessage("NotificationRuleStatus_NotificationRuleId_Validator_IsRequired|NotificationRuleId must be greater than 0.");

            RuleFor(x => x.ScheduledSendTime)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.ScheduledSendTime.NotEmpty")
                .WithMessage("NotificationRuleStatus_ScheduledSendTime_Validator_IsRequired|ScheduledSendTime is required.");

            RuleFor(x => x.IsSent)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.IsSent.NotNull")
                .WithMessage("NotificationRuleStatus_IsSent_Validator_IsRequired|IsSent is required.");

            RuleFor(x => x.NotificationMethods)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRecordsValidator.NotificationRecord.NotificationMethods.NotEmpty")
                .WithMessage("NotificationRuleStatus_NotificationMethods_Validator_IsRequired|NotificationMethods are required.");
        }
    }

}
