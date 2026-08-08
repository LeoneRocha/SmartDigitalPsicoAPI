using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por OfficeValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class OfficeValidator : AbstractValidator<Office>
    {
        /// <summary>
        /// Método OfficeValidator: executa a operação OfficeValidator.
        /// </summary>
        public OfficeValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.OfficeValidator.Office.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.OfficeValidator.Office.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.OfficeValidator.Office.Language.NotNull")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.OfficeValidator.Office.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.OfficeValidator.Office.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
