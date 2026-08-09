using FluentValidation;
using Moq;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Service.Test.TestSupport;

using Patient = global::SmartDigitalPsico.Domain.EntityModels.Patient;
using User = global::SmartDigitalPsico.Domain.EntityModels.User;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;

[TestFixture]
public class PatientFileServiceTests
{
    // Cenário: envio de arquivo válido vinculado a um paciente.
    // Objetivo: persistir o arquivo físico e criar o registro no repositório.
    [Test]
    public async Task PostFileAsync_ValidEntity_PersistsFileAndReturnsTrue()
    {
        // Arrange
        var context = new PatientFileServiceContext();
        var dto = new AddPatientFileDto { PatientId = 5, Description = "Exame", FileDetails = CreateFormFile() };
        context.PatientRepository.Setup(x => x.FindByID(5)).ReturnsAsync(new Patient { Id = 5, MedicalId = 9 });
        context.FilePersistor.Setup(x => x.PersistFile(It.IsAny<Microsoft.AspNetCore.Http.IFormFile>(), It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "patientfiles", "9_5"))
            .ReturnsAsync("stored/path.pdf");
        context.Repository.Setup(x => x.Create(It.IsAny<PatientFile>())).ReturnsAsync((PatientFile f) => { f.Id = 12; return f; });

        // Act
        var result = await context.Service.PostFileAsync(dto);

        // Assert
        result.Should().BeTrue();

        context.Repository.Verify(x => x.Create(It.IsAny<PatientFile>()), Times.Once);
    }

    // Cenário: download de arquivo existente vinculado a um paciente.
    // Objetivo: recuperar o conteúdo binário e mapear o DTO de retorno.
    [Test]
    public async Task DownloadFileById_ExistingFile_ReturnsMappedDtoWithData()
    {
        // Arrange
        var context = new PatientFileServiceContext();
        var fileEntity = new PatientFile { Id = 15, PatientId = 5, FileName = "exam.pdf" };
        context.Repository.Setup(x => x.FindByID(15)).ReturnsAsync(fileEntity);
        context.PatientRepository.Setup(x => x.FindByID(5)).ReturnsAsync(new Patient { Id = 5, MedicalId = 9 });
        context.FilePersistor.Setup(x => x.DownloadFileById(It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "9_5"))
            .ReturnsAsync(new PatientFile { FileData = new byte[] { 1, 2, 3 } });

        // Act
        var result = await context.Service.DownloadFileById(15);

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: exclusão de arquivo do paciente.
    // Objetivo: delegar a operação de exclusão para habilitar/desabilitar o registro.
    [Test]
    public async Task Delete_ExistingFile_DelegatesToEnableOrDisable()
    {
        // Arrange
        var context = new PatientFileServiceContext();
        context.Repository.Setup(x => x.Exists(20)).ReturnsAsync(true);
        context.Repository.Setup(x => x.EnableOrDisable(20)).ReturnsAsync(true);

        // Act
        var result = await context.Service.Delete(20);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: lista com registros sem permissão do usuário logado.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByPatient_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new PatientFileServiceContext();

        // Act
        context.Service.SetUserId(2);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync(
        [
            new PatientFile { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } }
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

    // Cenário: consulta de arquivos sem registros.
    // Objetivo: retornar falha de não encontrado após validação de lista vazia.
    [Test]
    public async Task FindAllByPatient_NoRecords_ReturnsNotFoundFailure()
    {
        // Arrange
        var context = new PatientFileServiceContext();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([]);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca por ID sem permissão.
    // Objetivo: retornar falha de permissão no FindByID.
    [Test]
    public async Task FindByID_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new PatientFileServiceContext();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindByID(25)).ReturnsAsync(new PatientFile
        {
            Id = 25,
            PatientId = 5,
            Patient = new Patient { Id = 5, MedicalId = 9 },
            CreatedUser = new User { Id = 7 }
        });
        context.Context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindByID(25);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: consulta de arquivos do paciente autorizada.
    // Objetivo: mapear e retornar a lista de arquivos.
    [Test]
    public async Task FindAllByPatient_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new PatientFileServiceContext();

        // Act
        context.Service.SetUserId(7);
        var patient = new Patient { Id = 5, MedicalId = 9 };
        var file = new PatientFile { Id = 1, PatientId = 5, Patient = patient, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByPatient(5)).ReturnsAsync([file]);
        context.Context.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByPatient(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: busca de arquivo por ID com usuário administrador.
    // Objetivo: mapear e retornar o arquivo encontrado.
    [Test]
    public async Task FindByID_AdminUser_ReturnsMappedResult()
    {
        // Arrange
        var context = new PatientFileServiceContext();

        // Act
        context.Service.SetUserId(1);
        var entity = new PatientFile { Id = 25, PatientId = 5 };
        context.Repository.Setup(x => x.FindByID(25)).ReturnsAsync(entity);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, Admin = true });

        var result = await context.Service.FindByID(25);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: erro inesperado durante a busca por ID.
    // Objetivo: capturar a exceção e retornar falha controlada.
    [Test]
    public async Task FindByID_RepositoryThrows_ReturnsControlledFailure()
    {
        // Arrange
        var context = new PatientFileServiceContext();
        context.Repository.Setup(x => x.FindByID(It.IsAny<long>())).ThrowsAsync(new InvalidOperationException("boom"));

        // Act
        var result = await context.Service.FindByID(26);

        // Assert
        result.Success.Should().BeFalse();
    }

    private static Microsoft.AspNetCore.Http.FormFile CreateFormFile()
    {
        var content = new byte[] { 1, 2, 3 };
        var stream = new MemoryStream(content);
        return new Microsoft.AspNetCore.Http.FormFile(stream, 0, content.Length, "file", "exam.pdf")
        {
            Headers = new Microsoft.AspNetCore.Http.HeaderDictionary(),
            ContentType = "application/pdf"
        };
    }

    private sealed class PatientFileServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IPatientFileRepository> Repository { get; } = new();
        public Mock<IValidator<PatientFile>> Validator { get; } = new();
        public Mock<IFileManagerService> FilePersistor { get; } = new();
        public Mock<IPatientRepository> PatientRepository { get; } = new();
        public PatientFileService Service { get; }

        public PatientFileServiceContext()
        {
            Service = new PatientFileService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                Validator.Object,
                FilePersistor.Object,
                PatientRepository.Object);
        }
    }
}
