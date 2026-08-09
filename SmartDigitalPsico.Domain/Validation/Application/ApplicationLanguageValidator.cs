using FluentValidation;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por ApplicationLanguageValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class ApplicationLanguageValidator : AbstractValidator<ApplicationLanguage>
    {
        /// <summary>
        /// Método ApplicationLanguageValidator: executa a operação ApplicationLanguageValidator.
        /// </summary>
        public ApplicationLanguageValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.ApplicationLanguageValidator.ApplicationLanguage.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ApplicationLanguageValidator.ApplicationLanguage.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.ApplicationLanguageValidator.ApplicationLanguage.Language.NotNull")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ApplicationLanguageValidator.ApplicationLanguage.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.ApplicationLanguageValidator.ApplicationLanguage.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
