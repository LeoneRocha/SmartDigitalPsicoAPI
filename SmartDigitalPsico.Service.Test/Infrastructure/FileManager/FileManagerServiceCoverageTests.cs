using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Service.Infrastructure.FileManager;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;

namespace SmartDigitalPsico.Service.Test.Infrastructure.FileManager;
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;

[TestFixture]
public class FileManagerServiceCoverageTests
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
        disk.Setup(value => value.Save(It.IsAny<FileData>())).ReturnsAsync(true);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        azure.Setup(value => value.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto>())).ReturnsAsync("https://files/item");
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
        disk.Verify(value => value.Save(It.IsAny<FileData>()), Times.Once);

        var cloudEntity = new MedicalFile();
        var cloudManager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);
        await cloudManager.PersistFile(file, cloudEntity, "medical", "42");
        cloudEntity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.CloudStorageAzure);
        cloudEntity.FilePath.Should().Be("https://files/item");
        cloudEntity.FileData.Should().BeEmpty();
        azure.Verify(value => value.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto>()), Times.Once);
        disk.Verify(value => value.Delete(It.IsAny<FileData>()), Times.Once);
    }

    // Cenário: download e exclusão em disco e Azure, inclusive entidade nula.
    // Objetivo: exercitar DownloadFileById e DeleteFile nos caminhos de localização.
    [Test]
    public async Task DownloadAndDeleteFile_UseDiskAndAzureWhenLocationsMatch()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync([7, 8]);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        var diskManager = CreateManager(ETypeLocationSaveFiles.Disk, disk, azure);
        var diskEntity = new MedicalFile { FileName = "disk.txt", Description = "disk.txt", FilePath = Path.Combine(_temporaryDirectory, "disk.txt"), TypeLocationSaveFile = ETypeLocationSaveFiles.Disk };

        // Act
        (await diskManager.DownloadFileById(diskEntity, "42"))!.FileData.Should().Equal(7, 8);
        (await diskManager.DeleteFile(diskEntity, "42")).Should().BeTrue();

        // Assert
        disk.Verify(value => value.Delete(It.IsAny<FileData>()), Times.Once);

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
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
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
            disk.Verify(value => value.Get(It.IsAny<FileData>()), Times.Never);
        }
    }

    // Cenário: diretório temporário inexistente no download Azure.
    // Objetivo: criar o caminho e baixar o arquivo do blob.
    [Test]
    public async Task CloudDownload_NonExistentDirectory_CreatesPathAndDownloads()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync([9, 8, 7]);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        azure.Setup(a => a.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.CompletedTask);
        var nestedRoot = Path.Combine(_temporaryDirectory, "nested-root");
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = nestedRoot })
            .Build();
        var manager = new FileManagerService(configuration, new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.CloudStorageAzure }, disk.Object, azure.Object);
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
        var rootResult = FileManagerService.ResolveDirectoryPath(@"C:\");
        var nestedResult = FileManagerService.ResolveDirectoryPath(nestedPath);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            rootResult.Should().BeEmpty();
            nestedResult.Should().NotBeEmpty();
        }
    }

    // Cenário: download Azure com Get do disco retornando null.
    // Objetivo: cobrir ramo restante de DownloadFileById com FileData vazio.
    [Test]
    public async Task GetFromDiskNullAndExistingDirectory_CoversRemainingBranches()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(r => r.Get(It.IsAny<FileData>())).ReturnsAsync((byte[]?)null);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        var manager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);
        azure.Setup(a => a.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(Task.CompletedTask);
        var entity = new MedicalFile
        {
            FileName = "dl.txt",
            Description = "dl.txt",
            FileCloudContainer = "c",
            FileBlobName = "b",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        };

        var downloaded = await manager.DownloadFileById(entity, "1");

        downloaded!.FileData.Should().BeEmpty();
    }

    // Cenário: PersistFile em Azure e DownloadFileById com disco preenchido.
    // Objetivo: cobrir coalescência nula nos ramos de save e download cloud.
    [Test]
    public async Task SaveAndCloudDownloadBranches_CoverNullCoalescing()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Save(It.IsAny<FileData>())).ReturnsAsync(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync([1, 2]);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        azure.Setup(a => a.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto>())).ReturnsAsync("https://blob/file");
        azure.Setup(a => a.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.CompletedTask);
        var cloudManager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);
        var file = CreateFormFile("upload.txt", [1, 2, 3]);
        var entity = new MedicalFile();

        await cloudManager.PersistFile(file, entity, "medical", "42");
        var downloaded = await cloudManager.DownloadFileById(new MedicalFile
        {
            FileName = "fresh.txt",
            Description = "fresh.txt",
            FileCloudContainer = "medical",
            FileBlobName = "42/fresh.txt",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        }, "42");

        using (Assert.EnterMultipleScope())
        {
            entity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.CloudStorageAzure);
            downloaded!.FileData.Should().Equal(1, 2);
            disk.Verify(d => d.Save(It.IsAny<FileData>()), Times.Once);
        }
    }

    // Cenário: download de arquivo em banco e Azure (temp existente e novo).
    // Objetivo: cobrir DownloadFileById nos destinos DataBase e CloudStorageAzure.
    [Test]
    public async Task DownloadsDatabaseAndAzureFiles()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync([1, 2, 3]);
        var azure = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter>();
        azure.Setup(value => value.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(async (string _, string __, string path) =>
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                await File.WriteAllBytesAsync(path, [1, 2, 3]);
            });

        var databaseManager = CreateManager(ETypeLocationSaveFiles.DataBase, disk, azure);
        var azureManager = CreateManager(ETypeLocationSaveFiles.CloudStorageAzure, disk, azure);

        var databaseEntity = new MedicalFile
        {
            FileName = "db.txt",
            FileData = [4, 5],
            TypeLocationSaveFile = ETypeLocationSaveFiles.DataBase
        };

        (await databaseManager.DownloadFileById(databaseEntity, "42"))!.FileName.Should().Be("db.txt");

        var existingDownloadPath = Path.Combine(_temporaryDirectory, "ResourcesFileSave", "medical", "42", "temp", "cloud.txt");
        Directory.CreateDirectory(Path.GetDirectoryName(existingDownloadPath)!);
        await File.WriteAllBytesAsync(existingDownloadPath, [9]);
        var existingTemp = Path.Combine(_temporaryDirectory, "cloud.txt");
        await File.WriteAllBytesAsync(existingTemp, [8]);

        var cloudEntity = new MedicalFile
        {
            FileName = "cloud.txt",
            Description = "cloud.txt",
            FileCloudContainer = "medical",
            FileBlobName = "42/cloud.txt",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        };
        (await azureManager.DownloadFileById(cloudEntity, "42"))!.FileData.Should().Equal(1, 2, 3);

        var freshCloud = new MedicalFile
        {
            FileName = "fresh-cloud.txt",
            Description = "fresh-cloud.txt",
            FileCloudContainer = "medical",
            FileBlobName = "99/fresh-cloud.txt",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        };
        (await azureManager.DownloadFileById(freshCloud, "99"))!.FileData.Should().Equal(1, 2, 3);

        azure.Verify(value => value.DownloadFile("medical", It.IsAny<string>(), It.IsAny<string>()), Times.Exactly(2));
    }

    private FileManagerService CreateManager(ETypeLocationSaveFiles location, Mock<IFileDiskRepository> disk, Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter> azure)
    {
        var settings = new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto { TypeLocationSaveFiles = location };
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _temporaryDirectory })
            .Build();
        return new FileManagerService(configuration, settings, disk.Object, azure.Object);
    }

    private static FormFile CreateFormFile(string name, byte[] bytes)
    {
        var stream = new MemoryStream(bytes);
        return new FormFile(stream, 0, bytes.Length, "file", name);
    }
}
