using FluentValidation;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class ApplicationConfigSettingValidator : AbstractValidator<ApplicationConfigSetting>
    {
        /// <summary>
        /// Método ApplicationConfigSettingValidator: executa a operação ApplicationConfigSettingValidator.
        /// </summary>
        public ApplicationConfigSettingValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.ApplicationConfigSettingValidator.ApplicationConfigSetting.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ApplicationConfigSettingValidator.ApplicationConfigSetting.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.ApplicationConfigSettingValidator.ApplicationConfigSetting.Language.NotNull")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ApplicationConfigSettingValidator.ApplicationConfigSetting.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.ApplicationConfigSettingValidator.ApplicationConfigSetting.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
