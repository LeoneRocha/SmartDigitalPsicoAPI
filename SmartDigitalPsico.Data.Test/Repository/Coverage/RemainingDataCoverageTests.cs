using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Data.Context.Configure;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Data.Repository.Infrastructure;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.Schedule;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class RemainingDataCoverageTests : BaseTests
{
    private string _temporaryDirectory = null!;

    [SetUp]
    public override void Setup()
    {
        base.Setup();
        _temporaryDirectory = Path.Combine(Path.GetTempPath(), $"remaining-data-{Guid.NewGuid():N}");
        Directory.CreateDirectory(_temporaryDirectory);
    }

    [TearDown]
    public void CleanupTemp()
    {
        if (Directory.Exists(_temporaryDirectory))
            Directory.Delete(_temporaryDirectory, recursive: true);
    }

    [Test]
    public async Task FileDiskRepository_SaveNullDataAndExistsMiss_ReturnExpectedResults()
    {
        // Arrange
        var repository = new FileDiskRepository();
        var path = Path.Combine(_temporaryDirectory, "nested", "file.bin");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        await File.WriteAllBytesAsync(path, [1, 2]);

        // Act
        var saveResult = await repository.Save(new FileData { FileData = null });
        var byCombined = await repository.Get(new FileData { FilePath = _temporaryDirectory, FileName = "missing.bin" });
        var exists = repository.Exists(new FileData { FilePath = _temporaryDirectory, FileName = "missing.bin" });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            saveResult.Should().BeFalse();
            byCombined.Should().BeEmpty();
            exists.Should().BeFalse();
        }
    }

    [Test]
    public async Task DiskCacheRepository_DefaultDeserializedValue_ReturnsMiss()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var cache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        // Act
        var result = await cache.TryGetAsync<CachePayload>("default-null");

        // Assert
        result.Key.Should().BeFalse();
    }

    [Test]
    public async Task NotificationTemplate_FallbackLanguage_ReturnsPtBrOrFirst()
    {
        _mockContext!.NotificationTemplates.AddRange(
            new NotificationTemplate { TemplateKey = "welcome", Language = "pt-BR", Enable = true },
            new NotificationTemplate { TemplateKey = "welcome", Language = "es-ES", Enable = true });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        var ptFallback = await repository.GetNotificationTemplateAsync("welcome", "en-US");
        var first = await repository.GetNotificationTemplateAsync("missing", "en-US");

        using (Assert.EnterMultipleScope())
        {
            ptFallback!.Language.Should().Be("pt-BR");
            first.Should().BeNull();
        }
    }

    [Test]
    public async Task RoleGroupRepository_NullIds_ReturnsEmptyList()
    {
        var repository = new RoleGroupRepository(_mockContext!);
        (await repository.FindByIDs(null)).Should().BeEmpty();
    }

    [Test]
    public async Task FileDiskRepository_ExistsAndGetPathBranches_AreCovered()
    {
        // Arrange
        var repository = new FileDiskRepository();
        var folder = Path.Combine(_temporaryDirectory, "exists");
        var filePath = Path.Combine(folder, "found.bin");
        Directory.CreateDirectory(folder);
        await File.WriteAllBytesAsync(filePath, [3, 4]);
        var byDirectPath = Path.Combine(_temporaryDirectory, "direct-only.bin");
        await File.WriteAllBytesAsync(byDirectPath, [5]);

        // Act
        var exists = repository.Exists(new FileData { FilePath = folder, FileName = "found.bin" });
        var fromCombined = await repository.Get(new FileData { FilePath = folder, FileName = "found.bin" });
        var fromDirect = await repository.Get(new FileData { FilePath = byDirectPath, FileName = "ignored.bin" });
        await repository.Delete(new FileData { FilePath = folder, FileName = "found.bin" });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            exists.Should().BeTrue();
            fromCombined.Should().Equal(3, 4);
            fromDirect.Should().Equal(5);
        }
    }

    [Test]
    public async Task FileManager_GetFromDiskNullAndExistingDirectory_CoversRemainingBranches()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(r => r.Get(It.IsAny<FileData>())).ReturnsAsync((byte[]?)null);
        var azure = new Mock<IStorageBlobAdapter>();
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _temporaryDirectory })
            .Build();
        var manager = new FileManager(configuration, new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.CloudStorageAzure }, disk.Object, azure.Object);
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

        // Act
        var downloaded = await manager.DownloadFileById(entity, "1");

        // Assert
        downloaded!.FileData.Should().BeEmpty();
    }

    [Test]
    public void AuditContextService_ShortJsonAndNonScheduleProperty_CoversSanitizeBranches()
    {
        // Arrange
        var cache = new MemoryCache(new MemoryCacheOptions());
        var options = Options.Create(new CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        });
        var service = new AuditContextService(new MemoryCacheRepository(cache, options));
        var entry = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "T",
            Operation = "M",
            KeyValue = "1",
            OldValues = "{}",
            NewValues = "{}"
        };
        _mockContext!.Set<AuditDataEntityLog>().Add(entry);
        _mockContext.SaveChanges();
        entry.NewValues = "{}";

        // Act
        var truncated = typeof(AuditContextService).GetMethod("TruncateAuditJson", BindingFlags.NonPublic | BindingFlags.Static)!
            .Invoke(null, ["short"]);
        var sanitized = typeof(AuditContextService).GetMethod("SanitizeAuditValue", BindingFlags.NonPublic | BindingFlags.Static)!
            .Invoke(null, ["Name", (object?)"value"]);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            truncated.Should().Be("short");
            sanitized.Should().Be("value");
            service.GetExistingEntries(_mockContext, [entry]).Should().ContainSingle();
        }
    }

    [Test]
    public void AuditContextService_UserIdPropertyBranches_CoversGetUserIdPaths()
    {
        // Arrange
        var cache = new MemoryCache(new MemoryCacheOptions());
        var options = Options.Create(new CacheConfigurationDto { AbsoluteExpirationInHours = 1, SlidingExpirationInMinutes = 1 });
        var service = new AuditContextService(new MemoryCacheRepository(cache, options));
        var longJson = new string('x', 9000);
        var truncated = typeof(AuditContextService).GetMethod("TruncateAuditJson", BindingFlags.NonPublic | BindingFlags.Static)!
            .Invoke(null, [longJson]) as string;
        var entity = new ApplicationCacheLog { CacheId = "k", CacheKey = "v" };
        _mockContext!.ApplicationCacheLogs.Add(entity);
        _mockContext.SaveChanges();
        entity.CacheKey = "changed";
        var entry = _mockContext.Entry(entity);

        // Act
        var entries = service.OnBeforeSaveChanges(_mockContext);
        var getUserId = typeof(AuditContextService).GetMethod("GetUserId", BindingFlags.NonPublic | BindingFlags.Static)!;
        var missingProperty = getUserId.Invoke(null, [entry, "MissingProperty"]);
        var existingProperty = getUserId.Invoke(null, [entry, "CacheId"]);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            truncated.Should().EndWith("...");
            truncated!.Length.Should().Be(8000);
            entries.Should().ContainSingle();
            entries[0].UserAuditedLogin.Should().Be("admin");
            missingProperty.Should().BeNull();
            existingProperty.Should().BeNull();
        }
    }

    [Test]
    public async Task FileManager_SaveAndCloudDownloadBranches_CoverNullCoalescing()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Save(It.IsAny<FileData>())).ReturnsAsync(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync([1, 2]);
        var azure = new Mock<IStorageBlobAdapter>();
        azure.Setup(a => a.UploadFileReturnUrl(It.IsAny<SmartDigitalPsico.Domain.Security.BlobFileDto>())).ReturnsAsync("https://blob/file");
        azure.Setup(a => a.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.CompletedTask);
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _temporaryDirectory })
            .Build();
        var cloudManager = new FileManager(configuration, new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.CloudStorageAzure }, disk.Object, azure.Object);
        var file = new FormFile(new MemoryStream([1, 2, 3]), 0, 3, "file", "upload.txt");
        var entity = new MedicalFile();

        // Act
        await cloudManager.PersistFile(file, entity, "medical", "42");
        var downloaded = await cloudManager.DownloadFileById(new MedicalFile
        {
            FileName = "fresh.txt",
            Description = "fresh.txt",
            FileCloudContainer = "medical",
            FileBlobName = "42/fresh.txt",
            TypeLocationSaveFile = ETypeLocationSaveFiles.CloudStorageAzure
        }, "42");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            entity.TypeLocationSaveFile.Should().Be(ETypeLocationSaveFiles.CloudStorageAzure);
            downloaded!.FileData.Should().Equal(1, 2);
            disk.Verify(d => d.Save(It.IsAny<FileData>()), Times.Once);
        }
    }

    [Test]
    public async Task FileDiskRepository_PathCombinationAndDeleteBranches_CoverAllPaths()
    {
        // Arrange
        var repository = new FileDiskRepository();
        var folder = Path.Combine(_temporaryDirectory, "combo");
        Directory.CreateDirectory(folder);
        var combined = Path.Combine(folder, "child.bin");
        await File.WriteAllBytesAsync(combined, [8]);
        var directOnly = Path.Combine(_temporaryDirectory, "solo.bin");
        await File.WriteAllBytesAsync(directOnly, [9]);

        // Act
        var fromCombined = await repository.Get(new FileData { FilePath = folder, FileName = "child.bin" });
        var fromDirect = await repository.Get(new FileData { FilePath = directOnly, FileName = "ignored.bin" });
        await repository.Delete(new FileData { FilePath = directOnly, FileName = "ignored.bin" });
        var existsInFolder = repository.Exists(new FileData { FilePath = folder, FileName = "child.bin" });

        // Assert
        using (Assert.EnterMultipleScope())
        {
            fromCombined.Should().Equal(8);
            fromDirect.Should().Equal(9);
            existsInFolder.Should().BeTrue();
            File.Exists(directOnly).Should().BeFalse();
        }
    }

    [Test]
    public async Task DiskCacheRepository_ValidDeserializedPayload_ReturnsHit()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("{\"Name\":\"cached\"}"));
        var cache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        // Act
        var result = await cache.TryGetAsync<CachePayload>("valid");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Key.Should().BeTrue();
            result.Value.Name.Should().Be("cached");
        }
    }

    [Test]
    public async Task GenericStorageQueueRepository_DelegatesQueueOperations()
    {
        var adapter = new Mock<IStorageQueueContract>();
        adapter.Setup(value => value.DequeueMessageAsync()).ReturnsAsync("payload");
        var repository = new GenericStorageQueueRepository(adapter.Object, "queue");

        await repository.EnqueueMessageAsync("hello");
        (await repository.DequeueMessageAsync()).Should().Be("payload");
        await repository.DeleteMessageAsync("id", "receipt");

        adapter.Verify(value => value.EnqueueMessageAsync("hello"), Times.Once);
        adapter.Verify(value => value.DeleteMessageAsync("id", "receipt"), Times.Once);
    }

    [Test]
    public void MedicalSettingsRepository_ContextProvided_CreatesInstance()
    {
        new MedicalSettingsRepository(_mockContext!).Should().NotBeNull();
    }

    [Test]
    public void EntityBaseConfiguration_Configure_ThrowsNotImplemented()
    {
        var builder = new ModelBuilder(new ConventionSet()).Entity<ApplicationCacheLog>();
        var configuration = new TestEntityBaseConfiguration(ETypeDataBase.Mysql);

        Action act = () => configuration.Configure(builder);

        act.Should().Throw<NotImplementedException>();
    }

    [Test]
    public async Task ContextOptionsOnlyConstructors_BuildModels()
    {
        var sql = new SmartDigitalPsicoDataContextSqlServer(new DbContextOptionsBuilder<SmartDigitalPsicoDataContextSqlServer>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);
        var mysql = new SmartDigitalPsicoDataContextMySql(new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);

        sql.Model.GetEntityTypes().Should().NotBeEmpty();
        mysql.Model.GetEntityTypes().Should().NotBeEmpty();
        await sql.DisposeAsync();
        await mysql.DisposeAsync();
    }

    [Test]
    public async Task ApplicationLanguage_ExistLanguage_ReturnsMatchingFlag()
    {
        var language = new ApplicationLanguage { Language = "pt-BR", LanguageKey = "Welcome", ResourceKey = "SharedResource", Description = "Oi" };
        _mockContext!.ApplicationLanguages.Add(language);
        await _mockContext.SaveChangesAsync();
        var repository = new ApplicationLanguageRepository(_mockContext);

        (await repository.ExistLanguage("pt-BR", "Welcome")).Should().BeTrue();
        (await repository.ExistLanguage("en-US", "Welcome")).Should().BeFalse();
    }

    [Test]
    public async Task NotificationTemplate_MatchingLanguage_ReturnsExactTemplate()
    {
        _mockContext!.NotificationTemplates.Add(new NotificationTemplate
        {
            TemplateKey = "appointment",
            Language = "en-US",
            Enable = true
        });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        var result = await repository.GetNotificationTemplateAsync("appointment", "en-US");

        result.Should().NotBeNull();
        result!.Language.Should().Be("en-US");
    }

    [Test]
    public async Task ScheduleCalendar_GetByTokenFromStart_FiltersSubjectKey()
    {
        var now = DateTime.UtcNow.Date.AddHours(8);
        _mockContext!.ScheduleCalendars.Add(new ScheduleCalendar
        {
            TenantKey = "tenant",
            OwnerKey = "owner",
            SubjectKey = "subject",
            UniqueToken = "token",
            Enable = true,
            StartPeriod = now,
            EndPeriod = now.AddHours(2),
            ScheduleData = []
        });
        await _mockContext.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(_mockContext);

        (await repository.GetByTokenFromStartAsync("token", "owner", "subject", now)).Should().ContainSingle();
        (await repository.GetByTokenFromStartAsync("token", "owner", "other", now)).Should().BeEmpty();
    }

    [Test]
    public async Task PatientRepository_DetailsAndSearch_ReturnProjectedResults()
    {
        SeedPatientGraph();
        var patient = _mockContext!.Patients.First();
        var repository = new PatientRepository(_mockContext);

        var details = await repository.GetPatientDetailsByIdAsync(patient.Id);
        var search = await repository.PatientSearch(new PatientSearchCriteriaDto
        {
            MedicalId = patient.MedicalId,
            Name = patient.Name[..Math.Min(3, patient.Name.Length)]
        });

        details.Id.Should().Be(patient.Id);
        details.Medical.Should().NotBeNull();
        search.Should().NotBeEmpty();
        search.Should().OnlyContain(item => item.MedicalId == 0 || item.Id > 0);
    }

    [Test]
    public async Task UserRepository_DeleteAndNegativePaths_AreCovered()
    {
        SeedUserGraph();
        var repository = new UserRepository(_mockContext!);
        var user = _mockContext!.Users.OrderBy(item => item.Id).First();

        (await repository.UserExists("missing-login")).Should().BeFalse();
        (await repository.RefreshUserInfo(new User { Id = 999999 })).Id.Should().Be(0);
        (await repository.Delete(user.Id)).Should().BeTrue();
        (await repository.Delete(999999)).Should().BeTrue();
    }

    [Test]
    public async Task FileDiskRepository_DeletesDirectFilePathAndCacheMissBranches()
    {
        var repository = new FileDiskRepository();
        var directFile = Path.Combine(_temporaryDirectory, "direct.bin");
        await File.WriteAllBytesAsync(directFile, [9, 9]);
        await repository.Delete(new FileData { FilePath = directFile, FileName = "ignored.bin" });
        File.Exists(directFile).Should().BeFalse();

        var cache = new DiskCacheRepository(repository, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Exists(It.IsAny<FileData>())).Returns(true);
        disk.SetupSequence(value => value.Get(It.IsAny<FileData>()))
            .ReturnsAsync((byte[]?)null)
            .ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var missCache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));
        (await missCache.TryGetAsync<CachePayload>("null-bytes")).Key.Should().BeFalse();
        (await missCache.TryGetAsync<CachePayload>("json-null")).Key.Should().BeFalse();
        (await cache.TryGetAsync<CachePayload>("missing")).Key.Should().BeFalse();
    }

    [Test]
    public async Task FileDiskRepository_DetectsCorruptedWriteDuringVerification()
    {
        var repository = new FileDiskRepository();
        Exception? failure = null;
        for (var attempt = 0; attempt < 30 && failure is null; attempt++)
        {
            var payload = new byte[512 * 1024];
            Array.Fill(payload, (byte)7);
            var criteria = new FileData
            {
                FolderDestination = _temporaryDirectory,
                FilePath = _temporaryDirectory,
                FileName = $"race-{attempt}.bin",
                FileData = payload
            };

            using var cts = new CancellationTokenSource();
            var mutator = Task.Run(() =>
            {
                while (!cts.IsCancellationRequested)
                    payload[Random.Shared.Next(payload.Length)] = (byte)Random.Shared.Next(1, 255);
            }, cts.Token);

            try
            {
                await repository.Save(criteria);
            }
            catch (Exception ex)
            {
                failure = ex;
            }
            finally
            {
                cts.Cancel();
                try { await mutator; } catch (OperationCanceledException) { }
            }
        }

        failure.Should().BeOfType<InvalidOperationException>();
    }

    [Test]
    public async Task FileDiskRepository_DetectsIncompleteRead()
    {
        var repository = new FileDiskRepository();
        Exception? failure = null;
        for (var attempt = 0; attempt < 80 && failure is null; attempt++)
        {
            var path = Path.Combine(_temporaryDirectory, $"partial-{attempt}.bin");
            await using (var create = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                var buffer = new byte[1024 * 1024];
                for (var i = 0; i < 48; i++)
                    await create.WriteAsync(buffer);
            }

            using var truncate = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            var readTask = Task.Run(async () => await repository.Get(new FileData { FilePath = path, FileName = "ignored" }));
            while (!readTask.IsCompleted)
            {
                truncate.SetLength(1);
                truncate.Flush();
                truncate.SetLength(0);
                truncate.Flush();
                await Task.Yield();
            }

            try
            {
                await readTask;
            }
            catch (Exception ex)
            {
                if (ex is IOException && ex.Message == "Could not read the entire file.")
                    failure = ex;
            }
        }

        failure.Should().NotBeNull();
        failure!.Message.Should().Be("Could not read the entire file.");
    }

    [Test]
    public async Task UserRepository_RefreshUserInfo_WhenLookupMissesAfterExists_ReturnsEmptyUser()
    {
        var context = new Mock<SmartDigitalPsico.Data.Context.Interface.IEntityDataContext>();
        var provider = new FlipAsyncQueryProvider();
        var users = new FlipAsyncQueryable<User>(provider);
        var dbSet = new Mock<DbSet<User>>();
        dbSet.As<IQueryable<User>>().Setup(value => value.Provider).Returns(provider);
        dbSet.As<IQueryable<User>>().Setup(value => value.Expression).Returns(users.Expression);
        dbSet.As<IQueryable<User>>().Setup(value => value.ElementType).Returns(users.ElementType);
        dbSet.As<IQueryable<User>>().Setup(value => value.GetEnumerator()).Returns(users.GetEnumerator());
        dbSet.As<IAsyncEnumerable<User>>().Setup(value => value.GetAsyncEnumerator(It.IsAny<CancellationToken>()))
            .Returns(new FlipAsyncEnumerator<User>(provider));
        context.Setup(value => value.Set<User>()).Returns(dbSet.Object);

        var repository = new UserRepository(context.Object);
        var field = typeof(SmartDigitalPsico.Data.Repository.Generic.GenericRepositoryEntityBase<User>)
            .GetField("_dataset", BindingFlags.Instance | BindingFlags.NonPublic);
        field!.SetValue(repository, dbSet.Object);

        var result = await repository.RefreshUserInfo(new User { Id = 1, Name = "ghost" });

        result.Id.Should().Be(0);
    }

    [Test]
    public async Task FileManager_DownloadsDatabaseAndAzureFiles()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync([1, 2, 3]);
        var azure = new Mock<IStorageBlobAdapter>();
        azure.Setup(value => value.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
            .Returns(async (string _, string __, string path) =>
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                await File.WriteAllBytesAsync(path, [1, 2, 3]);
            });

        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _temporaryDirectory })
            .Build();
        var databaseManager = new FileManager(configuration, new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.DataBase }, disk.Object, azure.Object);
        var azureManager = new FileManager(configuration, new LocationSaveFileConfigurationDto { TypeLocationSaveFiles = ETypeLocationSaveFiles.CloudStorageAzure }, disk.Object, azure.Object);

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

    [Test]
    public async Task AuditInterceptor_PersistsNewEntriesAndAlternateServicePath()
    {
        var persistence = new Mock<IAuditPersistenceService>();
        var factory = new Mock<IAuditPersistenceServiceFactory>();
        factory.Setup(value => value.CreateService(EAuditServiceType.Database)).Returns(persistence.Object);
        var auditService = new Mock<IAuditContextService>();
        auditService.Setup(service => service.OnBeforeSaveChanges(It.IsAny<DbContext>()))
            .Returns(() =>
            [
                new AuditDataEntityLog
                {
                    AuditDate = DateTime.UtcNow,
                    TableName = "ApplicationCacheLog",
                    Operation = "Modified",
                    KeyValue = Guid.NewGuid().ToString("N"),
                    OldValues = "{}",
                    NewValues = "{}"
                }
            ]);
        auditService.Setup(service => service.GetNewEntries(It.IsAny<DbContext>(), It.IsAny<List<AuditDataEntityLog>>()))
            .Returns((DbContext _, List<AuditDataEntityLog> entries) => entries);
        var interceptor = new AuditContextInterceptor(auditService.Object, factory.Object);

        var options = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .AddInterceptors(interceptor)
            .Options;
        await using var context = new SmartDigitalPsicoDataContextMySql(options, interceptor);
        context.ApplicationCacheLogs.Add(new ApplicationCacheLog { CacheId = "audit", CacheKey = "key" });
        await context.SaveChangesAsync();
        context.ApplicationCacheLogs.First().CacheKey = "changed";
        context.SaveChanges();

        auditService.Setup(service => service.GetNewEntries(It.IsAny<DbContext>(), It.IsAny<List<AuditDataEntityLog>>()))
            .Returns([]);
        context.ApplicationCacheLogs.First().CacheKey = "changed-again";
        await context.SaveChangesAsync();
        context.ApplicationCacheLogs.First().CacheKey = "changed-sync-empty";
        context.SaveChanges();

        typeof(AuditContextInterceptor).GetField("_serviceType", BindingFlags.Instance | BindingFlags.NonPublic)!
            .SetValue(interceptor, EAuditServiceType.Log);
        auditService.Setup(service => service.GetNewEntries(It.IsAny<DbContext>(), It.IsAny<List<AuditDataEntityLog>>()))
            .Returns((DbContext _, List<AuditDataEntityLog> entries) => entries);
        context.ApplicationCacheLogs.First().CacheKey = "log-path";
        context.SaveChanges();
        await context.SaveChangesAsync();
        persistence.Verify(service => service.SaveAuditEntries(It.IsAny<IEnumerable<AuditDataEntityLog>>()), Times.AtLeastOnce);
    }

    [Test]
    public void AuditContextService_CoversUserSanitizeAndTruncateBranches()
    {
        var patient = PatientMockHelper.GetMock().First();
        patient.CreatedUserId = 10;
        patient.ModifyUserId = null;
        _mockContext!.Users.AddRange(UserMockHelper.GetMock());
        _mockContext.Medicals.AddRange(MedicalMockHelper.GetMock());
        _mockContext.Genders.AddRange(GenderMockHelper.GetMock());
        _mockContext.Patients.Add(patient);
        _mockContext.SaveChanges();
        var patientWithoutUser = new Patient
        {
            Name = "No User",
            Cpf = "00000000000",
            Rg = "0000000",
            Email = "nouser@test.local",
            MedicalId = patient.MedicalId,
            GenderId = patient.GenderId,
            CreatedUserId = null,
            ModifyUserId = null
        };
        _mockContext.Patients.Add(patientWithoutUser);
        var schedule = new ScheduleCalendar
        {
            TenantKey = "tenant",
            OwnerKey = "owner",
            UniqueToken = "token",
            Enable = true,
            StartPeriod = DateTime.UtcNow,
            EndPeriod = DateTime.UtcNow.AddHours(1),
            ScheduleData =
            [
                new ScheduleCalendarItem { Title = "item", StartDateTime = DateTime.UtcNow, EndDateTime = DateTime.UtcNow.AddMinutes(30) }
            ]
        };
        _mockContext.ScheduleCalendars.Add(schedule);
        var cache = new ApplicationCacheLog { CacheId = "long", CacheKey = "short" };
        _mockContext.ApplicationCacheLogs.Add(cache);
        _mockContext.SaveChanges();

        patient.Name = $"{patient.Name}-updated";
        patientWithoutUser.Name = "No User Updated";
        schedule.OwnerKey = "owner-2";
        cache.CacheKey = new string('x', 9000);

        var service = new AuditContextService(new MemoryCacheRepository(new MemoryCache(new MemoryCacheOptions()), Options.Create(new CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        })));
        var entries = service.OnBeforeSaveChanges(_mockContext);

        entries.Should().NotBeEmpty();
        entries.Should().Contain(entry => entry.UserAuditedId == 10);
        entries.Should().Contain(entry => entry.TableName == nameof(Patient) && entry.UserAuditedLogin == "admin");
        entries.Should().Contain(entry => entry.OldValues.Contains("[omitted]") || entry.NewValues.Contains("[omitted]"));
        entries.Should().Contain(entry => entry.NewValues.EndsWith("..."));

        var unmatched = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow.AddMinutes(-10),
            TableName = "Other",
            Operation = "Modified",
            KeyValue = "x",
            OldValues = "{}",
            NewValues = "{}"
        };
        service.GetNewEntries(_mockContext, [unmatched]);
        var current = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "ApplicationCacheLog",
            Operation = "Modified",
            KeyValue = "1",
            OldValues = "{}",
            NewValues = "{}"
        };
        service.GetNewEntries(_mockContext, [current]).Should().ContainSingle();
    }

    [Test]
    public async Task FinalDataBranchGaps_FileAuditSchedulePaths_AreCovered()
    {
        // Arrange
        var emptyTruncate = typeof(AuditContextService).GetMethod("TruncateAuditJson", BindingFlags.NonPublic | BindingFlags.Static)!
            .Invoke(null, [string.Empty]) as string;
        SeedUserGraph();
        var cacheEntity = new ApplicationCacheLog { CacheId = "audit-branch", CacheKey = "v1" };
        _mockContext!.ApplicationCacheLogs.Add(cacheEntity);
        _mockContext.SaveChanges();
        cacheEntity.CacheId = "audit-branch-v2";
        var cacheEntry = _mockContext.Entry(cacheEntity);
        var getKeyValues = typeof(AuditContextService).GetMethod("GetKeyValues", BindingFlags.NonPublic | BindingFlags.Static)!;
        var keyValue = getKeyValues.Invoke(null, [cacheEntry]) as string;

        var fileDisk = new FileDiskRepository();
        var emptyPathFile = Path.Combine(_temporaryDirectory, "direct.bin");
        await File.WriteAllBytesAsync(emptyPathFile, [4, 5]);
        var folderPath = Path.Combine(_temporaryDirectory, "folder-read");
        Directory.CreateDirectory(folderPath);
        await File.WriteAllBytesAsync(Path.Combine(folderPath, "nested.bin"), [6]);

        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var diskCache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        var now = DateTime.UtcNow.Date.AddDays(30).AddHours(10);
        _mockContext.ScheduleCalendars.Add(new ScheduleCalendar
        {
            TenantKey = "tenant",
            OwnerKey = "owner",
            SubjectKey = "subject",
            UniqueToken = "open-end",
            Enable = true,
            StartPeriod = now,
            EndPeriod = now.AddHours(2),
            ScheduleData =
            [
                new ScheduleCalendarItem
                {
                    Title = "open",
                    StartDateTime = now,
                    EndDateTime = null,
                    Status = EStatusCalendar.Confirmed,
                    TimeZone = "UTC",
                    TokenRecurrence = "   "
                }
            ]
        });
        await _mockContext.SaveChangesAsync();
        var scheduleRepository = new ScheduleCalendarRepository(_mockContext);
        var expand = typeof(ScheduleCalendarRepository).GetMethod("ExpandOverlappingItems", BindingFlags.NonPublic | BindingFlags.Static)!;
        var stamp = typeof(ScheduleCalendarRepository).GetMethod("StampPackageMetadata", BindingFlags.NonPublic | BindingFlags.Static)!;
        var nullScheduleItems = (ScheduleCalendarItem[])expand.Invoke(null,
        [
            new ScheduleCalendar[] { new() { UniqueToken = "pkg", ScheduleData = null } },
            now,
            now.AddHours(1)
        ])!;
        var stamped = (ScheduleCalendarItem)stamp.Invoke(null,
        [
            new ScheduleCalendarItem { Title = "x", StartDateTime = now, TokenRecurrence = "" },
            new ScheduleCalendar { UniqueToken = "pkg-token", SubjectKey = "s", OwnerKey = "o" }
        ])!;

        var getUserId = typeof(AuditContextService).GetMethod("GetUserId", BindingFlags.NonPublic | BindingFlags.Static)!;
        var userEntry = _mockContext.Entry(_mockContext.Users.First());
        var sanitize = typeof(AuditContextService).GetMethod("SanitizeAuditValue", BindingFlags.NonPublic | BindingFlags.Static)!;

        // Act
        var userIdValue = getUserId.Invoke(null, [userEntry, "CreatedUserId"]);
        var omitted = sanitize.Invoke(null, ["ScheduleData", (object?)new object()]);
        var fromEmptyPath = await fileDisk.Get(new FileData { FilePath = string.Empty, FileName = "missing.bin" });
        var fromNestedExists = await fileDisk.Get(new FileData { FilePath = folderPath, FileName = "nested.bin" });
        var fromDirectOnly = await fileDisk.Get(new FileData { FilePath = emptyPathFile, FileName = "wrong.bin" });
        fileDisk.Exists(new FileData { FilePath = string.Empty, FileName = "missing.bin" });
        await fileDisk.Delete(new FileData { FilePath = string.Empty, FileName = "missing.bin" });
        var nullCache = await diskCache.TryGetAsync<CachePayload>("null-json");
        var openEndConflict = await scheduleRepository.HasConflictAsync("tenant", "owner", now);
        var subjectItems = await scheduleRepository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject", now, now.AddHours(2));
        var subjectItemsAny = await scheduleRepository.GetItemsForOwnerSubjectAsync("tenant", "owner", null, now, now.AddHours(2));

        // Assert
        using (Assert.EnterMultipleScope())
        {
            emptyTruncate.Should().BeEmpty();
            keyValue.Should().NotBeNullOrEmpty();
            userIdValue.Should().BeNull();
            omitted.Should().Be("[omitted]");
            fromEmptyPath.Should().Equal([]);
            fromNestedExists.Should().Equal(6);
            fromDirectOnly.Should().Equal(4, 5);
            nullCache.Key.Should().BeFalse();
            nullScheduleItems.Should().BeEmpty();
            stamped.TokenRecurrence.Should().Be("pkg-token");
            openEndConflict.Should().BeTrue();
            subjectItems.Should().ContainSingle(i => i.TokenRecurrence == "open-end");
            subjectItemsAny.Should().ContainSingle();
        }
    }

    [Test]
    public async Task FileDiskRepository_GetDirectPathWhenCombinedMissing_CoversElseBranch()
    {
        var repository = new FileDiskRepository();
        var direct = Path.Combine(_temporaryDirectory, "direct-only.bin");
        await File.WriteAllBytesAsync(direct, [3, 4, 5]);

        var fromDirect = await repository.Get(new FileData { FilePath = direct, FileName = "unused.bin" });

        fromDirect.Should().Equal(3, 4, 5);
    }

    [Test]
    public async Task DiskCacheRepository_ValidNonDefaultPayload_ReturnsHitWithValue()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("{\"Name\":\"hit\"}"));
        var cache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        var result = await cache.TryGetAsync<CachePayload>("hit-key");

        using (Assert.EnterMultipleScope())
        {
            result.Key.Should().BeTrue();
            result.Value.Name.Should().Be("hit");
        }
    }

    [Test]
    public async Task ScheduleCalendarRepository_NullableEndDateTimeEdges_CoverConflictFilters()
    {
        var now = DateTime.UtcNow.Date.AddDays(40).AddHours(11);
        _mockContext!.ScheduleCalendars.AddRange(
            new ScheduleCalendar
            {
                TenantKey = "tenant",
                OwnerKey = "owner",
                SubjectKey = "subject-a",
                UniqueToken = "with-token",
                Enable = true,
                StartPeriod = now,
                EndPeriod = now.AddHours(4),
                ScheduleData =
                [
                    new ScheduleCalendarItem
                    {
                        Title = "token-item",
                        StartDateTime = now,
                        EndDateTime = now.AddMinutes(30),
                        Status = EStatusCalendar.Confirmed,
                        TimeZone = "UTC",
                        TokenRecurrence = "custom-token"
                    }
                ]
            },
            new ScheduleCalendar
            {
                TenantKey = "tenant",
                OwnerKey = "owner",
                SubjectKey = "subject-b",
                UniqueToken = "outside-range",
                Enable = true,
                StartPeriod = now,
                EndPeriod = now.AddHours(4),
                ScheduleData =
                [
                    new ScheduleCalendarItem
                    {
                        Title = "late",
                        StartDateTime = now.AddHours(3),
                        EndDateTime = null,
                        Status = EStatusCalendar.Confirmed,
                        TimeZone = "UTC"
                    }
                ]
            });
        await _mockContext.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(_mockContext);

        var conflictOpenEnd = await repository.HasConflictAsync("tenant", "owner", now);
        var subjectItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-a", now, now.AddHours(2));
        var item = await repository.GetItemAsync("tenant", "owner", "subject-a", now);
        var noConflict = await repository.HasConflictAsync("tenant", "owner", now.AddHours(5));

        var conflictMidWindow = await repository.HasConflictAsync("tenant", "owner", now.AddHours(1));
        var outsideSubject = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-b", now, now.AddHours(2));
        var beforeWindow = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-a", now.AddHours(2), now.AddHours(4));

        using (Assert.EnterMultipleScope())
        {
            conflictOpenEnd.Should().BeTrue();
            subjectItems.Should().ContainSingle(i => i.TokenRecurrence == "custom-token");
            item!.TokenRecurrence.Should().Be("custom-token");
            noConflict.Should().BeFalse();
            conflictMidWindow.Should().BeFalse();
            outsideSubject.Should().BeEmpty();
            beforeWindow.Should().BeEmpty();
        }
    }

    [Test]
    public async Task GenericRepository_FindMethods_UseIncludeExpressions()
    {
        SeedPatientGraph();
        var patient = _mockContext!.Patients.First();
        var repository = new PatientRepository(_mockContext);

        (await repository.FindByID(patient.Id, item => item.Gender)).Id.Should().Be(patient.Id);
        (await repository.FindAsync(patient.Id, item => item.Gender))!.Id.Should().Be(patient.Id);
    }

    private void SeedPatientGraph()
    {
        _mockContext!.Users.AddRange(UserMockHelper.GetMock());
        _mockContext.Medicals.AddRange(MedicalMockHelper.GetMock());
        _mockContext.Genders.AddRange(GenderMockHelper.GetMock());
        _mockContext.Patients.AddRange(PatientMockHelper.GetMock().Take(1));
        _mockContext.SaveChanges();
    }

    private void SeedUserGraph()
    {
        _mockContext!.Users.AddRange(UserMockHelper.GetMock().Take(1));
        _mockContext.SaveChanges();
    }

    private sealed class TestEntityBaseConfiguration : EntityBaseConfiguration<ApplicationCacheLog>
    {
        public TestEntityBaseConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase)
        {
        }
    }

    private sealed class CachePayload
    {
        public string Name { get; set; } = string.Empty;
    }

    private sealed class FlipAsyncQueryProvider : IAsyncQueryProvider
    {
        private int _executeCount;

        public IQueryable CreateQuery(Expression expression) => new FlipAsyncQueryable<User>(this, expression);
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression) => new FlipAsyncQueryable<TElement>(this, expression);
        public object? Execute(Expression expression) => Execute<object>(expression);
        public TResult Execute<TResult>(Expression expression)
        {
            _executeCount++;
            if (typeof(TResult) == typeof(bool))
                return (TResult)(object)(_executeCount == 1);
            return default!;
        }

        public TResult ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default)
        {
            _executeCount++;
            var resultType = typeof(TResult);
            if (resultType == typeof(Task<bool>))
                return (TResult)(object)Task.FromResult(true);
            if (resultType == typeof(ValueTask<bool>))
                return (TResult)(object)new ValueTask<bool>(true);
            if (resultType.IsGenericType && resultType.GetGenericTypeDefinition() == typeof(Task<>))
            {
                var inner = resultType.GetGenericArguments()[0];
                var completed = typeof(Task).GetMethod(nameof(Task.FromResult))!.MakeGenericMethod(inner)
                    .Invoke(null, [null])!;
                return (TResult)completed;
            }
            return default!;
        }
    }

    private sealed class FlipAsyncQueryable<T> : IQueryable<T>, IAsyncEnumerable<T>
    {
        public FlipAsyncQueryable(IAsyncQueryProvider provider, Expression? expression = null)
        {
            Provider = provider;
            Expression = expression ?? Expression.Constant(this);
        }

        public Type ElementType => typeof(T);
        public Expression Expression { get; }
        public IQueryProvider Provider { get; }
        public IEnumerator<T> GetEnumerator() => Enumerable.Empty<T>().GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default) =>
            new FlipAsyncEnumerator<T>((FlipAsyncQueryProvider)Provider);
    }

    private sealed class FlipAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        public FlipAsyncEnumerator(FlipAsyncQueryProvider provider) { }
        public T Current => default!;
        public ValueTask DisposeAsync() => ValueTask.CompletedTask;
        public ValueTask<bool> MoveNextAsync() => ValueTask.FromResult(false);
    }
}
