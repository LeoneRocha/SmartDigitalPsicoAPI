using SmartDigitalPsico.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Service.Configure.Cors;
using SmartDigitalPsico.Core.SDK.Service.Configure.Localization;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mvc;
using SmartDigitalPsico.Core.SDK.Service.Configure.Queue;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;
using SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;
using SmartDigitalPsico.Core.SDK.API;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.DependencyInjection;
using SmartDigitalPsico.Service.DependencyInjection.Domain;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Service.Test.Configure;
    using User = global::SmartDigitalPsico.Domain.EntityModels.User;
                                
[TestFixture]
public class ConfigurationAndCryptoServiceTests
{
    // Cenário: registros manuais e automáticos de domínio são aplicados.
    // Objetivo: adicionar descritores de serviços esperados na DI.
    [Test]
    public void ServicesDomainService_ManualAndAutomaticRegistrations_AddServiceDescriptors()
    {
        var services = new ServiceCollection();

        ServicesDomainService.AddDependenciesManually(services);
        ServicesDomainService.AddDependenciesAuto(services);

        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService));
        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Domain.Interfaces.Schedule.IScheduleUpdateService));
        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Domain.Interfaces.User.IUserService));
    }

    // Cenário: lambdas de ORM, CORS, Localization, NoSql e Queue são executadas.
    // Objetivo: resolver serviços registrados e cobrir options/factory delegates.
    [Test]
    public void Configure_OrmMysqlCorsLocalizationNoSqlQueue_ResolvesRegisteredOptionsAndServices()
    {
        var tempDir = Path.Combine(Path.GetTempPath(), "sdp-config-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(tempDir);
        var configuration = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = "Mysql",
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionMySQL"] = "Server=invalid-host;Database=test;User=root;Password=x;",
            ["AppSettings:ResourcesTemp"] = tempDir
        });
        var services = new ServiceCollection();
        services.AddSingleton<IConfiguration>(configuration);
        services.AddLogging();
        services.AddSingleton(Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>());
        services.AddSingleton(Mock.Of<IAppLogger>());
        services.AddCoreCors();
        services.AddCoreRequestLocalization();
        ServicesDomainAudit.AddDependencies(services);
        RegisterAuditSupportServices(services);
        ServicesDomainNoSql.AddDependencies(services);
        services.AddCoreStorageQueue(StorageQueueNameConstants.GeneralQueue);
        ServiceCollectionConfigureOrm.Configure(services, configuration);

        using var provider = services.BuildServiceProvider();
        var httpContext = new DefaultHttpContext { RequestServices = provider };

        var corsPolicy = provider.GetRequiredService<ICorsPolicyProvider>()
            .GetPolicyAsync(httpContext, null).GetAwaiter().GetResult();
        var localization = provider.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
        var mysqlContext = provider.GetRequiredService<IEntityDataContext>();
        var patientRecordTable = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>>();
        var userTokenTable = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();
        var queue = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>();

        using (Assert.EnterMultipleScope())
        {
            corsPolicy.Should().NotBeNull();
            corsPolicy!.AllowAnyOrigin.Should().BeTrue();
            corsPolicy.ExposedHeaders.Should().Contain("Content-Disposition");
            localization.DefaultRequestCulture.Culture.Name.Should().Be("pt-BR");
            localization.SupportedCultures.Should().NotBeEmpty();
            mysqlContext.Should().NotBeNull();
            patientRecordTable.Should().NotBeNull();
            userTokenTable.Should().NotBeNull();
            queue.Should().NotBeNull();
            provider.GetRequiredService<LanguageActionFilterAttribute>().Should().NotBeNull();
        }
    }

    // Cenário: DbContext SQL Server e opções MVC/Authentication são resolvidos.
    // Objetivo: executar lambdas de ORM SQL Server, Header e Security.
    [Test]
    public void Configure_OrmSqlServerHeaderSecurity_ResolvesDbContextAndMvcOptions()
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddSingleton(Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>());
        services.AddSingleton(Mock.Of<IAppLogger>());
        var configuration = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = "MSsqlServer",
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionSQLServer"] = "Server=localhost;Database=test;Trusted_Connection=True;"
        });
        ServicesDomainAudit.AddDependencies(services);
        RegisterAuditSupportServices(services);
        ServiceCollectionConfigureOrm.Configure(services, configuration);
        services.AddCoreMvcControllers();
        services.AddCoreJwtBearer(new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();

        var sqlContext = provider.GetRequiredService<IEntityDataContext>();
        var mvcOptions = provider.GetRequiredService<IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>>().Value;
        var authSchemes = provider.GetRequiredService<Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider>();
        var defaultScheme = authSchemes.GetDefaultAuthenticateSchemeAsync().GetAwaiter().GetResult();

        using (Assert.EnterMultipleScope())
        {
            sqlContext.Should().NotBeNull();
            mvcOptions.RespectBrowserAcceptHeader.Should().BeTrue();
            defaultScheme!.Name.Should().Be(Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme);
        }
    }

    // Cenário: ORM e módulos de domínio são registrados.
    // Objetivo: cobrir Configure ORM default e AddDependencies dos ServicesDomain*.
    [Test]
    public void Configure_OrmAndDomainModules_RegisterServiceDescriptors()
    {
        var services = new ServiceCollection();
        var unsupported = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = "Postgree"
        });
        var mysql = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = "Mysql",
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionMySQL"] = "Server=localhost;Database=test;User=root;Password=x;"
        });
        var sql = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = "MSsqlServer",
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionSQLServer"] = "Server=localhost;Database=test;Trusted_Connection=True;"
        });

        ServiceCollectionConfigureOrm.Configure(services, unsupported);
        var mysqlServices = new ServiceCollection();
        ServiceCollectionConfigureOrm.Configure(mysqlServices, mysql);
        var sqlServices = new ServiceCollection();
        ServiceCollectionConfigureOrm.Configure(sqlServices, sql);

        ServicesDomainRepository.AddDependencies(services);
        ServicesDomainValidation.AddDependencies(services);
        services.AddCoreCrypto();
        ServicesDomainNoSql.AddDependencies(services);
        services.AddCoreSmtp();
        services.AddCoreStorageQueue(StorageQueueNameConstants.GeneralQueue);
        ServicesDomainReport.AddDependencies(services);
        ServicesDomainAudit.AddDependencies(services);
        ServicesDomainAuthentication.AddDependencies(services);
        ServiceCollectionConfigureServicesDomain.Configure(new ServiceCollection(), BuildConfiguration());

        var noSqlServices = new ServiceCollection();
        noSqlServices.AddSingleton(BuildConfiguration());
        ServicesDomainNoSql.AddDependencies(noSqlServices);
        using var noSqlProvider = noSqlServices.BuildServiceProvider();
        var patientTable = noSqlProvider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>>();
        var tokenTable = noSqlProvider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();

        using (Assert.EnterMultipleScope())
        {
            mysqlServices.Should().Contain(x => x.ServiceType.Name.Contains("DataContext", StringComparison.Ordinal));
            sqlServices.Should().Contain(x => x.ServiceType.Name.Contains("DataContext", StringComparison.Ordinal));
            services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageBlobAdapter));
            services.Should().Contain(x => x.ServiceType == typeof(global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository));
            patientTable.Should().NotBeNull();
            tokenTable.Should().NotBeNull();
        }
    }

    // Cenário: factory de tabela e persistência de auditoria em log.
    // Objetivo: cobrir Create da factory e SaveAuditEntries com UserAuditedId nulo.
    [Test]
    public void StorageTableFactory_AndAuditLogService_CoverRemainingLines()
    {
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory(BuildConfiguration());
        var logger = new Mock<IAppLogger>();
        var audit = new SmartDigitalPsico.Service.Audit.AuditPersistenceLogService(logger.Object);

        var table = factory.Create<UserTokenSessionTableEntity>(
            SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, $"t{Guid.NewGuid():N}"[..10]);
        audit.SaveAuditEntries(
        [
            new SmartDigitalPsico.Domain.EntityModels.AuditDataEntityLog
            {
                TableName = "T",
                Operation = "U",
                KeyValue = "1",
                UserAuditedId = null,
                AuditDate = DateTime.UtcNow
            }
        ]);
        audit.SaveAuditEntry(new SmartDigitalPsico.Domain.EntityModels.AuditDataSelectiveEntityLog
        {
            TableName = "T",
            Operation = "I",
            KeyValue = "2",
            UserAuditedId = 9,
            AuditDate = DateTime.UtcNow
        }).GetAwaiter().GetResult();

        table.Should().NotBeNull();
        logger.Invocations.Should().NotBeEmpty();
    }

    private static void RegisterAuditSupportServices(IServiceCollection services)
    {
        services.AddSingleton(Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>());
        services.AddSingleton<IAppLogger>(_ => Mock.Of<IAppLogger>());
    }

    private static IConfiguration BuildConfiguration(IReadOnlyDictionary<string, string?>? overrides = null)
    {
        var values = new Dictionary<string, string?>
        {
            ["SecuritySettings:AesSettings:AesKey"] = "key",
            ["SecuritySettings:AesSettings:AesIv"] = "iv",
            ["TokenConfigurations:Issuer"] = "issuer",
            ["TokenConfigurations:Audience"] = "audience",
            ["TokenConfigurations:Secret"] = "a sufficiently long signing secret for tests",
            ["DataBaseConfigurations:TypeDataBase"] = "MSsqlServer"
        };

        if (overrides is not null)
        {
            foreach (var item in overrides)
                values[item.Key] = item.Value;
        }

        return new ConfigurationBuilder().AddInMemoryCollection(values).Build();
    }
}
