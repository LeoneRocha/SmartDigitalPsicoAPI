using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;

[TestFixture]
public class PatientAdditionalInformationServiceTests
{
    // Cenário: criação de informação adicional válida.
    // Objetivo: persistir o registro vinculado ao paciente.
    [Test]
    public async Task Create_ValidItem_PersistsSuccessfully()
    {
        // Arrange
        var context = new Context();
        var dto = new AddPatientAdditionalInformationDto { PatientId = 5, FollowUp_Psychiatric = "Sim" };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientAdditionalInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<PatientAdditionalInformation>())).ReturnsAsync((PatientAdditionalInformation e) => { e.Id = 1; return e; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: atualização de informação adicional existente.
    // Objetivo: aplicar as alterações e persistir.
    [Test]
    public async Task Update_ExistingItem_UpdatesSuccessfully()
    {
        // Arrange
        var context = new Context();
        var entity = new PatientAdditionalInformation { Id = 2, PatientId = 5 };
        context.Repository.Setup(x => x.FindByID(2)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientAdditionalInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdatePatientAdditionalInformationDto { Id = 2, FollowUp_Neurological = "Nao" });

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: consulta sem registros vinculados ao paciente.
    // Objetivo: retornar falha de permissão pois a lista de registros está vazia.
    [Test]
    public async Task FindAllByPatient_EmptyList_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: lista com registros sem permissão do usuário logado.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByPatient_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync(
        [
            new PatientAdditionalInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } }
        ]);
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: consulta autorizada de registros vinculados ao paciente.
    // Objetivo: mapear e retornar a lista de registros.
    [Test]
    public async Task FindAllByPatient_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(7);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        var item = new PatientAdditionalInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([item]);
        context.Shared.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: busca por ID com usuário administrador.
    // Objetivo: mapear e retornar o registro encontrado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedResult()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientAdditionalInformation { Id = 3, PatientId = 5 });
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientAdditionalInformation
        {
            Id = 3,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 }
        });
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: erro inesperado ao buscar por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(4);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: FindAll genérico não é suportado por esse serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new Context();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class Context
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<IPatientAdditionalInformationRepository> Repository { get; } = new();
        public Mock<IValidator<PatientAdditionalInformation>> Validator { get; } = new();
        public PatientAdditionalInformationService Service { get; }

        public Context()
        {
            Service = new PatientAdditionalInformationService(
                this.Shared.SharedServices,
                this.Shared.Config,
                this.Shared.SharedRepositories,
                Repository.Object,
                this.Shared.UserRepository.Object,
                Validator.Object);
        }
    }
}

[TestFixture]
public class PatientHospitalizationInformationServiceTests
{
    // Cenário: criação de registro de internação válido.
    // Objetivo: persistir o registro vinculado ao paciente.
    [Test]
    public async Task Create_ValidItem_PersistsSuccessfully()
    {
        // Arrange
        var context = new Context();
        var dto = new AddPatientHospitalizationInformationDto { PatientId = 5, CID = "A00", Description = "Internação" };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientHospitalizationInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<PatientHospitalizationInformation>())).ReturnsAsync((PatientHospitalizationInformation e) => { e.Id = 1; return e; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: atualização de registro de internação existente.
    // Objetivo: aplicar as alterações e persistir.
    [Test]
    public async Task Update_ExistingItem_UpdatesSuccessfully()
    {
        // Arrange
        var context = new Context();
        var entity = new PatientHospitalizationInformation { Id = 2, PatientId = 5 };
        context.Repository.Setup(x => x.FindByID(2)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientHospitalizationInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdatePatientHospitalizationInformationDto { Id = 2, CID = "B00" });

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: consulta sem registros vinculados ao paciente.
    // Objetivo: retornar falha de permissão pois a lista está vazia.
    [Test]
    public async Task FindAllByPatient_EmptyList_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: lista com registros sem permissão do usuário logado.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByPatient_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync(
        [
            new PatientHospitalizationInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } }
        ]);
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: consulta autorizada de registros vinculados ao paciente.
    // Objetivo: mapear e retornar a lista de registros.
    [Test]
    public async Task FindAllByPatient_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(7);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        var item = new PatientHospitalizationInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([item]);
        context.Shared.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: busca por ID com usuário administrador.
    // Objetivo: mapear e retornar o registro encontrado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedResult()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientHospitalizationInformation { Id = 3, PatientId = 5 });
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientHospitalizationInformation
        {
            Id = 3,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 }
        });
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: erro inesperado ao buscar por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(4);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: FindAll genérico não é suportado por esse serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new Context();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class Context
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<IPatientHospitalizationInformationRepository> Repository { get; } = new();
        public Mock<IValidator<PatientHospitalizationInformation>> Validator { get; } = new();
        public PatientHospitalizationInformationService Service { get; }

        public Context()
        {
            Service = new PatientHospitalizationInformationService(
                this.Shared.SharedServices,
                this.Shared.Config,
                this.Shared.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }
}

