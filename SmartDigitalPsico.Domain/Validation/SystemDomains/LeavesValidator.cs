using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    //Registered in AddValidatorsFromAssemblyContaining
    public class LeavesValidator : AbstractValidator<Leaves>
    {
        public LeavesValidator()
        {
            RuleFor(x => x.StartDate)
                .NotEmpty()
                .WithMessage("Leaves_StartDate_Validator_IsRequired|Start date is required.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description_Validator_IsRequired|Description is required.")
                .MaximumLength(255)
                .WithMessage("Description_Validator_MaxLength|Description must be less than {0} characters.|255");

            RuleFor(x => x.Language)
                .NotEmpty()
                .WithMessage("Language_Validator_IsRequired|Language is required.")
                .MaximumLength(10)
                .WithMessage("Language_Validator_MaxLength|Language must be less than {0} characters.|10");

            RuleFor(x => x.EndDate)
                .GreaterThanOrEqualTo(x => x.StartDate)
                .When(x => x.EndDate.HasValue)
                .WithMessage("EndDate_Validator_Invalid|End date must be greater than or equal to start date.");
        }
    }
}
