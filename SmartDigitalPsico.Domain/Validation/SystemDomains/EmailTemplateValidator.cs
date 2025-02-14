using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class EmailTemplateValidator : AbstractValidator<EmailTemplate>
    {
        public EmailTemplateValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description_Validator_IsRequired_Key|Template name is required.")
                .MaximumLength(100)
                .WithMessage("Description_Validator_MaxLength_Key|Template name must be less than {0} characters.|100");

            RuleFor(x => x.Subject)
                .NotEmpty()
                .WithMessage("Subject_Validator_IsRequired_Key|Subject is required.")
                .MaximumLength(200)
                .WithMessage("Subject_Validator_MaxLength_Key|Subject must be less than {0} characters.|200");

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage("Body_Validator_IsRequired_Key|Body is required.")
                .MaximumLength(8000)
                .WithMessage("Body_Validator_MaxLength_Key|Body must be less than {0} characters.|8000");
        }
    }
}
