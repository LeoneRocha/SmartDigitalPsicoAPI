using Bogus;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Test.Validation.PatientValidations.CustomValidator;

[TestFixture]
public sealed class PatientPermissionMedicalValidatorTests
{
    private readonly Faker _faker = new();

    [Test]
    public void ValidatePermissionMedical_MatchingMedical_ReturnsNoError()
    {
        // Cenário: um médico realiza uma operação para o próprio registro.
        // Objetivo: permitir a operação quando a identificação do médico corresponde.
        // Arrange
        var medicalId = _faker.Random.Long(1, long.MaxValue);
        var user = new User { MedicalId = medicalId, Admin = false };

        // Act
        var result = PatientPermissionMedicalValidator.ValidatePermissionMedical(medicalId, user);

        // Assert
        result.Message.Should().BeNullOrEmpty();
    }

    [Test]
    public void ValidatePermissionMedical_MissingUser_ReturnsPermissionError()
    {
        // Cenário: nenhuma pessoa usuária é informada.
        // Objetivo: rejeitar acesso sem contexto de usuário.
        // Arrange
        var medicalId = _faker.Random.Long(1, long.MaxValue);

        // Act
        var result = PatientPermissionMedicalValidator.ValidatePermissionMedical(medicalId, null!);

        // Assert
        result.Message.Should().Contain("UserRequired");
    }

    [Test]
    public void ValidatePermissionAdmin_NonAdmin_ReturnsUnauthorizedError()
    {
        // Cenário: um usuário não administrador tenta executar ação restrita.
        // Objetivo: rejeitar o acesso administrativo indevido.
        // Arrange
        var user = new User { Admin = false };

        // Act
        var result = PatientPermissionMedicalValidator.ValidatePermissionAdmin(user);

        // Assert
        result.ErrorCode.Should().Be("401");
    }

    [Test]
    public void ValidatePermissionAdmin_Admin_ReturnsNoError()
    {
        // Cenário: um administrador solicita uma ação protegida.
        // Objetivo: permitir o acesso administrativo.
        // Arrange
        var user = new User { Admin = true };

        // Act
        var result = PatientPermissionMedicalValidator.ValidatePermissionAdmin(user);

        // Assert
        result.Message.Should().BeNullOrEmpty();
    }
}
