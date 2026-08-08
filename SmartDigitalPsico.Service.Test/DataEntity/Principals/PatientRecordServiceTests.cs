using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.Test.TestSupport;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;

[TestFixture]
public class PatientRecordServiceTests
{
    // Cenário: criação de registro clínico válido.
    // Objetivo: buscar paciente/médico, criptografar a anotação e persistir via storage table.
    [Test]
    public async Task Create_ValidRecord_EncryptsAnnotationAndPersists()
    {
        // Arrange
        var context = new PatientRecordContext();
        var dto = new AddPatientRecordDto { PatientId = 5, Description = "Consulta", Annotation = "secreto", AnnotationDate = DateTime.UtcNow };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.PatientRepository.Setup(x => x.FindByID(5)).ReturnsAsync(new Patient { Id = 5, MedicalId = 9 });
        context.MedicalRepository.Setup(x => x.FindByID(9)).ReturnsAsync(new Medical { Id = 9, SecurityKey = "key-1" });
        context.Context.Crypto.Setup(x => x.Encrypt("key-1", "secreto")).Returns("encrypted-annotation");
        context.StorageTableService.Setup(x => x.UpdateAsync(It.IsAny<PatientRecordTableEntity>())).Returns(Task.CompletedTask);
        context.Repository.Setup(x => x.Create(It.IsAny<PatientRecord>())).ReturnsAsync((PatientRecord r) => { r.Id = 100; return r; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
        }
        context.StorageTableService.Verify(x => x.UpdateAsync(It.IsAny<PatientRecordTableEntity>()), Times.Once);
    }

    // Cenário: atualização de registro clínico existente.
    // Objetivo: reencriptar a anotação, persistir e registrar auditoria.
    [Test]
    public async Task Update_ExistingRecord_ReEncryptsAndSavesAudit()
    {
        // Arrange
        var context = new PatientRecordContext();
        var entity = new PatientRecord { Id = 30, PatientId = 5, Patient = new Patient { Id = 5, MedicalId = 9 } };
        context.Repository.Setup(x => x.FindByID(30)).ReturnsAsync(entity);
        context.Context.UserRepository.Setup(x => x.FindByID(It.IsAny<long>())).ReturnsAsync(new User { Id = 1, Name = "Admin" });
        context.MedicalRepository.Setup(x => x.FindByID(9)).ReturnsAsync(new Medical { Id = 9, SecurityKey = "key-2" });
        context.Context.Crypto.Setup(x => x.Encrypt("key-2", It.IsAny<string>())).Returns("encrypted-2");
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientRecord>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.StorageTableService.Setup(x => x.UpdateAsync(It.IsAny<PatientRecordTableEntity>())).Returns(Task.CompletedTask);
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);
        context.AuditService.Setup(x => x.Save(It.IsAny<object>(), It.IsAny<object>(), "Update", It.IsAny<string[]>())).Returns(Task.CompletedTask);

        var dto = new UpdatePatientRecordDto { Id = 30, PatientId = 5, Description = "Nova", Annotation = "novo-texto", AnnotationDate = DateTime.UtcNow };

        // Act
        var result = await context.Service.Update(dto);

        // Assert
        result.Success.Should().BeTrue();

        context.AuditService.Verify(x => x.Save(It.IsAny<object>(), It.IsAny<object>(), "Update", It.IsAny<string[]>()), Times.Once);
    }

    // Cenário: consulta de registros do paciente sem vínculo válido de permissão.
    // Objetivo: retornar falha de permissão sem mapear dados.
    [Test]
    public async Task FindAllByPatient_NoRecords_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: lista com registros sem permissão do usuário logado.
    // Objetivo: retornar falha de permissão com erros detalhados.
    [Test]
    public async Task FindAllByPatient_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        context.Service.SetUserId(2);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync(
        [
            new PatientRecord { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } }
        ]);
        context.Context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: consulta de registros do paciente autorizada.
    // Objetivo: mapear e retornar a lista de registros.
    [Test]
    public async Task FindAllByPatient_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        context.Service.SetUserId(7);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        var record = new PatientRecord { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([record]);
        context.Context.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: busca de registro por ID com usuário administrador.
    // Objetivo: decriptar a anotação e mapear o resultado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsDecryptedResult()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        context.Service.SetUserId(1);
        var entity = new PatientRecord { Id = 40, PatientId = 5, Annotation = "cipher" };
        context.Repository.Setup(x => x.FindByID(40)).ReturnsAsync(entity);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });
        context.PatientRepository.Setup(x => x.FindByID(5, It.IsAny<System.Linq.Expressions.Expression<Func<Patient, object>>[]>()))
            .ReturnsAsync(new Patient { Id = 5, Medical = new Medical { SecurityKey = "key-3" } });
        context.Context.Crypto.Setup(x => x.Decrypt("key-3", "cipher")).Returns("plain-text");

        var result = await context.Service.FindByID(40);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().NotBeNull();
        }
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(40)).ReturnsAsync(new PatientRecord
        {
            Id = 40,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 },
            Annotation = "x"
        });
        context.Context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(40);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: erro inesperado durante a busca por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new PatientRecordContext();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(41);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: FindAll não é suportado por esse serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new PatientRecordContext();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class PatientRecordContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IPatientRecordRepository> Repository { get; } = new();
        public Mock<IMedicalRepository> MedicalRepository { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public Mock<IValidator<PatientRecord>> Validator { get; } = new();
        public Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>> StorageTableService { get; } = new();
        public Mock<IAuditDataSelectiveEntityLogService> AuditService { get; } = new();
        public PatientRecordService Service { get; }

        public PatientRecordContext()
        {
            var repositories = new Mock<IPatientRepositories>();
            repositories.SetupGet(x => x.PatientRecordRepository).Returns(Repository.Object);
            repositories.SetupGet(x => x.MedicalRepository).Returns(MedicalRepository.Object);
            repositories.SetupGet(x => x.PatientRepository).Returns(PatientRepository.Object);
            repositories.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);

            var config = new Mock<IPatientRecordServiceConfig>();
            config.SetupGet(x => x.SharedServices).Returns(Context.SharedServices);
            config.SetupGet(x => x.SharedDependenciesConfig).Returns(Context.Config);
            config.SetupGet(x => x.SharedRepositories).Returns(Context.SharedRepositories);
            config.SetupGet(x => x.EntityValidator).Returns(Validator.Object);
            config.SetupGet(x => x.StorageTableService).Returns(StorageTableService.Object);

            Service = new PatientRecordService(repositories.Object, config.Object, AuditService.Object);
        }
    }
}
