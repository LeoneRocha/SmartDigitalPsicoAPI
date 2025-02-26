using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Text.RegularExpressions;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    //Registered in AddValidatorsFromAssemblyContaining
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
                .WithMessage("Body_Validator_MaxLength_Key|Body must be less than {0} characters.|8000")
                .Must(BeSafeHtml)
                .WithMessage("Body_Validator_Invalid_Key|Body contains unsafe HTML content.");
        }

        private bool BeSafeHtml(string body)
        {
            var sanitized = HtmlSanitizerHelper.Sanitize(body);

            // Remover espaços em branco extras
            string removeWhitespace(string input) => Regex.Replace(input, @"\s+", "", RegexOptions.None, TimeSpan.FromMilliseconds(100));

            var originalCleaned = removeWhitespace(body);
            var sanitizedCleaned = removeWhitespace(sanitized);

            var isEqualContent = string.Equals(originalCleaned, sanitizedCleaned, StringComparison.OrdinalIgnoreCase);
            return isEqualContent;
        }
    }
}
