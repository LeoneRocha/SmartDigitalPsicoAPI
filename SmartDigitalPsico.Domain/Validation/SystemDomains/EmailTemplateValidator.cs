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
            .WithMessage("Template name is required.")
            .MaximumLength(100)
            .WithMessage("Template name must be less than 100 characters.");

            RuleFor(x => x.Subject)
                .NotEmpty()
                .WithMessage("Subject is required.")
                .MaximumLength(200)
                .WithMessage("Subject must be less than 200 characters.");

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithMessage("Body is required.")
                .MaximumLength(8000)
                .WithMessage("Body must be less than 8000 characters.");
        }
    }
}
