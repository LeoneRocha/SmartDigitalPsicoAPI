using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class OfficeValidator : AbstractValidator<Office>
    {
        public OfficeValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull().NotEmpty()
                .WithMessage("Description_Validator_IsRequired_Key|Description is required.");

            RuleFor(entity => entity.Language)
                .NotNull().NotEmpty()
                .WithMessage("Language_Validator_IsRequired_Key|Language is required.")
                .MaximumLength(10)
                .WithMessage("Language_Validator_MaxLength_Key|Language cannot exceed {0} characters.|10");
        }
    }
}
