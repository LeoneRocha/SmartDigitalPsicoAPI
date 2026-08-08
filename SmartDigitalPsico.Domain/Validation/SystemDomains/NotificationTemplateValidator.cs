using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Text.RegularExpressions;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    //Registered in AddValidatorsFromAssemblyContaining
    /// <summary>
    /// Classe responsável por NotificationTemplateValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class NotificationTemplateValidator : AbstractValidator<NotificationTemplate>
    {
        /// <summary>
        /// Método NotificationTemplateValidator: executa a operação NotificationTemplateValidator.
        /// </summary>
        public NotificationTemplateValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Description.NotEmpty")
                .WithMessage("Description_Validator_IsRequired_Key|Template name is required.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Description.MaxLength")
                .WithMessage("Description_Validator_MaxLength_Key|Template name must be less than {0} characters.|100");

            RuleFor(x => x.Subject)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Subject.NotEmpty")
                .WithMessage("Subject_Validator_IsRequired_Key|Subject is required.")
                .MaximumLength(200)
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Subject.MaxLength")
                .WithMessage("Subject_Validator_MaxLength_Key|Subject must be less than {0} characters.|200");

            RuleFor(x => x.Body)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Body.NotEmpty")
                .WithMessage("Body_Validator_IsRequired_Key|Body is required.")
                .MaximumLength(8000)
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Body.MaxLength")
                .WithMessage("Body_Validator_MaxLength_Key|Body must be less than {0} characters.|8000")
                .Must(BeSafeHtml)
                .WithErrorCode("SmartDigitalPsico.NotificationTemplateValidator.NotificationTemplate.Body.Must")
                .WithMessage("Body_Validator_Invalid_Key|Body contains unsafe HTML content.");
        }

        private bool BeSafeHtml(string body)
        {
            var sanitized = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(body);

            // Remover espaços em branco extras
            string removeWhitespace(string input) => Regex.Replace(input, @"\s+", "", RegexOptions.None, TimeSpan.FromMilliseconds(100));

            var originalCleaned = removeWhitespace(body);
            var sanitizedCleaned = removeWhitespace(sanitized);

            var isEqualContent = string.Equals(originalCleaned, sanitizedCleaned, StringComparison.OrdinalIgnoreCase);
            return isEqualContent;
        }
    }
}
