using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class SpecialtyValidator : AbstractValidator<Specialty>
    {
        public SpecialtyValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.")
                .MaximumLength(255)
                .WithMessage("Description_Validator_MaxLength_Key|Description cannot exceed {0} characters.|255");

            RuleFor(entity => entity.Language)
                .NotNull()
                .NotEmpty()
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
