using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class GenderValidator : AbstractValidator<Gender>
    {
        public GenderValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull().NotEmpty()
                .WithErrorCode("SmartDigitalPsico.GenderValidator.Gender.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull().NotEmpty()
                .WithErrorCode("SmartDigitalPsico.GenderValidator.Gender.Language.NotEmpty")
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithErrorCode("SmartDigitalPsico.GenderValidator.Gender.Language.MaxLength")
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
