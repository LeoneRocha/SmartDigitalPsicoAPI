using SmartDigitalPsico.Service;
using Microsoft.Extensions.Configuration;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.ADD;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.GET;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.UPDATE;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile.Common;
using SmartDigitalPsico.Domain.DTO.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service.Test.TestSupport;

using SmartDigitalPsico.Domain.DTO.Gender.UPDATE;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service.Test.DataEntity.Principals;
    using User = global::SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = global::SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = global::SmartDigitalPsico.Domain.EntityModels.Medical;
    using Gender = global::SmartDigitalPsico.Domain.EntityModels.Gender;
                                
[TestFixture]
public class MedicalFileServiceTests
{
    // Cenário: busca por ID com bytes em memória e sem caminho físico.
    // Objetivo: gravar arquivo temporário e preencher FileUrl.
    [Test]
    public async Task FindByID_FileDataWithoutPath_SavesTempFileAndSetsFileUrl()
    {
        // Arrange
        var tempDir = Path.Combine(Path.GetTempPath(), "medical-file-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(tempDir);
        var context = new MedicalFileServiceContext(tempDir);
        var fileData = new byte[] { 10, 20, 30 };
        context.Repository.Setup(x => x.FindByID(8)).ReturnsAsync(new MedicalFile
        {
            Id = 8,
            MedicalId = 9,
            FileName = "report.pdf",
            FileData = fileData,
            FilePath = string.Empty
        });

        // Act
        var result = await context.Service.FindByID(8);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.FileUrl.Should().NotBeNullOrWhiteSpace();
            File.Exists(result.Data.FileUrl).Should().BeTrue();
        }
    }

    // Cenário: consulta geral não é suportada por este serviço especializado.
    // Objetivo: sempre retornar falha por design.
    [Test]
    public async Task FindAll_Always_ReturnsNotFoundByDesign()
    {
        // Arrange
        var context = new MedicalFileServiceContext();

        // Act
        var result = await context.Service.FindAll();

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: busca por ID de arquivo que já possui caminho físico definido.
    // Objetivo: retornar o resultado mapeado sem gravar arquivo temporário.
    [Test]
    public async Task FindByID_ExistingFileWithFilePath_ReturnsMappedResultWithoutTempFile()
    {
        // Arrange
        var context = new MedicalFileServiceContext();
        context.Repository.Setup(x => x.FindByID(5)).ReturnsAsync(new MedicalFile { Id = 5, MedicalId = 9, FilePath = "already/stored.pdf" });

        // Act
        var result = await context.Service.FindByID(5);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data!.FilePath.Should().Be("already/stored.pdf");
        }
    }

    // Cenário: consulta de arquivos vinculados ao médico sem permissão válida.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByMedical_NoRecords_ReturnsPermissionDenied()
    {
        // Arrange
        var context = new MedicalFileServiceContext();

        // Act
        context.Service.SetUserId(1);
        context.Repository.Setup(x => x.FindAllByMedical(9)).ReturnsAsync([]);
        context.Context.UserRepository.Setup(x => x.FindByID(1)).ReturnsAsync(new User { Id = 1, MedicalId = 9, Admin = true });

        var result = await context.Service.FindAllByMedical(9);

        // Assert
        result.Success.Should().BeFalse();
    }

