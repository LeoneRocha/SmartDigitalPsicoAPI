using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using System.Reflection;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Test.Configure;

namespace SmartDigitalPsico.Data.Test.Audit;

[TestFixture]
public class AuditContextServiceTests : BaseTests
{
    [Test]
    public void OnBeforeSaveChanges_ModifiedEntity_CreatesAuditEntry()
    {
        // Cenário: uma entidade persistida é alterada.
        // Objetivo: registrar os valores anteriores e atuais para auditoria.
        var entity = new ApplicationCacheLog { CacheId = "before", CacheKey = "key" };
        _mockContext!.ApplicationCacheLogs.Add(entity);
        _mockContext.SaveChanges();
        entity.CacheId = "after";

        var service = CreateService();

        // Act
        var entries = service.OnBeforeSaveChanges(_mockContext);

        // Assert
        entries.Should().ContainSingle();
        entries[0].TableName.Should().Be(nameof(ApplicationCacheLog));
        entries[0].Operation.Should().Be("Modified");
        entries[0].OldValues.Should().Contain("before");
        entries[0].NewValues.Should().Contain("after");
    }

    [Test]
    public void GetNewEntries_EntriesAlreadyCached_ReturnsOnlyUncachedEntries()
    {
        // Cenário: a mesma alteração é recebida novamente em uma janela de auditoria.
        // Objetivo: impedir a persistência duplicada do log.
        var service = CreateService();
        var entry = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "ApplicationCacheLog",
            Operation = "Modified",
            KeyValue = "1",
            OldValues = "{\"CacheId\":\"before\"}",
            NewValues = "{\"CacheId\":\"after\"}"
        };

        // Act
        var firstResult = service.GetNewEntries(_mockContext!, [entry]);
        var duplicateResult = service.GetNewEntries(_mockContext!, [entry]);

        // Assert
        firstResult.Should().ContainSingle();
        duplicateResult.Should().BeEmpty();
    }

    // Cenário: cache contém entradas recentes compatíveis e entidade com PK nula.
    // Objetivo: cobrar ramos restantes de handleMemoryIfNotExists e GetKeyValues.
    [Test]
    public void GetNewEntries_CacheHitWithRecentEntries_FiltersDuplicates()
    {
        // Arrange
        var service = CreateService();
        var entry = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "RoleGroup",
            Operation = "Modified",
            KeyValue = "5",
            OldValues = "{\"Name\":\"a\"}",
            NewValues = "{\"Name\":\"b\"}"
        };
        service.GetNewEntries(_mockContext!, [entry]);
        var otherTable = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "Other",
            Operation = "Modified",
            KeyValue = "9",
            OldValues = "{}",
            NewValues = "{}"
        };

        // Act
        var filtered = service.GetNewEntries(_mockContext!, [otherTable]);

        // Assert
        filtered.Should().ContainSingle();
    }

    [Test]
    public void OnBeforeSaveChanges_DeletedEntity_UsesAdminFallbackAndOriginalValues()
    {
        var entity = new ApplicationCacheLog { CacheId = "delete", CacheKey = "key" };
        _mockContext!.ApplicationCacheLogs.Add(entity);
        _mockContext.SaveChanges();
        _mockContext.ApplicationCacheLogs.Remove(entity);

        var entries = CreateService().OnBeforeSaveChanges(_mockContext);

        entries.Should().ContainSingle();
        entries[0].Operation.Should().Be("Deleted");
        entries[0].UserAuditedId.Should().BeNull();
        entries[0].UserAuditedLogin.Should().Be("admin");
        entries[0].OldValues.Should().Contain("delete");
    }

    [Test]
    public void GetExistingEntries_RecentMatchingAudit_IsReturned()
    {
        var entry = new AuditDataEntityLog
        {
            AuditDate = DateTime.UtcNow,
            TableName = "ApplicationCacheLog",
            Operation = "Modified",
            KeyValue = "7",
            OldValues = "{}",
            NewValues = "{}"
        };
        _mockContext!.Set<AuditDataEntityLog>().Add(entry);
        _mockContext.SaveChanges();

        var existing = CreateService().GetExistingEntries(_mockContext, [entry]);

        existing.Should().ContainSingle();
    }

    [Test]
    public async Task AuditContextService_UserCreatedUserIdAndNullKey_CoverRemainingBranches()
    {
        var service = CreateService();
        var patient = new Patient { Name = "Audit", MedicalId = 1, CreatedUserId = 42L };
        _mockContext!.Patients.Add(patient);
        _mockContext.SaveChanges();
        patient.Name = "Changed";
        var patientEntry = _mockContext.Entry(patient);
        var getUserId = typeof(AuditContextService).GetMethod("GetUserId", BindingFlags.NonPublic | BindingFlags.Static)!;
        var modifyUserId = getUserId.Invoke(null, [patientEntry, "ModifyUserId"]);
        var missingUserId = getUserId.Invoke(null, [patientEntry, "UserId"]);
        var getKeyValues = typeof(AuditContextService).GetMethod("GetKeyValues", BindingFlags.NonPublic | BindingFlags.Static)!;
        var getCurrentUserId = typeof(AuditContextService).GetMethod("GetCurrentUserId", BindingFlags.NonPublic | BindingFlags.Static)!;

        var userId = getUserId.Invoke(null, [patientEntry, "CreatedUserId"]);
        var currentUser = getCurrentUserId.Invoke(null, [patientEntry]);
        var entries = service.OnBeforeSaveChanges(_mockContext);

        using (Assert.EnterMultipleScope())
        {
            userId.Should().Be(42L);
            modifyUserId.Should().BeNull();
            missingUserId.Should().BeNull();
            ((ValueTuple<long?, string>)currentUser!).Item1.Should().Be(42L);
            entries.Should().ContainSingle(e => e.TableName == nameof(Patient));
        }
    }

    private static AuditContextService CreateService()
    {
        var cache = new MemoryCache(new MemoryCacheOptions());
        var options = Options.Create(new CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        });
        return new AuditContextService(new MemoryCacheRepository(cache, options));
    }
}
