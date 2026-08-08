using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por RoleGroupValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class RoleGroupValidator : AbstractValidator<RoleGroup>
    {
        /// <summary>
        /// Método RoleGroupValidator: executa a operação RoleGroupValidator.
        /// </summary>
        public RoleGroupValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.RoleGroupValidator.RoleGroup.Description.NotNull")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.RoleGroupValidator.RoleGroup.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.RoleGroupValidator.RoleGroup.Language.NotNull")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.RoleGroupValidator.RoleGroup.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.RoleGroupValidator.RoleGroup.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
