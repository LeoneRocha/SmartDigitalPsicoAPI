using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por SpecialtyValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class SpecialtyValidator : AbstractValidator<Specialty>
    {
        /// <summary>
        /// Método SpecialtyValidator: executa a operação SpecialtyValidator.
        /// </summary>
        public SpecialtyValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Language)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Language.NotNull")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.SpecialtyValidator.Specialty.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
