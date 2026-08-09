using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.Schedule;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Data.Test.Configure;
using SmartDigitalPsico.Data.Test.DataMock;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;

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

    // Cenário: Save com FileData nulo e Exists/Get para arquivo inexistente.
    // Objetivo: retornar false/vazio nos caminhos de miss e save inválido.
    [Test]
    public async Task FileDiskRepository_SaveNullDataAndExistsMiss_ReturnExpectedResults()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var path = Path.Combine(_temporaryDirectory, "nested", "file.bin");
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        await File.WriteAllBytesAsync(path, [1, 2]);

        // Act
        var saveResult = await repository.Save(new FileData { FileData = null! });
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

    // Cenário: arquivo de cache existe mas desserializa para valor default (null).
    // Objetivo: tratar como miss no TryGetAsync.
    [Test]
    public async Task DiskCacheRepository_DefaultDeserializedValue_ReturnsMiss()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var cache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(disk.Object, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        // Act
        var result = await cache.TryGetAsync<CachePayload>("default-null");

        // Assert
        result.Key.Should().BeFalse();
    }

    // Cenário: linguagem solicitada ausente e template inexistente.
    // Objetivo: fazer fallback para pt-BR ou retornar null quando não houver match.
    [Test]
    public async Task NotificationTemplate_FallbackLanguage_ReturnsPtBrOrFirst()
    {
        // Arrange
        _mockContext!.NotificationTemplates.AddRange(
            new NotificationTemplate { TemplateKey = "welcome", Language = "pt-BR", Enable = true },
            new NotificationTemplate { TemplateKey = "welcome", Language = "es-ES", Enable = true });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        // Act
        var ptFallback = await repository.GetNotificationTemplateAsync("welcome", "en-US");
        var first = await repository.GetNotificationTemplateAsync("missing", "en-US");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            ptFallback!.Language.Should().Be("pt-BR");
            first.Should().BeNull();
        }
    }

    // Cenário: FindByIDs recebe lista nula.
    // Objetivo: retornar lista vazia sem consultar o contexto.
    [Test]
    public async Task RoleGroupRepository_NullIds_ReturnsEmptyList()
    {
        // Arrange
        var repository = new RoleGroupRepository(_mockContext!);

        // Act
        var result = await repository.FindByIDs(null);

        // Assert
        result.Should().BeEmpty();
    }

    // Cenário: arquivo em pasta combinada e caminho direto.
    // Objetivo: cobrir Exists, Get e Delete pelos ramos de caminho.
    [Test]
    public async Task FileDiskRepository_ExistsAndGetPathBranches_AreCovered()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
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
    public void AuditContextService_ShortJsonAndNonScheduleProperty_CoversSanitizeBranches()
    {
        // Arrange
        var cache = new MemoryCache(new MemoryCacheOptions());
        var options = Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        });
        var service = new AuditContextService(new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository(cache, options));
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

    // Cenário: JSON longo e propriedades de usuário existentes/ausentes.
    // Objetivo: cobrir TruncateAuditJson, OnBeforeSaveChanges e GetUserId.
    [Test]
    public void AuditContextService_UserIdPropertyBranches_CoversGetUserIdPaths()
    {
        // Arrange
        var cache = new MemoryCache(new MemoryCacheOptions());
        var options = Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto { AbsoluteExpirationInHours = 1, SlidingExpirationInMinutes = 1 });
        var service = new AuditContextService(new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository(cache, options));
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
    public async Task FileDiskRepository_PathCombinationAndDeleteBranches_CoverAllPaths()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
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

    // Cenário: cache em disco com payload JSON válido.
    // Objetivo: retornar hit com valor desserializado.
    [Test]
    public async Task DiskCacheRepository_ValidDeserializedPayload_ReturnsHit()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("{\"Name\":\"cached\"}"));
        var cache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(disk.Object, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
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

    // Cenário: operações de fila com adapter mockado.
    // Objetivo: delegar Enqueue, Dequeue e Delete ao contrato de storage.
    [Test]
    public async Task GenericStorageQueueRepository_DelegatesQueueOperations()
    {
        // Arrange
        var adapter = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>();
        adapter.Setup(value => value.DequeueMessageAsync()).ReturnsAsync("payload");
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.Infrastructure.GenericStorageQueueRepository(adapter.Object, "queue");

        // Act
        await repository.EnqueueMessageAsync("hello");
        (await repository.DequeueMessageAsync()).Should().Be("payload");
        await repository.DeleteMessageAsync("id", "receipt");

        // Assert
        adapter.Verify(value => value.EnqueueMessageAsync("hello"), Times.Once);
        adapter.Verify(value => value.DeleteMessageAsync("id", "receipt"), Times.Once);
    }

    // Cenário: construção do repositório com contexto válido.
    // Objetivo: garantir instanciação de MedicalSettingsRepository.
    [Test]
    public void MedicalSettingsRepository_ContextProvided_CreatesInstance()
    {
        // Arrange
        var context = _mockContext!;

        // Act
        var repository = new MedicalSettingsRepository(context);

        // Assert
        repository.Should().NotBeNull();
    }

    // Cenário: Configure da EntityBaseConfiguration abstrata de teste.
    // Objetivo: lançar NotImplementedException.
    [Test]
    public void EntityBaseConfiguration_Configure_ThrowsNotImplemented()
    {
        // Arrange
        var builder = new ModelBuilder(new ConventionSet()).Entity<ApplicationCacheLog>();
        var configuration = new TestEntityBaseConfiguration(ETypeDataBase.Mysql);
        Action act = () => configuration.Configure(builder);

        // Act
        // Assert
        act.Should().Throw<NotImplementedException>();
    }

    // Cenário: construtores apenas com DbContextOptions para SqlServer e MySql.
    // Objetivo: construir modelos de entidade sem interceptor.
    [Test]
    public async Task ContextOptionsOnlyConstructors_BuildModels()
    {
        // Arrange
        var sql = new SmartDigitalPsicoDataContextSqlServer(new DbContextOptionsBuilder<SmartDigitalPsicoDataContextSqlServer>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);
        var mysql = new SmartDigitalPsicoDataContextMySql(new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options);

        // Act
        var sqlTypes = sql.Model.GetEntityTypes();
        var mysqlTypes = mysql.Model.GetEntityTypes();

        // Assert
        sqlTypes.Should().NotBeEmpty();
        mysqlTypes.Should().NotBeEmpty();
        await sql.DisposeAsync();
        await mysql.DisposeAsync();
    }

    // Cenário: idioma existente e idioma ausente no repositório.
    // Objetivo: retornar true/false conforme ExistLanguage.
    [Test]
    public async Task ApplicationLanguage_ExistLanguage_ReturnsMatchingFlag()
    {
        // Arrange
        var language = new ApplicationLanguage { Language = "pt-BR", LanguageKey = "Welcome", ResourceKey = "SharedResource", Description = "Oi" };
        _mockContext!.ApplicationLanguages.Add(language);
        await _mockContext.SaveChangesAsync();
        var repository = new ApplicationLanguageRepository(_mockContext);

        // Act
        var exists = await repository.ExistLanguage("pt-BR", "Welcome");
        var missing = await repository.ExistLanguage("en-US", "Welcome");

        // Assert
        exists.Should().BeTrue();
        missing.Should().BeFalse();
    }

    // Cenário: template habilitado na linguagem solicitada.
    // Objetivo: retornar o template exato sem fallback.
    [Test]
    public async Task NotificationTemplate_MatchingLanguage_ReturnsExactTemplate()
    {
        // Arrange
        _mockContext!.NotificationTemplates.Add(new NotificationTemplate
        {
            TemplateKey = "appointment",
            Language = "en-US",
            Enable = true
        });
        await _mockContext.SaveChangesAsync();
        var repository = new NotificationTemplateRepository(_mockContext);

        // Act
        var result = await repository.GetNotificationTemplateAsync("appointment", "en-US");

        // Assert
        result.Should().NotBeNull();
        result!.Language.Should().Be("en-US");
    }

    // Cenário: agenda com SubjectKey específico a partir de uma data.
    // Objetivo: filtrar GetByTokenFromStartAsync pelo subject correto.
    [Test]
    public async Task ScheduleCalendar_GetByTokenFromStart_FiltersSubjectKey()
    {
        // Arrange
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

        // Act
        var matching = await repository.GetByTokenFromStartAsync("token", "owner", "subject", now);
        var other = await repository.GetByTokenFromStartAsync("token", "owner", "other", now);

        // Assert
        matching.Should().ContainSingle();
        other.Should().BeEmpty();
    }

    // Cenário: paciente com grafo de medical/gender e critério de busca.
    // Objetivo: retornar detalhes projetados e resultados de PatientSearch.
    [Test]
    public async Task PatientRepository_DetailsAndSearch_ReturnProjectedResults()
    {
        // Arrange
        SeedPatientGraph();
        var patient = _mockContext!.Patients.First();
        var repository = new PatientRepository(_mockContext);

        // Act
        var details = await repository.GetPatientDetailsByIdAsync(patient.Id);
        var search = await repository.PatientSearch(new PatientSearchCriteriaDto
        {
            MedicalId = patient.MedicalId,
            Name = patient.Name[..Math.Min(3, patient.Name.Length)]
        });

        // Assert
        details.Id.Should().Be(patient.Id);
        details.Medical.Should().NotBeNull();
        search.Should().NotBeEmpty();
        search.Should().OnlyContain(item => item.MedicalId == 0 || item.Id > 0);
    }

    // Cenário: login inexistente, refresh miss e deletes válidos/inválidos.
    // Objetivo: cobrir caminhos negativos de UserRepository.
    [Test]
    public async Task UserRepository_DeleteAndNegativePaths_AreCovered()
    {
        // Arrange
        SeedUserGraph();
        var repository = new UserRepository(_mockContext!);
        var user = _mockContext!.Users.OrderBy(item => item.Id).First();

        // Act
        var missingLogin = await repository.UserExists("missing-login");
        var refreshMiss = await repository.RefreshUserInfo(new User { Id = 999999 });
        var deleted = await repository.Delete(user.Id);
        var deleteMissing = await repository.Delete(999999);

        // Assert
        missingLogin.Should().BeFalse();
        refreshMiss.Id.Should().Be(0);
        deleted.Should().BeTrue();
        deleteMissing.Should().BeTrue();
    }

    // Cenário: exclusão por path direto e misses de cache (bytes nulos/json null).
    // Objetivo: cobrir Delete de arquivo direto e TryGetAsync em falha.
    [Test]
    public async Task FileDiskRepository_DeletesDirectFilePathAndCacheMissBranches()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var directFile = Path.Combine(_temporaryDirectory, "direct.bin");
        await File.WriteAllBytesAsync(directFile, [9, 9]);

        // Act
        await repository.Delete(new FileData { FilePath = directFile, FileName = "ignored.bin" });

        // Assert
        File.Exists(directFile).Should().BeFalse();

        var cache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(repository, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Exists(It.IsAny<FileData>())).Returns(true);
        disk.SetupSequence(value => value.Get(It.IsAny<FileData>()))
            .ReturnsAsync((byte[]?)null)
            .ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var missCache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(disk.Object, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));
        (await missCache.TryGetAsync<CachePayload>("null-bytes")).Key.Should().BeFalse();
        (await missCache.TryGetAsync<CachePayload>("json-null")).Key.Should().BeFalse();
        (await cache.TryGetAsync<CachePayload>("missing")).Key.Should().BeFalse();
    }

    // Cenário: mutação concorrente do buffer durante Save/verificação.
    // Objetivo: detectar escrita corrompida via InvalidOperationException.
    [Test]
    public async Task FileDiskRepository_DetectsCorruptedWriteDuringVerification()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        Exception? failure = null;

        // Act
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

        // Assert
        failure.Should().BeOfType<InvalidOperationException>();
    }

    // Cenário: Exists indica true mas o lookup posterior não encontra o usuário.
    // Objetivo: RefreshUserInfo retornar usuário vazio (Id 0).
    [Test]
    public async Task UserRepository_RefreshUserInfo_WhenLookupMissesAfterExists_ReturnsEmptyUser()
    {
        // Arrange
        var context = new Mock<SmartDigitalPsico.Core.SDK.Data.Context.Interface.IEntityDataContext>();
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
        var field = typeof(SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<User>)
            .GetField("_dataset", BindingFlags.Instance | BindingFlags.NonPublic);
        field!.SetValue(repository, dbSet.Object);

        // Act
        var result = await repository.RefreshUserInfo(new User { Id = 1, Name = "ghost" });

        // Assert
        result.Id.Should().Be(0);
    }

    [Test]
    public async Task AuditInterceptor_PersistsNewEntriesAndAlternateServicePath()
    {
        // Arrange
        var persistence = new Mock<IAuditPersistenceService>();
        var factory = new Mock<IAuditPersistenceServiceFactory>();
        factory.Setup(value => value.CreateService(SmartDigitalPsico.Core.SDK.Domain.Enuns.EAuditServiceType.Database)).Returns(persistence.Object);
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

        // Act
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
            .SetValue(interceptor, SmartDigitalPsico.Core.SDK.Domain.Enuns.EAuditServiceType.Log);
        auditService.Setup(service => service.GetNewEntries(It.IsAny<DbContext>(), It.IsAny<List<AuditDataEntityLog>>()))
            .Returns((DbContext _, List<AuditDataEntityLog> entries) => entries);
        context.ApplicationCacheLogs.First().CacheKey = "log-path";
        context.SaveChanges();
        await context.SaveChangesAsync();

        // Assert
        persistence.Verify(service => service.SaveAuditEntries(It.IsAny<IEnumerable<AuditDataEntityLog>>()), Times.AtLeastOnce);
    }

    // Cenário: alterações em Patient, Schedule e JSON longo com omit/truncate.
    // Objetivo: cobrir sanitize, truncate, user audit e GetNewEntries.
    [Test]
    public void AuditContextService_CoversUserSanitizeAndTruncateBranches()
    {
        // Arrange
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

        var service = new AuditContextService(new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository(new MemoryCache(new MemoryCacheOptions()), Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        })));

        // Act
        var entries = service.OnBeforeSaveChanges(_mockContext);

        // Assert
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

    // Cenário: lacunas finais em FileDisk, Audit e Schedule (null/blank/open-end).
    // Objetivo: cobrir ramos restantes de truncate, sanitize, Get e agenda.
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

        var fileDisk = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var emptyPathFile = Path.Combine(_temporaryDirectory, "direct.bin");
        await File.WriteAllBytesAsync(emptyPathFile, [4, 5]);
        var folderPath = Path.Combine(_temporaryDirectory, "folder-read");
        Directory.CreateDirectory(folderPath);
        await File.WriteAllBytesAsync(Path.Combine(folderPath, "nested.bin"), [6]);

        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var diskCache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(disk.Object, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
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
                    Status = SmartDigitalPsico.Core.SDK.Domain.Enuns.EStatusCalendar.Confirmed,
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
            new ScheduleCalendar[] { new() { UniqueToken = "pkg", ScheduleData = null! } },
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

    // Cenário: caminho combinado inexistente e FilePath apontando ao arquivo real.
    // Objetivo: cobrir o ramo else de Get por path direto.
    [Test]
    public async Task FileDiskRepository_GetDirectPathWhenCombinedMissing_CoversElseBranch()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var direct = Path.Combine(_temporaryDirectory, "direct-only.bin");
        await File.WriteAllBytesAsync(direct, [3, 4, 5]);

        // Act
        var fromDirect = await repository.Get(new FileData { FilePath = direct, FileName = "unused.bin" });

        // Assert
        fromDirect.Should().Equal(3, 4, 5);
    }

    // Cenário: payload JSON válido e não-default no cache em disco.
    // Objetivo: retornar hit com o valor desserializado.
    [Test]
    public async Task DiskCacheRepository_ValidNonDefaultPayload_ReturnsHitWithValue()
    {
        // Arrange
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(d => d.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(d => d.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("{\"Name\":\"hit\"}"));
        var cache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(disk.Object, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        // Act
        var result = await cache.TryGetAsync<CachePayload>("hit-key");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Key.Should().BeTrue();
            result.Value.Name.Should().Be("hit");
        }
    }

    // Cenário: itens com EndDateTime nulo e janelas fora/dentro do conflito.
    // Objetivo: cobrir filtros de HasConflict/GetItems/GetItem com bordas nullable.
    [Test]
    public async Task ScheduleCalendarRepository_NullableEndDateTimeEdges_CoverConflictFilters()
    {
        // Arrange
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
                        Status = SmartDigitalPsico.Core.SDK.Domain.Enuns.EStatusCalendar.Confirmed,
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
                        Status = SmartDigitalPsico.Core.SDK.Domain.Enuns.EStatusCalendar.Confirmed,
                        TimeZone = "UTC"
                    }
                ]
            });
        await _mockContext.SaveChangesAsync();
        var repository = new ScheduleCalendarRepository(_mockContext);

        // Act
        var conflictOpenEnd = await repository.HasConflictAsync("tenant", "owner", now);
        var subjectItems = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-a", now, now.AddHours(2));
        var item = await repository.GetItemAsync("tenant", "owner", "subject-a", now);
        var noConflict = await repository.HasConflictAsync("tenant", "owner", now.AddHours(5));

        var conflictMidWindow = await repository.HasConflictAsync("tenant", "owner", now.AddHours(1));
        var outsideSubject = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-b", now, now.AddHours(2));
        var beforeWindow = await repository.GetItemsForOwnerSubjectAsync("tenant", "owner", "subject-a", now.AddHours(2), now.AddHours(4));

        // Assert
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

    // Cenário: FindByID/FindAsync com expressão de Include (Gender).
    // Objetivo: retornar paciente com includes aplicados.
    [Test]
    public async Task GenericRepository_FindMethods_UseIncludeExpressions()
    {
        // Arrange
        SeedPatientGraph();
        var patient = _mockContext!.Patients.First();
        var repository = new PatientRepository(_mockContext);

        // Act
        var byId = await repository.FindByID(patient.Id, item => item.Gender!);
        var asyncFind = await repository.FindAsync(patient.Id, item => item.Gender!);

        // Assert
        byId.Should().NotBeNull();
        asyncFind.Should().NotBeNull();
        byId.Id.Should().Be(patient.Id);
        asyncFind!.Id.Should().Be(patient.Id);
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
