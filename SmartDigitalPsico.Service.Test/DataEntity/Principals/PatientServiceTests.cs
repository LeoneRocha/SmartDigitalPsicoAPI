using AwesomeAssertions;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;

[TestFixture]
public class PatientServiceTests
{
    // Cenário: criação de paciente válido.
    // Objetivo: persistir e retornar o registro mapeado.
    [Test]
    public async Task Create_ValidPatient_PersistsAndReturnsSuccess()
    {
        var context = new PatientServiceContext();
        var addDto = new AddPatientDto { Name = "Alice", Email = "alice@x.com", MedicalId = 1, GenderId = 2 };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Patient>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<Patient>())).ReturnsAsync((Patient p) => { p.Id = 30; return p; });

        var result = await context.Service.Create(addDto);

        result.Success.Should().BeTrue();
    }

    // Cenário: criação de paciente inválido.
    // Objetivo: bloquear a persistência retornando os erros de validação.
    [Test]
    public async Task Create_InvalidPatient_ReturnsValidationFailure()
    {
        var context = new PatientServiceContext();
        var addDto = new AddPatientDto { Name = string.Empty };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Patient>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult([new ValidationFailure("Name", "Nome obrigatório") { ErrorCode = "NameRequired" }]));

        var result = await context.Service.Create(addDto);

        result.Success.Should().BeFalse();
        context.Repository.Verify(x => x.Create(It.IsAny<Patient>()), Times.Never);
    }

    // Cenário: atualização de paciente inexistente.
    // Objetivo: manter contrato atual (sucesso default sem dados) e não persistir.
    [Test]
    public async Task Update_MissingPatient_DoesNotPersist()
    {
        var context = new PatientServiceContext();
        context.Repository.Setup(x => x.FindByID(500)).ReturnsAsync((Patient?)null);

        var result = await context.Service.Update(new UpdatePatientDto { Id = 500 });

        result.Data.Should().BeNull();
        context.Repository.Verify(x => x.Update(It.IsAny<Patient>()), Times.Never);
    }

    // Cenário: atualização de paciente existente e válido.
    // Objetivo: aplicar as alterações e persistir.
    [Test]
    public async Task Update_ExistingValidPatient_UpdatesSuccessfully()
    {
        var context = new PatientServiceContext();
        var entity = new Patient { Id = 31, Name = "Old" };
        context.Repository.Setup(x => x.FindByID(31)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<Patient>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        var result = await context.Service.Update(new UpdatePatientDto { Id = 31, Name = "New Name", Email = "new@x.com" });

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.Name.Should().Be("New Name");
        }
    }

    // Cenário: busca de paciente existente por critério.
    // Objetivo: retornar o paciente mapeado com sucesso.
    [Test]
    public async Task FindByPatient_ExistingPatient_ReturnsSuccess()
    {
        var context = new PatientServiceContext();
        context.Repository.Setup(x => x.FindByPatient(It.IsAny<Patient>())).ReturnsAsync(new Patient { Id = 40, Name = "Bob" });

        var result = await context.Service.FindByPatient(new SmartDigitalPsico.Domain.DTO.Patient.GetPatientDto { Id = 40 });

        result.Success.Should().BeTrue();
    }

    // Cenário: busca de paciente inexistente por critério.
    // Objetivo: retornar falha informando que não foi encontrado.
    [Test]
    public async Task FindByPatient_MissingPatient_ReturnsFailure()
    {
        var context = new PatientServiceContext();
        context.Repository.Setup(x => x.FindByPatient(It.IsAny<Patient>())).ReturnsAsync((Patient)null!);

        var result = await context.Service.FindByPatient(new SmartDigitalPsico.Domain.DTO.Patient.GetPatientDto { Id = 999 });

        result.Success.Should().BeFalse();
    }

    // Cenário: chamada ao FindAll genérico (sem parâmetros) não implementado.
    // Objetivo: propagar a exceção NotImplementedException conforme contrato atual.
    [Test]
    public void FindAll_WithoutParameters_ThrowsNotImplemented()
    {
        var context = new PatientServiceContext();

        Func<Task> act = async () => await context.Service.FindAll();

        act.Should().ThrowAsync<NotImplementedException>();
    }

    // Cenário: busca de pacientes por critério sem permissão do usuário.
    // Objetivo: bloquear o resultado com falha de permissão.
    [Test]
    public async Task PatientSearch_UserWithoutPermission_ReturnsPermissionFailure()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(1);
        var patients = new List<Patient> { new() { Id = 1, MedicalId = 5, CreatedUser = new User { Id = 2 } } };
        context.Repository.Setup(x => x.PatientSearch(It.IsAny<PatientSearchCriteriaDto>())).ReturnsAsync(patients);
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 5, Admin = false });

        var result = await context.Service.PatientSearch(new PatientSearchCriteriaDto { MedicalId = 5, Name = "Bob" });

        result.Success.Should().BeFalse();
    }

    // Cenário: busca de pacientes por critério sem resultados.
    // Objetivo: retornar falha informando ausência de registros.
    [Test]
    public async Task PatientSearch_NoResults_ReturnsNotFoundFailure()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.PatientSearch(It.IsAny<PatientSearchCriteriaDto>())).ReturnsAsync([]);
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.PatientSearch(new PatientSearchCriteriaDto { MedicalId = 5, Name = "" });

        result.Success.Should().BeFalse();
    }

    // Cenário: busca de pacientes por critério com permissão válida.
    // Objetivo: retornar a lista ordenada por nome.
    [Test]
    public async Task PatientSearch_UserWithPermission_ReturnsOrderedList()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(7);
        var createdUser = new User { Id = 7 };
        var patients = new List<Patient>
        {
            new() { Id = 1, Name = "Zoe", MedicalId = 5, CreatedUser = createdUser },
            new() { Id = 2, Name = "Amy", MedicalId = 5, CreatedUser = createdUser }
        };
        context.Repository.Setup(x => x.PatientSearch(It.IsAny<PatientSearchCriteriaDto>())).ReturnsAsync(patients);
        context.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 5 });

        var result = await context.Service.PatientSearch(new PatientSearchCriteriaDto { MedicalId = 5, Name = "" });

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Select(x => x.Name).Should().ContainInOrder("Amy", "Zoe");
        }
    }

    // Cenário: consulta de pacientes por médico sem resultados.
    // Objetivo: retornar falha informando ausência de registros.
    [Test]
    public async Task FindAllByMedicalId_NoResults_ReturnsNotFoundFailure()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByMedicalId(5)).ReturnsAsync([]);
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindAll(5);

        result.Success.Should().BeFalse();
    }

    // Cenário: consulta por médico com registros sem permissão do usuário.
    // Objetivo: retornar falha de permissão antes do not-found.
    [Test]
    public async Task FindAllByMedicalId_UserWithoutPermission_ReturnsPermissionFailure()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindAllByMedicalId(5)).ReturnsAsync(
        [
            new Patient { Id = 1, Name = "A", MedicalId = 5, CreatedUser = new User { Id = 9 } }
        ]);
        context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 5, Admin = false });

        var result = await context.Service.FindAll(5);

        result.Success.Should().BeFalse();
        result.Errors.Should().NotBeEmpty();
    }

    // Cenário: consulta de pacientes por médico com permissão válida.
    // Objetivo: retornar a lista mapeada ordenada por nome.
    [Test]
    public async Task FindAllByMedicalId_UserWithPermission_ReturnsMappedList()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(8);
        var createdUser = new User { Id = 8 };
        var patients = new List<Patient>
        {
            new() { Id = 1, Name = "Carl", MedicalId = 9, CreatedUser = createdUser },
            new() { Id = 2, Name = "Alice", MedicalId = 9, CreatedUser = createdUser }
        };
        context.Repository.Setup(x => x.FindAllByMedicalId(9)).ReturnsAsync(patients);
        context.UserRepository.Setup(x => x.FindByID(8)).ReturnsAsync(new User { Id = 8, MedicalId = 9 });

        var result = await context.Service.FindAll(9);

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().HaveCount(2);
            result.Data!.Select(x => x.Name).Should().BeInAscendingOrder();
        }
    }

    // Cenário: busca de paciente por ID sem permissão (usuário diferente e não admin).
    // Objetivo: bloquear o acesso com falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(20)).ReturnsAsync(new Patient { Id = 20, CreatedUser = new User { Id = 2 } });
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = false });

        var result = await context.Service.FindByID(20);

        result.Success.Should().BeFalse();
    }

    // Cenário: busca de paciente por ID com usuário administrador.
    // Objetivo: retornar o paciente mapeado mesmo sem ser o criador.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedPatient()
    {
        var context = new PatientServiceContext();
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(21)).ReturnsAsync(new Patient { Id = 21, Name = "Diana", CreatedUser = new User { Id = 2 } });
        context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(21);

        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.Name.Should().Be("Diana");
        }
    }

    // Cenário: exceção inesperada durante a busca por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        var context = new PatientServiceContext();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        var result = await context.Service.FindByID(22);

        result.Success.Should().BeFalse();
    }

    private sealed class PatientServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IPatientRepository> Repository { get; } = new();
        public Mock<IValidator<Patient>> Validator { get; } = new();
        public Mock<IUserRepository> UserRepository => Context.UserRepository;
        public PatientService Service { get; }

        public PatientServiceContext()
        {
            Service = new PatientService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }
}
