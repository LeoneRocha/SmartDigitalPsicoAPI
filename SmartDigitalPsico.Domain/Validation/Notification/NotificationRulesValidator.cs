using FluentValidation;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por NotificationRulesValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class NotificationRulesValidator : AbstractValidator<NotificationRule>
    {
        /// <summary>
        /// Método NotificationRulesValidator: executa a operação NotificationRulesValidator.
        /// </summary>
        public NotificationRulesValidator()
        {
            RuleFor(x => x.MedicalId)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.MedicalId.NotEmpty")
                .WithMessage("NotificationRules_MedicalId_Validator_IsRequired|MedicalId is required.");

            RuleFor(x => x.IsEnabled)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.IsEnabled.NotNull")
                .WithMessage("NotificationRules_IsEnabled_Validator_IsRequired|IsEnabled is required.");

            RuleFor(x => x.IntervalType)
                .IsInEnum()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.IntervalType.IsInEnum")
                .WithMessage("NotificationRules_IntervalType_Validator_IsRequired|IntervalType is required.");

            RuleFor(x => (int)x.IntervalValue)
                .GreaterThan(0)
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.Entity.GreaterThan")
                .WithMessage("NotificationRules_IntervalValue_Validator_IsRequired|IntervalValue must be greater than 0.");

            RuleFor(x => x.IsBefore)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.IsBefore.NotNull")
                .WithMessage("NotificationRules_IsBefore_Validator_IsRequired|IsBefore is required.");

            RuleFor(x => x.ENotificationServiceType)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.ENotificationServiceType.NotEmpty")
                .WithMessage("NotificationRules_ENotificationServiceType_Validator_IsRequired|ENotificationServiceType is required.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.Description.NotEmpty")
                .WithMessage("NotificationRules_Description_Validator_IsRequired|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.Description.MaxLength")
                .WithMessage("NotificationRules_Description_Validator_MaxLength|Description must be less than {0} characters.|255");

            RuleFor(x => x.CreatedDate)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.CreatedDate.NotNull")
                .WithMessage("NotificationRules_CreatedAt_Validator_IsRequired|CreatedDate is required.");

            RuleFor(x => x.ModifyDate)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.NotificationRulesValidator.NotificationRule.ModifyDate.NotNull")
                .WithMessage("NotificationRules_UpdatedAt_Validator_IsRequired|ModifyDate is required.");
        }
    }
}
