using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    //Registered in AddValidatorsFromAssemblyContaining
    /// <summary>
    /// Classe responsável por LeavesValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class LeavesValidator : AbstractValidator<Leaves>
    {
        /// <summary>
        /// Método LeavesValidator: executa a operação LeavesValidator.
        /// </summary>
        public LeavesValidator()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.StartDate.NotEmpty")
                .WithMessage("Leaves_StartDate_Validator_IsRequired|Start date is required.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired|Description is required.")
                .MaximumLength(255)
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength|Description must be less than {0} characters.|255");

            RuleFor(x => x.Language)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength|Language must be less than {0} characters.|10");

            RuleFor(x => x.EndDate)
                .GreaterThanOrEqualTo(x => x.StartDate)
                .When(x => x.EndDate.HasValue)
                .WithErrorCode("SmartDigitalPsico.LeavesValidator.Leaves.EndDate.GreaterThanOrEqualTo")
                .WithMessage("EndDate_Validator_Invalid|End date must be greater than or equal to start date.");
        }
    }
}
