using Moq;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class BaseValidatorTests
{
    // Cenário: regras-base médicas consultam repositórios com estados existentes, divergentes e falhos.
    // Objetivo: decidir corretamente criação, alteração e existência de médicos.
    [Test]
    public async Task MedicalBaseValidator_RepositoryScenarios_ReturnsExpectedPermissions()
    {
        // Arrange
        var medicalRepository = new Mock<IMedicalRepository>();
        var entityRepository = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        var userRepository = new Mock<IUserRepository>();
        var validator = new MedicalBaseValidator<MedicalCalendar>(medicalRepository.Object, entityRepository.Object, userRepository.Object);
        var entity = new MedicalCalendar { Id = 1, MedicalId = 10 };
        entityRepository.Setup(repository => repository.Exists(1)).ReturnsAsync(true);
        entityRepository.Setup(repository => repository.FindByID(1)).ReturnsAsync(new MedicalCalendar { Id = 1, MedicalId = 11 });
        medicalRepository.Setup(repository => repository.Exists(10)).ReturnsAsync(true);
        userRepository.Setup(repository => repository.FindByID(It.IsAny<long>()))
            .ReturnsAsync(new User { Medical = new Medical { Id = 10 } });

        // Act
        var changed = await validator.MedicalIdChanged(entity);
        var found = await validator.MedicalIdFound(entity);
        var created = await validator.MedicalCreated(new MedicalCalendar { MedicalId = 10 }, 0, 7);
        var rejectedCreate = await validator.MedicalCreated(new MedicalCalendar { MedicalId = 12 }, 0, 7);
        var modified = await validator.MedicalModify(entity, 0, 7);
        var unchanged = await validator.MedicalIdChanged(new MedicalCalendar { Id = 2, MedicalId = 10 });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            changed.Should().BeFalse();
            found.Should().BeTrue();
            created.Should().BeTrue();
            rejectedCreate.Should().BeFalse();
            modified.Should().BeTrue();
            unchanged.Should().BeTrue();
        }
    }

    // Cenário: regras-base de paciente recebem relações compatíveis, incompatíveis e ausentes.
    // Objetivo: validar posse de paciente e existência no repositório.
    [Test]
    public async Task PatientBaseValidator_RepositoryScenarios_ReturnsExpectedPermissions()
    {
        // Arrange
        var patientRepository = new Mock<IPatientRepository>();
        var entityRepository = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientRecord>>();
        var validator = new PatientBaseValidator<PatientRecord>(patientRepository.Object, entityRepository.Object);
        var entity = new PatientRecord { Id = 1, PatientId = 10 };
        entityRepository.Setup(repository => repository.Exists(1)).ReturnsAsync(true);
        entityRepository.Setup(repository => repository.FindByID(10)).ReturnsAsync(new PatientRecord { PatientId = 11 });
        patientRepository.Setup(repository => repository.Exists(10)).ReturnsAsync(true);
        patientRepository.Setup(repository => repository.FindByID(10))
            .ReturnsAsync(new Patient { Medical = new Medical { UserId = 7 } });

        // Act
        var changed = await validator.PatientIdChanged(entity);
        var found = await validator.PatientIdFound(entity);
        var created = await validator.MedicalCreated(entity, 7);
        var rejected = await validator.MedicalModify(entity, 8);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            changed.Should().BeFalse();
            found.Should().BeTrue();
            created.Should().BeTrue();
            rejected.Should().BeFalse();
        }
    }

    // Cenário: as consultas de entidades lançam exceções durante a validação.
    // Objetivo: retornar falso nos fluxos protegidos por tratamento de exceção.
    [Test]
    public async Task BaseValidators_FaultedRepositories_ReturnFalse()
    {
        // Arrange
        var medicalEntities = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalCalendar>>();
        medicalEntities.Setup(repository => repository.Exists(It.IsAny<long>()))
            .ThrowsAsync(new InvalidOperationException());
        var users = new Mock<IUserRepository>();
        users.Setup(repository => repository.FindByID(It.IsAny<long>()))
            .ThrowsAsync(new InvalidOperationException());
        var medicalValidator = new MedicalBaseValidator<MedicalCalendar>(
            Mock.Of<IMedicalRepository>(), medicalEntities.Object, users.Object);

        var patientEntities = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientRecord>>();
        patientEntities.Setup(repository => repository.Exists(It.IsAny<long>()))
            .ThrowsAsync(new InvalidOperationException());
        var patients = new Mock<IPatientRepository>();
        patients.Setup(repository => repository.FindByID(It.IsAny<long>()))
            .ThrowsAsync(new InvalidOperationException());
        var patientValidator = new PatientBaseValidator<PatientRecord>(patients.Object, patientEntities.Object);

        // Act
        var results = await Task.WhenAll(
            medicalValidator.MedicalIdChanged(new MedicalCalendar { Id = 1 }),
            medicalValidator.MedicalCreated(new MedicalCalendar(), 0, 1),
            medicalValidator.MedicalModify(new MedicalCalendar { Id = 1 }, 0, 1),
            patientValidator.PatientIdChanged(new PatientRecord { Id = 1 }),
            patientValidator.MedicalCreated(new PatientRecord(), 1),
            patientValidator.MedicalModify(new PatientRecord(), 1));

        // Assert
        results.Should().OnlyContain(result => !result);
    }
}
