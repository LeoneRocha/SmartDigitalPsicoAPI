using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class GenderValidator : AbstractValidator<Gender>
    {
        //https://docs.fluentvalidation.net/en/latest/start.html
        public GenderValidator()
        {
            RuleFor(entity => entity.Description)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_Description_Null");

            RuleFor(entity => entity.Language)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_Language_Null") 
                .MaximumLength(10)
                .WithMessage("ErrorValidator_Language_MaximumLength")  
                .WithErrorCode("[{MaxLength}]");  
        }
    }
}