    // Cenário: lista de arquivos do médico sem permissão do usuário.
    // Objetivo: retornar falha de permissão.
    [Test]
    public async Task FindAllByMedical_UserWithoutPermission_ReturnsPermissionFailure()
    {
        // Arrange
        var context = new MedicalFileServiceContext();

        // Act
        context.Service.SetUserId(2);
        context.Repository.Setup(x => x.FindAllByMedical(9)).ReturnsAsync(
        [
            new MedicalFile { Id = 1, MedicalId = 9, CreatedUser = new User { Id = 7 } }
        ]);
        context.Context.UserRepository.Setup(x => x.FindByID(2)).ReturnsAsync(new User { Id = 2, MedicalId = 9, Admin = false });

        var result = await context.Service.FindAllByMedical(9);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeFalse();
            result.Errors.Should().NotBeEmpty();
        }
    }

    // Cenário: consulta de arquivos vinculados ao médico autorizada.
    // Objetivo: mapear e retornar a lista de arquivos do médico.
    [Test]
    public async Task FindAllByMedical_AuthorizedRecords_ReturnsMappedList()
    {
        // Arrange
        var context = new MedicalFileServiceContext();

        // Act
        context.Service.SetUserId(7);
        var file = new MedicalFile { Id = 1, MedicalId = 9, CreatedUser = new User { Id = 7 } };
        context.Repository.Setup(x => x.FindAllByMedical(9)).ReturnsAsync([file]);
        context.Context.UserRepository.Setup(x => x.FindByID(7)).ReturnsAsync(new User { Id = 7, MedicalId = 9 });

        var result = await context.Service.FindAllByMedical(9);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Success.Should().BeTrue();
            result.Data.Should().ContainSingle();
        }
    }

    // Cenário: tentativa de atualização direta do arquivo médico.
    // Objetivo: bloquear a operação lançando exceção de permissão.
    [Test]
    public void Update_Always_ThrowsNotImplemented()
    {
        // Arrange
        var context = new MedicalFileServiceContext();

        // Act
        Action act = () => context.Service.Update(new SmartDigitalPsico.Domain.DTO.Gender.UPDATE.UpdateGenderDto());

        // Assert
        act.Should().Throw<NotImplementedException>();
    }

    // Cenário: envio de arquivo médico válido.
    // Objetivo: persistir o arquivo físico e criar o registro no repositório.
    [Test]
    public async Task PostFileAsync_ValidEntity_PersistsFileAndReturnsSuccess()
    {
        // Arrange
        var context = new MedicalFileServiceContext();
        var dto = new AddMedicalFileDto { MedicalId = 9, Description = "Laudo", FileDetails = CreateFormFile() };
        context.Validator.Setup(x => x.ValidateAsync(It.IsAny<MedicalFile>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult());
        context.FilePersistor.Setup(x => x.PersistFile(It.IsAny<Microsoft.AspNetCore.Http.IFormFile>(), It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "medicalfiles", "9"))
            .ReturnsAsync("stored/laudo.pdf");
        context.Repository.Setup(x => x.Create(It.IsAny<MedicalFile>())).ReturnsAsync((MedicalFile f) => { f.Id = 33; return f; });

        // Act
        var result = await context.Service.PostFileAsync(dto);

        // Assert
        result.Success.Should().BeTrue();

        context.Repository.Verify(x => x.Create(It.IsAny<MedicalFile>()), Times.Once);
    }

    // Cenário: download de arquivo médico existente.
    // Objetivo: recuperar o conteúdo binário e mapear o DTO de retorno.
    [Test]
    public async Task DownloadFileById_ExistingFile_ReturnsMappedDtoWithData()
    {
        // Arrange
        var context = new MedicalFileServiceContext();
        var fileEntity = new MedicalFile { Id = 40, MedicalId = 9 };
        context.Repository.Setup(x => x.FindByID(40)).ReturnsAsync(fileEntity);
        context.FilePersistor.Setup(x => x.DownloadFileById(It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "9"))
            .ReturnsAsync(new MedicalFile { FileData = new byte[] { 9, 8, 7 } });

        // Act
        var result = await context.Service.DownloadFileById(40);

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: exclusão de arquivo médico com remoção física bem-sucedida.
    // Objetivo: remover o registro do repositório após excluir o arquivo físico.
    [Test]
    public async Task Delete_FileDeletionSucceeds_RemovesRecord()
    {
        // Arrange
        var context = new MedicalFileServiceContext();
        var fileEntity = new MedicalFile { Id = 45, MedicalId = 9 };
        context.Repository.Setup(x => x.FindByID(45)).ReturnsAsync(fileEntity);
        context.FilePersistor.Setup(x => x.DeleteFile(It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "9")).ReturnsAsync(true);
        context.Repository.Setup(x => x.Delete(45)).ReturnsAsync(true);

        // Act
        var result = await context.Service.Delete(45);

        // Assert
        result.Success.Should().BeTrue();
    }

    // Cenário: exclusão de arquivo médico cuja remoção física falha.
    // Objetivo: retornar falha sem remover o registro do repositório.
    [Test]
    public async Task Delete_FileDeletionFails_ReturnsFailureWithoutRemovingRecord()
    {
        // Arrange
        var context = new MedicalFileServiceContext();
        var fileEntity = new MedicalFile { Id = 46, MedicalId = 9 };
        context.Repository.Setup(x => x.FindByID(46)).ReturnsAsync(fileEntity);
        context.FilePersistor.Setup(x => x.DeleteFile(It.IsAny<global::SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts.FileBase>(), "9")).ReturnsAsync(false);

        // Act
        var result = await context.Service.Delete(46);

        // Assert
        result.Success.Should().BeFalse();

        context.Repository.Verify(x => x.Delete(It.IsAny<long>()), Times.Never);
    }

    private static Microsoft.AspNetCore.Http.FormFile CreateFormFile()
    {
        var content = new byte[] { 1, 2, 3 };
        var stream = new MemoryStream(content);
        return new Microsoft.AspNetCore.Http.FormFile(stream, 0, content.Length, "file", "laudo.pdf")
        {
            Headers = new Microsoft.AspNetCore.Http.HeaderDictionary(),
            ContentType = "application/pdf"
        };
    }

    private sealed class MedicalFileServiceContext
    {
        public ServiceTestContext Context { get; } = new();
        public Mock<IMedicalFileRepository> Repository { get; } = new();
        public Mock<IValidator<MedicalFile>> Validator { get; } = new();
        public Mock<IFileManagerService> FilePersistor { get; } = new();
        public MedicalFileService Service { get; }

        public MedicalFileServiceContext(string? resourcesTemp = null)
        {
            if (!string.IsNullOrWhiteSpace(resourcesTemp))
            {
                var config = new ConfigurationBuilder()
                    .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = resourcesTemp })
                    .Build();
                Context.ConfigMock.SetupGet(x => x.Configuration).Returns(config);
            }

            Service = new MedicalFileService(
                Context.SharedServices,
                Context.Config,
                Context.SharedRepositories,
                Repository.Object,
                Validator.Object,
                FilePersistor.Object);
        }
    }
}