[TestFixture]
public class PatientMedicationInformationServiceTests
{
    // Cenário: criação de registro de medicação válido.
    // Objetivo: persistir o registro vinculado ao paciente.
    [Test]
    public async Task Create_ValidItem_PersistsSuccessfully()
    {
        // Arrange
        var context = new Context();
        var dto = new AddPatientMedicationInformationDto { PatientId = 5, MainDrug = "Dipirona" };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientMedicationInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<PatientMedicationInformation>())).ReturnsAsync((PatientMedicationInformation e) => { e.Id = 1; return e; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: atualização de registro de medicação existente.
    // Objetivo: aplicar as alterações e persistir.
    [Test]
    public async Task Update_ExistingItem_UpdatesSuccessfully()
    {
        // Arrange
        var context = new Context();
        var entity = new PatientMedicationInformation { Id = 2, PatientId = 5 };
        context.Repository.Setup(x => x.FindByID(2)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientMedicationInformation>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdatePatientMedicationInformationDto { Id = 2, MainDrug = "Paracetamol" });

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: consulta sem registros vinculados ao paciente.
    // Objetivo: retornar falha de permissão pois a lista está vazia.
    [Test]
    public async Task FindAllByPatient_EmptyList_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: lista com registros sem permissão do usuário logado.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByPatient_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync(
        [
            new PatientMedicationInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } }
        ]);
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: consulta autorizada de registros vinculados ao paciente.
    // Objetivo: mapear e retornar a lista de registros.
    [Test]
    public async Task FindAllByPatient_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(7);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        var item = new PatientMedicationInformation { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([item]);
        context.Shared.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: busca por ID com usuário administrador.
    // Objetivo: mapear e retornar o registro encontrado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedResult()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientMedicationInformation { Id = 3, PatientId = 5 });
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(new PatientMedicationInformation
        {
            Id = 3,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 }
        });
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(3);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: erro inesperado ao buscar por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(4);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: FindAll genérico não é suportado por esse serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new Context();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class Context
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<IPatientMedicationInformationRepository> Repository { get; } = new();
        public Mock<IValidator<PatientMedicationInformation>> Validator { get; } = new();
        public PatientMedicationInformationService Service { get; }

        public Context()
        {
            Service = new PatientMedicationInformationService(
                this.Shared.SharedServices,
                this.Shared.Config,
                this.Shared.SharedRepositories,
                Repository.Object,
                Validator.Object);
        }
    }
}

