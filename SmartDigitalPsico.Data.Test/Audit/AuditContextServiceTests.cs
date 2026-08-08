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
    // Cenário: uma entidade persistida é alterada.
    // Objetivo: registrar os valores anteriores e atuais para auditoria.
    [Test]
    public void OnBeforeSaveChanges_ModifiedEntity_CreatesAuditEntry()
    {
        // Arrange
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

    // Cenário: a mesma alteração é recebida novamente em uma janela de auditoria.
    // Objetivo: impedir a persistência duplicada do log.
    [Test]
    public void GetNewEntries_EntriesAlreadyCached_ReturnsOnlyUncachedEntries()
    {
        // Arrange
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

    // Cenário: entidade é removida sem usuário autenticado associado.
    // Objetivo: gerar log Deleted com fallback de login admin e valores originais.
    [Test]
    public void OnBeforeSaveChanges_DeletedEntity_UsesAdminFallbackAndOriginalValues()
    {
        // Arrange
        var entity = new ApplicationCacheLog { CacheId = "delete", CacheKey = "key" };
        _mockContext!.ApplicationCacheLogs.Add(entity);
        _mockContext.SaveChanges();
        _mockContext.ApplicationCacheLogs.Remove(entity);

        // Act
        var entries = CreateService().OnBeforeSaveChanges(_mockContext);

        // Assert
        entries.Should().ContainSingle();
        entries[0].Operation.Should().Be("Deleted");
        entries[0].UserAuditedId.Should().BeNull();
        entries[0].UserAuditedLogin.Should().Be("admin");
        entries[0].OldValues.Should().Contain("delete");
    }

    // Cenário: já existe registro de auditoria recente compatível no contexto.
    // Objetivo: retornar as entradas existentes correspondentes.
    [Test]
    public void GetExistingEntries_RecentMatchingAudit_IsReturned()
    {
        // Arrange
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

        // Act
        var existing = CreateService().GetExistingEntries(_mockContext, [entry]);

        // Assert
        existing.Should().ContainSingle();
    }

    // Cenário: Patient com CreatedUserId e propriedades de usuário ausentes/nulas.
    // Objetivo: cobrir GetUserId, GetCurrentUserId e geração de audit entry.
    [Test]
    public async Task AuditContextService_UserCreatedUserIdAndNullKey_CoverRemainingBranches()
    {
        // Arrange
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

        // Act
        var userId = getUserId.Invoke(null, [patientEntry, "CreatedUserId"]);
        var currentUser = getCurrentUserId.Invoke(null, [patientEntry]);
        var entries = service.OnBeforeSaveChanges(_mockContext);

        // Assert
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
        var options = Options.Create(new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            AbsoluteExpirationInHours = 1,
            SlidingExpirationInMinutes = 1
        });
        return new AuditContextService(new SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager.MemoryCacheRepository(cache, options));
    }
}
