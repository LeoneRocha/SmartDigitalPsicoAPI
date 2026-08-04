using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class FileManagerCoverageTests
{
    private string _temporaryDirectory = null!;

    [SetUp]
    public void SetUp() => _temporaryDirectory = Path.Combine(Path.GetTempPath(), $"file-manager-{Guid.NewGuid():N}");

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_temporaryDirectory))
            Directory.Delete(_temporaryDirectory, recursive: true);
    }

    // Cenário: persistência configurada para banco, disco e Azure.
    // Objetivo: gravar o arquivo no destino correto conforme TypeLocationSaveFiles.
    [Test]
    public async Task PersistFile_UsesConfiguredStorageDestination()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Save(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>())).ReturnsAsync(true);
        var azure = new Mock<IStorageBlobAdapter>();
        azure.Setup(value => value.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Domain.Security.BlobFileDto>())).ReturnsAsync("https://files/item");
        var file = CreateFormFile("note.txt", [1, 2, 3]);

        var databaseEntity = new MedicalFile();
        var database = CreateManager(ETypeLocationSaveFiles.DataBase, disk, azure);

        // Act
        (await database.PersistFile(file, databaseEntity, "medical", "42")).Should().NotBeEmpty();

        // Assert
        databaseEntity.FileData.Should().Equal(1, 2, 3);
        databaseEntity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.DataBase);

        var diskEntity = new MedicalFile();
        var diskManager = CreateManager(ETypeLocationSaveFiles.Disk, disk, azure);
        await diskManager.PersistFile(file, diskEntity, "medical", "42");
        diskEntity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.Disk);
        disk.Verify(value => value.Save(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>()), Times.Once);

        var cloudEntity = new MedicalFile();
        var cloudManager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);
        await cloudManager.PersistFile(file, cloudEntity, "medical", "42");
        cloudEntity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.CloudStorageAzure);
        cloudEntity.FilePath.Should().Be("https://files/item");
        cloudEntity.FileData.Should().BeEmpty();
        azure.Verify(value => value.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Domain.Security.BlobFileDto>()), Times.Once);
        disk.Verify(value => value.Delete(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>()), Times.Once);
    }

    // Cenário: download e exclusão em disco e Azure, inclusive entidade nula.
    // Objetivo: exercitar DownloadFileById e DeleteFile nos caminhos de localização.
    [Test]
    public async Task DownloadAndDeleteFile_UseDiskAndAzureWhenLocationsMatch()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Get(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>())).ReturnsAsync([7, 8]);
        var azure = new Mock<IStorageBlobAdapter>();
        var diskManager = CreateManager(ETypeLocationSaveFiles.Disk, disk, azure);
        var diskEntity = new MedicalFile { FileName = "disk.txt", Description = "disk.txt", FilePath = Path.Combine(_temporaryDirectory, "disk.txt"), TypeLocationSaveFile = ETypeLocationSaveFiles.Disk };

        // Act
        (await diskManager.DownloadFileById(diskEntity, "42"))!.FileData.Should().Equal(7, 8);
        (await diskManager.DeleteFile(diskEntity, "42")).Should().BeTrue();

        // Assert
        disk.Verify(value => value.Delete(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>()), Times.Once);

        var azureManager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);
        var cloudEntity = new MedicalFile { FileName = "cloud.txt", FileCloudContainer = "medical", FileBlobName = "42/cloud.txt", TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure };
        (await azureManager.DeleteFile(cloudEntity, "42")).Should().BeTrue();
        azure.Verify(value => value.DeleteBlobAsync("medical", "42/cloud.txt"), Times.Once);

        (await diskManager.DownloadFileById(null!, "42")).Should().BeNull();
        (await diskManager.DeleteFile(null!, "42")).Should().BeTrue();
    }

    // Cenário: arquivo nulo na persistência e download de banco sem match de tipo.
    // Objetivo: cobrir ramos restantes de PersistFile e DownloadFileById.
    [Test]
    public async Task PersistFile_NullFile_ReturnsEmptyAndDatabaseDownloadMismatch()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        var azure = new Mock<IStorageBlobAdapter>();
        var diskManager = CreateManager(ETypeLocationSaveFiles.Disk, disk, azure);
        var databaseManager = CreateManager(ETypeLocationSaveFiles.DataBase, disk, azure);
        var entity = new MedicalFile
        {
            FileName = "db.txt",
            FileData = [1],
            TypeLocationSaveFile = ETypeLocationSaveFiles.DataBase
        };

        // Act
        var folder = await diskManager.PersistFile(null, entity, "medical", "42");
        var downloaded = await diskManager.DownloadFileById(entity, "42");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            folder.Should().BeEmpty();
            downloaded.Should().BeSameAs(entity);
            disk.Verify(value => value.Get(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>()), Times.Never);
        }
    }

    // Cenário: diretório temporário inexistente no download Azure.
    // Objetivo: criar o caminho e baixar o arquivo do blob.
    [Test]
    public async Task CloudDownload_NonExistentDirectory_CreatesPathAndDownloads()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Get(It.IsAny<SmartDigitalPsico.Domain.ModelEntity.Contracts.FileData>())).ReturnsAsync([9, 8, 7]);
        var azure = new Mock<IStorageBlobAdapter>();
        azure.Setup(a => a.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.CompletedTask);
        var nestedRoot = Path.Combine(_temporaryDirectory, "nested-root");
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = nestedRoot })
            .Build();
        var manager = new FileManager(configuration, new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.CloudStorageAzure }, disk.Object, azure.Object);
        var entity = new MedicalFile
        {
            FileName = "cloud-dl.txt",
            Description = "cloud-dl.txt",
            FileCloudContainer = "medical",
            FileBlobName = "42/cloud-dl.txt",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        };

        // Act
        var downloaded = await manager.DownloadFileById(entity, "42");
        var tempDir = Path.Combine(nestedRoot, "ResourcesFileSave", "medical", "42", "temp");
        Directory.Exists(tempDir).Should().BeTrue();
        await File.WriteAllBytesAsync(Path.Combine(tempDir, "cloud-dl.txt"), [0]);
        var downloadedAgain = await manager.DownloadFileById(entity, "42");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            downloaded!.FileData.Should().Equal(9, 8, 7);
            downloadedAgain!.FileData.Should().Equal(9, 8, 7);
            azure.Verify(a => a.DownloadFile("medical", "42/cloud-dl.txt", It.IsAny<string>()), Times.Exactly(2));
        }
    }

    // Cenário: Path.GetDirectoryName retorna null (raiz) ou caminho válido.
    // Objetivo: cobrir coalesce de ResolveDirectoryPath.
    [Test]
    public void ResolveDirectoryPath_RootAndNested_CoversNullCoalesce()
    {
        // Arrange
        var nestedPath = Path.Combine(_temporaryDirectory, "a", "b.txt");

        // Act
        var rootResult = FileManager.ResolveDirectoryPath(@"C:\");
        var nestedResult = FileManager.ResolveDirectoryPath(nestedPath);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            rootResult.Should().BeEmpty();
            nestedResult.Should().NotBeEmpty();
        }
    }

    private FileManager CreateManager(ETypeLocationSaveFiles location, Mock<IFileDiskRepository> disk, Mock<IStorageBlobAdapter> azure)
    {
        var settings = new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = location };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _temporaryDirectory })
            .Build();
        return new FileManager(configuration, settings, disk.Object, azure.Object);
    }

    private static IFormFile CreateFormFile(string name, byte[] bytes)
    {
        var stream = new MemoryStream(bytes);
        return new FormFile(stream, 0, bytes.Length, "file", name);
    }
}
