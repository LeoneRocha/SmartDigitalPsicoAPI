using Microsoft.EntityFrameworkCore;
using Moq;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Test.Context;

[TestFixture]
public class DataContextAndInterceptorCoverageTests
{
    // Cenário: contextos SqlServer e MySql com interceptor de auditoria.
    // Objetivo: construir modelos e aplicar OnBeforeSaveChanges no SaveChangesAsync.
    [Test]
    public async Task SqlServerAndMySqlContexts_ConstructModelsAndApplyAuditInterceptor()
    {
        // Arrange
        var auditService = new Mock<IAuditContextService>();
        auditService.Setup(service => service.OnBeforeSaveChanges(It.IsAny<DbContext>()))
            .Returns([]);
        var persistence = new Mock<IAuditPersistenceService>();
        var factory = new Mock<IAuditPersistenceServiceFactory>();
        factory.Setup(value => value.CreateService(EAuditServiceType.Database)).Returns(persistence.Object);
        var interceptor = new AuditContextInterceptor(auditService.Object, factory.Object);

        var sqlOptions = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextSqlServer>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        var mysqlOptions = new DbContextOptionsBuilder<SmartDigitalPsicoDataContextMySql>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

        await using var sqlDefault = new SmartDigitalPsicoDataContextSqlServer();
        await using var mysqlDefault = new SmartDigitalPsicoDataContextMySql();
        await using var sql = new SmartDigitalPsicoDataContextSqlServer(sqlOptions, interceptor);
        await using var mysql = new SmartDigitalPsicoDataContextMySql(mysqlOptions, interceptor);

        // Act
        sql.Model.GetEntityTypes().Should().NotBeEmpty();
        mysql.Model.GetEntityTypes().Should().NotBeEmpty();
        sql.ApplicationCacheLogs.Add(new ApplicationCacheLog { CacheId = "sql", CacheKey = "key" });
        mysql.ApplicationCacheLogs.Add(new ApplicationCacheLog { CacheId = "mysql", CacheKey = "key" });

        await sql.SaveChangesAsync();
        await mysql.SaveChangesAsync();

        // Assert
        auditService.Verify(service => service.OnBeforeSaveChanges(It.IsAny<DbContext>()), Times.AtLeast(2));
        sqlDefault.Should().NotBeNull();
        mysqlDefault.Should().NotBeNull();
    }
}
