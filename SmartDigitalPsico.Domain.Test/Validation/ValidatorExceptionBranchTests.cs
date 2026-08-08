using Moq;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations;
using SmartDigitalPsico.Domain.Validation.Principals;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Test.Validation;

[TestFixture]
public sealed class ValidatorExceptionBranchTests
{
    // Cenário: usuários novos, existentes e dependências com falha são validados.
    // Objetivo: executar todos os retornos das regras de unicidade de e-mail e login.
    [Test]
    public async Task UserValidator_UniqueRules_ExecuteSuccessConflictAndExceptionPaths()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        repository.Setup(value => value.Exists(It.IsAny<long>())).ReturnsAsync(false);
        repository.Setup(value => value.FindByEmail(It.IsAny<string>())).Returns(Task.FromResult<User?>(null));
        repository.Setup(value => value.FindByLogin(It.IsAny<string>())).Returns(Task.FromResult<User?>(null));
        var validator = new UserValidator(repository.Object);
        var existingRepository = new Mock<IUserRepository>();
        existingRepository.Setup(value => value.Exists(1)).ReturnsAsync(true);
        existingRepository.Setup(value => value.FindByID(1))
            .ReturnsAsync(new User { Email = "same@example.test", Login = "same-login" });
        var existingValidator = new UserValidator(existingRepository.Object);
        var duplicateRepository = new Mock<IUserRepository>();
        duplicateRepository.Setup(value => value.Exists(It.IsAny<long>())).ReturnsAsync(false);
        duplicateRepository.Setup(value => value.FindByEmail(It.IsAny<string>())).ReturnsAsync(new User());
        duplicateRepository.Setup(value => value.FindByLogin(It.IsAny<string>())).ReturnsAsync(new User());
        var duplicateValidator = new UserValidator(duplicateRepository.Object);
        var faultedRepository = new Mock<IUserRepository>();
        faultedRepository.Setup(value => value.Exists(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException());
        var faultedValidator = new UserValidator(faultedRepository.Object);

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(validator, "UniqueEmail", new User(), "new@example.test"),
            InvokeAsync(validator, "UniqueLogin", new User(), "new-login"),
            InvokeAsync(existingValidator, "UniqueEmail", new User { Id = 1 }, "changed@example.test"),
            InvokeAsync(existingValidator, "UniqueLogin", new User { Id = 1 }, "changed-login"),
            InvokeAsync(existingValidator, "UniqueEmail", new User { Id = 1 }, "same@example.test"),
            InvokeAsync(existingValidator, "UniqueLogin", new User { Id = 1 }, "same-login"),
            InvokeAsync(duplicateValidator, "UniqueEmail", new User(), "duplicate@example.test"),
            InvokeAsync(duplicateValidator, "UniqueLogin", new User(), "duplicate-login"),
            InvokeAsync(faultedValidator, "UniqueEmail", new User(), "fault@example.test"),
            InvokeAsync(faultedValidator, "UniqueLogin", new User(), "fault-login"));