[TestFixture]
public class PatientNotificationMessageServiceTests
{
    // Cenário: criação de mensagem de notificação vinculada a um paciente encontrado por CPF/RG/e-mail.
    // Objetivo: persistir a mensagem vinculando o paciente localizado.
    [Test]
    public async Task Create_PatientFound_PersistsWithPatientLink()
    {
        // Arrange
        var context = new Context();
        var dto = new AddPatientNotificationMessageDto { Message = "Lembrete", CPF = "111", RG = "222", Email = "a@x.com" };
        context.PatientRepository.Setup(x => x.FindByPatient(It.IsAny<Patient>())).ReturnsAsync(new Patient { Id = 5 });
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientNotificationMessage>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<PatientNotificationMessage>())).ReturnsAsync((PatientNotificationMessage e) => { e.Id = 1; return e; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: criação de mensagem sem paciente correspondente.
    // Objetivo: seguir o fluxo padrão utilizando um paciente vazio.
    [Test]
    public async Task Create_PatientNotFound_PersistsWithEmptyPatientLink()
    {
        // Arrange
        var context = new Context();
        var dto = new AddPatientNotificationMessageDto { Message = "Lembrete" };
        context.PatientRepository.Setup(x => x.FindByPatient(It.IsAny<Patient>())).ReturnsAsync((Patient)null!);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientNotificationMessage>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Create(It.IsAny<PatientNotificationMessage>())).ReturnsAsync((PatientNotificationMessage e) => { e.Id = 2; return e; });

        // Act
        var result = await context.Service.Create(dto);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: atualização de mensagem marcando como lida e notificada.
    // Objetivo: registrar as datas correspondentes e persistir.
    [Test]
    public async Task Update_MarkReadAndNotified_SetsDatesAndPersists()
    {
        // Arrange
        var context = new Context();
        var entity = new PatientNotificationMessage { Id = 3 };
        context.Repository.Setup(x => x.FindByID(3)).ReturnsAsync(entity);
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<PatientNotificationMessage>(), It.IsAny<CancellationToken>())).ReturnsAsync(new ValidationResult());
        context.Repository.Setup(x => x.Update(entity)).ReturnsAsync(entity);

        // Act
        var result = await context.Service.Update(new UpdatePatientNotificationMessageDto { Id = 3, Message = "Lida", IsReaded = true, Notified = true });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            entity.IsReaded.Should().BeTrue();
            entity.ReadingDate.Should().NotBeNull();
            entity.Notified.Should().BeTrue();
            entity.NotifiedDate.Should().NotBeNull();
        }
    }

    // Cenário: consulta de mensagens do paciente sem registros.
    // Objetivo: retornar falha informando que não foram encontradas mensagens.
    [Test]
    public async Task FindAllByPatient_NoMessages_ReturnsNotFoundFailure()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);

        // Act
        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: consulta de mensagens do paciente com registros existentes.
    // Objetivo: mapear e retornar a lista de mensagens.
    [Test]
    public async Task FindAllByPatient_HasMessages_ReturnsMappedList()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([new PatientNotificationMessage { Id = 1, PatientId = 5 }]);

        // Act
        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: FindAll genérico não é suportado por esse serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new Context();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca por ID com usuário administrador.
    // Objetivo: mapear e retornar o registro encontrado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedResult()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindByID(9)).ReturnsAsync(new PatientNotificationMessage { Id = 9 });
        context.Shared.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(9);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new Context();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(9)).ReturnsAsync(new PatientNotificationMessage
        {
            Id = 9,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 }
        });
        context.Shared.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(9);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: erro inesperado ao buscar por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new Context();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(10);

        // Assert
        result.Success.Should().BeFalse();
    }

    private sealed class Context
    {
        public ServiceTestContext Shared { get; } = new();
        public Mock<IPatientNotificationMessageRepository> Repository { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public Mock<IValidator<PatientNotificationMessage>> Validator { get; } = new();
        public PatientNotificationMessageService Service { get; }

        public Context()
        {
            Service = new PatientNotificationMessageService(
                this.Shared.SharedServices,
                this.Shared.Config,
                this.Shared.SharedRepositories,
                Repository.Object,
                PatientRepository.Object,
                Validator.Object);
        }
    }
}
