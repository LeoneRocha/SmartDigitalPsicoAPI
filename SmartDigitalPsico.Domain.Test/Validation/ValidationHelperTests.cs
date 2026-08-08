using FluentValidation.Results;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Validation;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class ValidationHelperTests
{
    // Cenário: mensagem com pipe sem segunda parte e código estruturado.
    // Objetivo: cobrir ternários e else-if restantes de HelperValidation.
    [Test]
    public void GetErrorsMap_PipeWithoutSecondPartAndStructuredCode_PreservesExpectedFields()
    {
        // Arrange
        var validation = new ValidationResult(
        [
            new ValidationFailure("Single", "OnlyPipePart_WithUnderscore") { ErrorCode = "legacy" },
            new ValidationFailure("Structured", "Token_Key|Only one segment")
            {
                ErrorCode = ValidationErrorCodes.For("Validator", "Model", "Field")
            }
        ]);

        // Act
        var errors = HelperValidation.GetErrorsMap(validation);
        var translated = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "OnlyPipe_WithUnderscore",
            ErrorCode = ValidationErrorCodes.For("Validator", "Model", "Field")
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            errors[0].DefaultMessage.Should().Be("OnlyPipePart_WithUnderscore");
            errors[1].ErrorCode.Should().Be(ValidationErrorCodes.For("Validator", "Model", "Field"));
            translated.ErrorCode.Should().Be(ValidationErrorCodes.For("Validator", "Model", "Field"));
            translated.Message.Should().BeEmpty();
        }
    }

    // Cenário: falhas FluentValidation usam formatos estruturados, legados e texto simples.
    // Objetivo: preservar códigos estruturados e traduzir os demais formatos de erro.
    [Test]
    public void GetErrorsMap_ErrorFormats_ReturnsMappedResponses()
    {
        // Arrange
        var validation = new ValidationResult(
        [
            new ValidationFailure("Name", "Legacy_Key|Legacy message") { ErrorCode = "legacy" },
            new ValidationFailure("Code", "Plain message") { ErrorCode = "plain" },
            new ValidationFailure("Structured", "Structured_Key|Structured message")
            {
                ErrorCode = ValidationErrorCodes.For("Validator", "Model", "Field")
            }
        ]);

        // Act
        var errors = HelperValidation.GetErrorsMap(validation);
        var translated = HelperValidation.TranslateErroCode(new ErrorResponse
        {
            FullMessage = "Token_Key|Translated message",
            ErrorCode = "legacy"
        });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            HelperValidation.GetErrorsMap(null).Should().BeEmpty();
            HelperValidation.GetErrorsMap(new ValidationResult()).Should().BeEmpty();
            errors.Should().HaveCount(3);
            errors[0].ErrorCode.Should().Be("Legacy_Key");
            errors[0].DefaultMessage.Should().Be("Legacy message");
            errors[1].ErrorCode.Should().Be("Plain_message");
            errors[2].ErrorCode.Should().Be("SmartDigitalPsico.Validator.Model.Field");
            translated.ErrorCode.Should().Be("Token_Key");
            translated.Message.Should().Be("Translated message");
            HelperValidation.TranslateErroCode("Maximum [MaxLength]", "[12,]").Should().Be("Maximum 12");
            HelperValidation.TranslateErroCode("unchanged", string.Empty).Should().Be("unchanged");
            ValidationErrorCodes.For("Validator", "Model", "Field", "Rule").Should().Be("SmartDigitalPsico.Validator.Model.Field.Rule");
        }
    }

    // Cenário: uma lista de falhas repete a mesma propriedade.
    // Objetivo: retornar apenas um erro por propriedade.
    [Test]
    public void ConvertValidationFailureList_DuplicateProperties_ReturnsDistinctResponses()
    {
        // Arrange
        var failures = new List<ValidationFailure>
        {
            new("Name", "Name_Key|Required"),
            new("Name", "Name_Key|Another"),
            new("Email", "Invalid email")
        };

        // Act
        var errors = HelperValidation.ConvertValidationFailureListToErroResponse(failures);

        // Assert
        errors.Select(error => error.Name).Should().BeEquivalentTo(["Name", "Email"], options => options.WithStrictOrdering());
    }

    // Cenário: permissões médicas recebem usuário divergente, administrador e usuário ausente.
    // Objetivo: cobrir todas as decisões de autorização.
    [Test]
    public void PatientPermissions_UserVariations_ReturnExpectedErrors()
    {
        // Arrange
        var doctor = new User { MedicalId = 1, Admin = false };
        var admin = new User { MedicalId = 1, Admin = true };

        // Act
        var mismatch = PatientPermissionMedicalValidator.ValidatePermissionMedical(2, doctor);
        var adminMedical = PatientPermissionMedicalValidator.ValidatePermissionMedical(2, admin);
        var missingAdmin = PatientPermissionMedicalValidator.ValidatePermissionAdmin(null!);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            mismatch.Message.Should().Contain("MedicalUserMismatch");
            adminMedical.Message.Should().BeNullOrEmpty();
            missingAdmin.ErrorCode.Should().Be("401");
            missingAdmin.Message.Should().Contain("UserRequired");
        }
    }

    // Cenário: valores de notificação e armazenamento são inicializados.
    // Objetivo: manter coleções utilizáveis e propriedades de blob atribuíveis.
    [Test]
    public void TransportValues_ConstructedAndAssigned_PreserveExpectedData()
    {
        // Arrange
        var notification = new DataNotificationTemplateVO("Subject", "Body");
        var emptyNotification = new DataNotificationTemplateVO();
        var blob = new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.BlobFileDto();

        // Act
        notification.ToEmails.Add("ana@example.com");
        emptyNotification.ToPhoneNumbers.Add("5511999999999");
        blob.FilePath = "/files/a.pdf";
        blob.ContainerName = "documents";
        blob.BlobName = "a.pdf";

        // Assert
        using (Assert.EnterMultipleScope())
        {
            notification.Subject.Should().Be("Subject");
            notification.Body.Should().Be("Body");
            notification.ToEmails.Should().ContainSingle();
            emptyNotification.ToPhoneNumbers.Should().ContainSingle();
            blob.FilePath.Should().Be("/files/a.pdf");
            blob.ContainerName.Should().Be("documents");
            blob.BlobName.Should().Be("a.pdf");
        }
    }
}