        // Assert
        results.Should().Equal(true, true, false, false, true, true, false, false, false, false);
    }

    // Cenário: médicos novos, existentes e dependências com falha são validados.
    // Objetivo: executar todos os retornos das regras de unicidade de credencial e e-mail.
    [Test]
    public async Task MedicalValidator_UniqueRules_ExecuteSuccessConflictAndExceptionPaths()
    {
        // Arrange
        var repository = new Mock<IMedicalRepository>();
        repository.Setup(value => value.Exists(It.IsAny<long>())).ReturnsAsync(false);
        repository.Setup(value => value.FindByAccreditation(It.IsAny<string>())).Returns(Task.FromResult<Medical?>(null));
        repository.Setup(value => value.FindByEmail(It.IsAny<string>())).Returns(Task.FromResult<Medical?>(null));
        var validator = new MedicalValidator(repository.Object);
        var existingRepository = new Mock<IMedicalRepository>();
        existingRepository.Setup(value => value.Exists(1)).ReturnsAsync(true);
        existingRepository.Setup(value => value.FindByID(1))
            .ReturnsAsync(new Medical { Accreditation = "CRM1", Email = "same@example.test" });
        var existingValidator = new MedicalValidator(existingRepository.Object);
        var duplicateRepository = new Mock<IMedicalRepository>();
        duplicateRepository.Setup(value => value.Exists(It.IsAny<long>())).ReturnsAsync(false);
        duplicateRepository.Setup(value => value.FindByAccreditation(It.IsAny<string>())).ReturnsAsync(new Medical());
        duplicateRepository.Setup(value => value.FindByEmail(It.IsAny<string>())).ReturnsAsync(new Medical());
        var duplicateValidator = new MedicalValidator(duplicateRepository.Object);
        var faultedRepository = new Mock<IMedicalRepository>();
        faultedRepository.Setup(value => value.Exists(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException());
        var faultedValidator = new MedicalValidator(faultedRepository.Object);

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(validator, "IsUniqueAccreditation", new Medical(), "CRM1"),
            InvokeAsync(validator, "IsUniqueEmail", new Medical(), "new@example.test"),
            InvokeAsync(existingValidator, "IsUniqueAccreditation", new Medical { Id = 1 }, "CRM2"),
            InvokeAsync(existingValidator, "IsUniqueEmail", new Medical { Id = 1 }, "changed@example.test"),
            InvokeAsync(existingValidator, "IsUniqueAccreditation", new Medical { Id = 1 }, "CRM1"),
            InvokeAsync(existingValidator, "IsUniqueEmail", new Medical { Id = 1 }, "same@example.test"),
            InvokeAsync(duplicateValidator, "IsUniqueAccreditation", new Medical(), "CRM3"),
            InvokeAsync(duplicateValidator, "IsUniqueEmail", new Medical(), "duplicate@example.test"),
            InvokeAsync(faultedValidator, "IsUniqueAccreditation", new Medical(), "CRM3"),
            InvokeAsync(faultedValidator, "IsUniqueEmail", new Medical(), "fault@example.test"));

        // Assert
        results.Should().Equal(true, true, false, false, true, true, false, false, false, false);
    }

    // Cenário: pacientes novos, existentes e dependências com falha são validados.
    // Objetivo: cobrir os retornos da regra de e-mail e os limites de idade aceitos.
    [Test]
    public async Task PatientValidator_EmailAndAgeRules_ExecuteAllOutcomes()
    {
        // Arrange
        var repository = new Mock<IPatientRepository>();
        repository.Setup(value => value.Exists(It.IsAny<long>())).ReturnsAsync(false);
        repository.Setup(value => value.FindByEmail(It.IsAny<string>())).Returns(Task.FromResult<Patient?>(null));
        var validator = new PatientValidator(repository.Object, Mock.Of<IMedicalRepository>(), Mock.Of<IUserRepository>());
        var existingRepository = new Mock<IPatientRepository>();
        existingRepository.Setup(value => value.Exists(1)).ReturnsAsync(true);
        existingRepository.Setup(value => value.FindByID(1)).ReturnsAsync(new Patient { Email = "same@example.test" });
        var existingValidator = new PatientValidator(existingRepository.Object, Mock.Of<IMedicalRepository>(), Mock.Of<IUserRepository>());
        var faultedRepository = new Mock<IPatientRepository>();
        faultedRepository.Setup(value => value.Exists(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException());
        var faultedValidator = new PatientValidator(faultedRepository.Object, Mock.Of<IMedicalRepository>(), Mock.Of<IUserRepository>());

        // Act
        var results = await Task.WhenAll(
            InvokeAsync(validator, "UniqueEmail", new Patient(), "new@example.test"),
            InvokeAsync(existingValidator, "UniqueEmail", new Patient { Id = 1 }, "changed@example.test"),
            InvokeAsync(existingValidator, "UniqueEmail", new Patient { Id = 1 }, "same@example.test"),
            InvokeAsync(faultedValidator, "UniqueEmail", new Patient(), "fault@example.test"));
        var validAge = InvokeBoolean(validator, "beValidAge", DateTime.UtcNow.AddYears(-30));
        var invalidAge = InvokeBoolean(validator, "beValidAge", DateTime.UtcNow.AddYears(-131));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            results.Should().Equal(true, false, true, false);
            validAge.Should().BeTrue();
            invalidAge.Should().BeFalse();
        }
    }

    private static async Task<bool> InvokeAsync(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)!;
        return await (Task<bool>)method.Invoke(target, arguments)!;
    }

    private static bool InvokeBoolean(object target, string methodName, params object?[] arguments)
    {
        var method = target.GetType().GetMethod(methodName, BindingFlags.Static | BindingFlags.NonPublic)!;
        return (bool)method.Invoke(null, arguments)!;
    }
}
