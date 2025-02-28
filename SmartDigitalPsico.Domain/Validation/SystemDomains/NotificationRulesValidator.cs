using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class NotificationRulesValidator : AbstractValidator<NotificationRules>
    {
        public NotificationRulesValidator()
        {
            RuleFor(x => x.MedicalId)
                .NotEmpty()
                .WithMessage("NotificationRules_MedicalId_Validator_IsRequired|MedicalId is required.");

            RuleFor(x => x.IsEnabled)
                .NotNull()
                .WithMessage("NotificationRules_IsEnabled_Validator_IsRequired|IsEnabled is required.");

            RuleFor(x => x.IntervalType)
                .IsInEnum()
                .WithMessage("NotificationRules_IntervalType_Validator_IsRequired|IntervalType is required.");

            RuleFor(x => (int)x.IntervalValue)
                .GreaterThan(0)
                .WithMessage("NotificationRules_IntervalValue_Validator_IsRequired|IntervalValue must be greater than 0.");

            RuleFor(x => x.IsBefore)
                .NotNull()
                .WithMessage("NotificationRules_IsBefore_Validator_IsRequired|IsBefore is required.");

            RuleFor(x => x.ENotificationServiceType)
                .NotEmpty()
                .WithMessage("NotificationRules_ENotificationServiceType_Validator_IsRequired|ENotificationServiceType is required.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("NotificationRules_Description_Validator_IsRequired|Description is required.")
                .MaximumLength(255)
                .WithMessage("NotificationRules_Description_Validator_MaxLength|Description must be less than {0} characters.|255");

            RuleFor(x => x.CreatedDate)
                .NotNull()
                .WithMessage("NotificationRules_CreatedAt_Validator_IsRequired|CreatedDate is required.");

            RuleFor(x => x.ModifyDate)
                .NotNull()
                .WithMessage("NotificationRules_UpdatedAt_Validator_IsRequired|ModifyDate is required.");
        }
    }
}
