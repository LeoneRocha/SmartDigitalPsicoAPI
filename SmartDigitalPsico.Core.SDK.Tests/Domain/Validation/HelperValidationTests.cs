using FluentValidation.Results;
using SmartDigitalPsico.Core.SDK.Domain.Validation;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Tests.Domain.Validation;

[TestFixture]
public class HelperValidationTests
{
    [Test]
    public void GetErrorsMap_ErrorFormats_ReturnsMappedResponses()
    {
        var validation = new ValidationResult(
        [
            new ValidationFailure("Name", "Legacy_Key|Legacy message") { ErrorCode = "legacy" },
            new ValidationFailure("Code", "Plain message") { ErrorCode = "plain" },
            new ValidationFailure("Structured", "Structured_Key|Structured message")
            {
                ErrorCode = ValidationErrorCodes.For("Validator", "Model", "Field")
            },
            new ValidationFailure("Single", "OnlyPipePart_WithUnderscore") { ErrorCode = "legacy" }
        ]);

        var errors = HelperValidation.GetErrorsMap(validation);
        var translated = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "Token_Key|Translated message",
            ErrorCode = "legacy"
        });
        var structured = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "OnlyPipe_WithUnderscore",
            ErrorCode = ValidationErrorCodes.For("Validator", "Model", "Field")
        });
        var tokenized = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "Key_Name|Hello {0}|World",
            ErrorCode = "legacy"
        });

        using (Assert.EnterMultipleScope())
        {
            HelperValidation.GetErrorsMap(null).Should().BeEmpty();
            HelperValidation.GetErrorsMap(new ValidationResult()).Should().BeEmpty();
            errors.Should().HaveCount(4);
            errors[0].ErrorCode.Should().Be("Legacy_Key");
            errors[0].DefaultMessage.Should().Be("Legacy message");
            errors[1].ErrorCode.Should().Be("Plain_message");
            errors[2].ErrorCode.Should().Be(ValidationErrorCodes.For("Validator", "Model", "Field"));
            errors[3].DefaultMessage.Should().Be("OnlyPipePart_WithUnderscore");
            translated.ErrorCode.Should().Be("Token_Key");
            translated.Message.Should().Be("Translated message");
            structured.Message.Should().BeEmpty();
            tokenized.Message.Should().Be("Hello World");
            HelperValidation.TranslateErroCode("Maximum [MaxLength]", "[12,]").Should().Be("Maximum 12");
            HelperValidation.TranslateErroCode("unchanged", string.Empty).Should().Be("unchanged");
            ValidationErrorCodes.For("Validator", "Model", "Field", "Rule")
                .Should().Be("SmartDigitalPsico.Validator.Model.Field.Rule");
        }
    }

    [Test]
    public void ConvertValidationFailureList_DuplicateProperties_ReturnsDistinctResponses()
    {
        var failures = new List<ValidationFailure>
        {
            new("Name", "Name_Key|Required"),
            new("Name", "Name.Key|Another"),
            new("Email", "Invalid email")
        };

        var errors = HelperValidation.ConvertValidationFailureListToErroResponse(failures);
        errors.Select(error => error.Name).Should().BeEquivalentTo(["Name", "Email"], o => o.WithStrictOrdering());
    }
}
