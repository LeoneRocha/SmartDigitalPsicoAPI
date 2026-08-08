using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Serilog;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.Configure;
using SmartDigitalPsico.Service.Configure.Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SmartDigitalPsico.Service.Test.Configure;

[TestFixture]
public class ConfigurationAndCryptoServiceTests
{
    // Cenário: extensões padrão de ServiceCollection são configuradas.
    // Objetivo: registrar AutoMapper, cache, CORS, documentação, segurança e logging.
    [Test]
    public void Configure_StandardServiceCollectionExtensions_RegistersExpectedServices()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        ServiceCollectionConfigureAutoMapper.Configure(services);
        ServiceCollectionConfigureCaching.Configure(services);
        ServiceCollectionConfigureCors.Configure(services);
        ServiceCollectionConfigureDocumentation.Configure(services);
        ServiceCollectionConfigureEndpointsApiExplorer.Configure(services);
        ServiceCollectionConfigureHeader.Configure(services);
        ServiceCollectionConfigureLocalization.Configure(services);
        ServiceCollectionConfigureLog.Configure(services, new LoggerConfiguration().CreateLogger());
        ServiceCollectionConfigureSecurity.Configure(services, new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });
        using var provider = services.BuildServiceProvider();

        // Assert
        provider.GetRequiredService<IMapper>().Should().NotBeNull();
        provider.GetRequiredService<IMemoryCache>().Should().NotBeNull();
        services.Should().Contain(x => x.ServiceType == typeof(IAppLogger));
        services.Should().Contain(x => x.ServiceType == typeof(IConfigureOptions<RequestLocalizationOptions>));
    }
    // Cenário: appsettings são vinculados na coleção de serviços.
    // Objetivo: expor Token, Resilience e LocationSaveFile a partir da configuração.
    [Test]
    public void Configure_AppSettings_BindsAndRegistersConfigurationObjects()
    {
        // Arrange
        var configuration = BuildConfiguration();
        var services = new ServiceCollection();

        // Act
        ServiceCollectionConfigureAppSettings.Configure(services, configuration);
        var token = ServiceCollectionConfigureAppSettings.AddAndReturnTokenConfiguration(services, configuration);
        using var provider = services.BuildServiceProvider();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            token.Issuer.Should().Be("issuer");
            token.Audience.Should().Be("audience");
            provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto>().Issuer.Should().Be("issuer");
            provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig>().Should().NotBeNull();
            provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ILocationSaveFileConfigurationDto>().Should().NotBeNull();
        }
    }
    // Cenário: TypeDataBase válido é lido da configuração.
    // Objetivo: retornar o enum ETypeDataBase correspondente.
    [TestCase("MSsqlServer", ETypeDataBase.MSsqlServer)]
    [TestCase("Mysql", ETypeDataBase.Mysql)]
    public void AddAndReturnTypeDataBase_ValidValue_ReturnsConfiguredDatabase(string configuredValue, ETypeDataBase expected)
    {
        // Arrange
        var configuration = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = configuredValue
        });

        // Act
        var result = ServiceCollectionConfigureAppSettings.AddAndReturnTypeDataBase(configuration);

        // Assert
        result.Should().Be(expected);
    }
    // Cenário: registros manuais e automáticos de domínio são aplicados.
    // Objetivo: adicionar descritores de serviços esperados na DI.
    [Test]
    public void ServicesDomainService_ManualAndAutomaticRegistrations_AddServiceDescriptors()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        ServicesDomainService.AddDependenciesManually(services);
        ServicesDomainService.AddDependenciesAuto(services);

        // Assert
        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService));
        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Domain.Interfaces.Service.Schedule.IScheduleUpdateService));
        services.Should().Contain(x => x.ServiceType == typeof(SmartDigitalPsico.Domain.Interfaces.Service.IUserService));
    }
    // Cenário: criptografia com chave configurada/fornecida e cifra inválida.
    // Objetivo: delegar ao adapter e tratar cipher inválido com string vazia.
    [Test]
    public void CryptoService_EncryptDecryptAndInvalidCipher_DelegatesToAdapter()
    {
        // Arrange
        var encryptedBytes = new byte[] { 1, 2, 3 };
        var adapter = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoAdpter>();
        adapter.Setup(x => x.Encrypt("plain")).Returns(encryptedBytes);
        adapter.Setup(x => x.Decrypt(encryptedBytes)).Returns("plain");
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoAdapterFactory>();
        factory.Setup(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType.Aes, It.IsAny<string>(), "iv")).Returns(adapter.Object);
        var service = new SmartDigitalPsico.Core.SDK.Domain.Security.CryptoService(BuildConfiguration(), factory.Object);

        // Act
        var encryptedFromConfiguredKey = service.Encrypt("plain");
        var encryptedFromProvidedKey = service.Encrypt("override-key", "plain");
        var decrypted = service.Decrypt(encryptedFromConfiguredKey);
        var decryptedWithKey = service.Decrypt("override-key", encryptedFromConfiguredKey);
        var invalid = service.Decrypt("not base64!");
        var blank = service.Decrypt("   ");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            encryptedFromConfiguredKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            encryptedFromProvidedKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            decrypted.Should().Be("plain");
            decryptedWithKey.Should().Be("plain");
            invalid.Should().BeEmpty();
            blank.Should().BeEmpty();
        }
        factory.Verify(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType.Aes, "key", "iv"), Times.Exactly(2));
        factory.Verify(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ECryptoServiceType.Aes, "override-key", "iv"), Times.Exactly(2));
    }
    // Cenário: adapter de blob sem connection string.
    // Objetivo: executar caminhos seguros sem cliente Azure real.
    [Test]
    public async Task AzureStorageBlobAdapter_WithoutConnection_UsesSafeNoClientBehavior()
    {
        // Arrange
        var adapter = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(new ConfigurationBuilder().AddInMemoryCollection().Build());

        // Act
        var upload = await adapter.UploadFileReturnUrl(new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto { ContainerName = "files", FilePath = "unused" });
        var url = await adapter.GetFileStorageUrlPublic("files", "test.txt");
        await adapter.CreateContainerIfNotExists("files");
        await adapter.DownloadFile("files", "test.txt", Path.GetTempFileName());

        // Assert
        using (Assert.EnterMultipleScope())
        {
            upload.Should().BeEmpty();
            url.Should().BeEmpty();
        }
        Assert.ThrowsAsync<InvalidOperationException>(async () => await adapter.DeleteBlobAsync("files", "test.txt"));
    }

    // Cenário: JWT e Swagger são resolvidos após Configure.
    // Objetivo: executar lambdas internas de Security e Documentation.
    [Test]
    public void Configure_SecurityAndDocumentation_ResolvesOptionsAndSwagger()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        var environment = new Mock<Microsoft.AspNetCore.Hosting.IWebHostEnvironment>();
        environment.SetupGet(x => x.ApplicationName).Returns("SmartDigitalPsico.Service.Test");
        environment.SetupGet(x => x.ContentRootPath).Returns(Directory.GetCurrentDirectory());
        environment.SetupGet(x => x.EnvironmentName).Returns("Development");
        services.AddSingleton(environment.Object);
        services.AddSingleton<Microsoft.Extensions.Hosting.IHostEnvironment>(environment.Object);
        ServiceCollectionConfigureDocumentation.Configure(services);
        ServiceCollectionConfigureSecurity.Configure(services, new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();

        // Act
        var jwt = provider.GetRequiredService<IOptionsMonitor<JwtBearerOptions>>()
            .Get(JwtBearerDefaults.AuthenticationScheme);
        var swaggerOptions = provider.GetRequiredService<IOptions<Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions>>().Value;
        var auth = provider.GetRequiredService<IAuthorizationPolicyProvider>()
            .GetPolicyAsync("Bearer").GetAwaiter().GetResult();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            jwt.TokenValidationParameters.ValidIssuer.Should().Be("issuer");
            swaggerOptions.SwaggerGeneratorOptions.SwaggerDocs.Should().ContainKey("v1");
            auth.Should().NotBeNull();
        }
    }

    // Cenário: lambdas de ORM, CORS, Localization, NoSql e Queue são executadas.
    // Objetivo: resolver serviços registrados e cobrir options/factory delegates.
    [Test]
    public void Configure_OrmMysqlCorsLocalizationNoSqlQueue_ResolvesRegisteredOptionsAndServices()
    {
        // Arrange
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
        ServiceCollectionConfigureCors.Configure(services);
        ServiceCollectionConfigureLocalization.Configure(services);
        ServicesDomainAudit.AddDependencies(services);
        RegisterAuditSupportServices(services);
        ServicesDomainNoSql.AddDependencies(services);
        ServicesDomainQueue.AddDependencies(services);
        ServiceCollectionConfigureOrm.Configure(services, configuration);

        using var provider = services.BuildServiceProvider();
        var httpContext = new DefaultHttpContext { RequestServices = provider };

        // Act
        var corsPolicy = provider.GetRequiredService<ICorsPolicyProvider>()
            .GetPolicyAsync(httpContext, null).GetAwaiter().GetResult();
        var localization = provider.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
        var mysqlContext = provider.GetRequiredService<IEntityDataContext>();
        var patientRecordTable = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<PatientRecordTableEntity>>();
        var userTokenTable = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();
        var queue = provider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>();

        // Assert
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
        }
    }

    // Cenário: DbContext SQL Server e opções MVC/Authentication são resolvidos.
    // Objetivo: executar lambdas de ORM SQL Server, Header e Security.
    [Test]
    public void Configure_OrmSqlServerHeaderSecurity_ResolvesDbContextAndMvcOptions()
    {
        // Arrange
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
        ServiceCollectionConfigureHeader.Configure(services);
        ServiceCollectionConfigureSecurity.Configure(services, new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();

        // Act
        var sqlContext = provider.GetRequiredService<IEntityDataContext>();
        var mvcOptions = provider.GetRequiredService<IOptions<MvcOptions>>().Value;
        var authSchemes = provider.GetRequiredService<IAuthenticationSchemeProvider>();
        var defaultScheme = authSchemes.GetDefaultAuthenticateSchemeAsync().GetAwaiter().GetResult();

        // Assert
        using (Assert.EnterMultipleScope())
        {
            sqlContext.Should().NotBeNull();
            mvcOptions.RespectBrowserAcceptHeader.Should().BeTrue();
            defaultScheme!.Name.Should().Be(JwtBearerDefaults.AuthenticationScheme);
        }
    }

    // Cenário: ORM e módulos de domínio são registrados.
    // Objetivo: cobrir Configure ORM default e AddDependencies dos ServicesDomain*.
    [Test]
    public void Configure_OrmAndDomainModules_RegisterServiceDescriptors()
    {
        // Arrange
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

        // Act
        ServiceCollectionConfigureOrm.Configure(services, unsupported);
        var mysqlServices = new ServiceCollection();
        ServiceCollectionConfigureOrm.Configure(mysqlServices, mysql);
        var sqlServices = new ServiceCollection();
        ServiceCollectionConfigureOrm.Configure(sqlServices, sql);

        ServicesDomainRepository.AddDependencies(services);
        ServicesDomainValidation.AddDependencies(services);
        ServicesDomainSecurity.AddDependencies(services);
        ServicesDomainNoSql.AddDependencies(services);
        ServicesDomainSmtp.AddDependencies(services);
        ServicesDomainQueue.AddDependencies(services);
        ServicesDomainReport.AddDependencies(services);
        ServicesDomainAudit.AddDependencies(services);
        ServicesDomainAuthentication.AddDependencies(services);
        ServiceCollectionConfigureServicesDomain.Configure(new ServiceCollection(), BuildConfiguration());

        // Resolve NoSql factory lambdas (cobre corpos dos AddScoped).
        var noSqlServices = new ServiceCollection();
        noSqlServices.AddSingleton(BuildConfiguration());
        ServicesDomainNoSql.AddDependencies(noSqlServices);
        using var noSqlProvider = noSqlServices.BuildServiceProvider();
        var patientTable = noSqlProvider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<SmartDigitalPsico.Domain.TableEntityNoSQL.PatientRecordTableEntity>>();
        var tokenTable = noSqlProvider.GetRequiredService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<SmartDigitalPsico.Domain.TableEntityNoSQL.UserTokenSessionTableEntity>>();

        // Assert
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

    // Cenário: políticas CORS/Header/Log/Localization são materializadas.
    // Objetivo: executar lambdas internas dos Configure*.
    [Test]
    public async Task Configure_CorsHeaderLogLocalization_ExecuteInternalCallbacks()
    {
        // Arrange
        var services = new ServiceCollection();
        var serilogLogger = new LoggerConfiguration().CreateLogger();
        ServiceCollectionConfigureCors.Configure(services);
        ServiceCollectionConfigureHeader.Configure(services);
        ServiceCollectionConfigureLog.Configure(services, serilogLogger);
        ServiceCollectionConfigureLocalization.Configure(services);

        using var provider = services.BuildServiceProvider();

        // Act
        var cors = provider.GetRequiredService<Microsoft.AspNetCore.Cors.Infrastructure.ICorsPolicyProvider>();
        var policy = await cors.GetPolicyAsync(new Microsoft.AspNetCore.Http.DefaultHttpContext(), null);
        var localization = provider.GetRequiredService<IConfigureOptions<Microsoft.AspNetCore.Builder.RequestLocalizationOptions>>();
        var options = new Microsoft.AspNetCore.Builder.RequestLocalizationOptions();
        localization.Configure(options);
        var mvc = provider.GetRequiredService<IOptions<Microsoft.AspNetCore.Mvc.MvcOptions>>().Value;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            policy.Should().NotBeNull();
            options.SupportedCultures.Should().NotBeEmpty();
            mvc.RespectBrowserAcceptHeader.Should().BeTrue();
            provider.GetRequiredService<IAppLogger>().Should().BeOfType<SmartDigitalPsico.Core.SDK.Infrastructure.Logging.SerilogAppLoggerAdapter>();
            ((SmartDigitalPsico.Core.SDK.Infrastructure.Logging.SerilogAppLoggerAdapter)provider.GetRequiredService<IAppLogger>()).InnerLogger.Should().BeSameAs(serilogLogger);
        }
    }

    // Cenário: factory de tabela e persistência de auditoria em log.
    // Objetivo: cobrir Create da factory e SaveAuditEntries com UserAuditedId nulo.
    [Test]
    public void StorageTableFactory_AndAuditLogService_CoverRemainingLines()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory(BuildConfiguration());
        var logger = new Mock<IAppLogger>();
        var audit = new SmartDigitalPsico.Service.Audit.AuditPersistenceLogService(logger.Object);

        var table = factory.Create<SmartDigitalPsico.Domain.TableEntityNoSQL.UserTokenSessionTableEntity>(
            global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, $"t{Guid.NewGuid():N}"[..10]);
        audit.SaveAuditEntries(
        [
            new SmartDigitalPsico.Domain.ModelEntity.AuditDataEntityLog
            {
                TableName = "T",
                Operation = "U",
                KeyValue = "1",
                UserAuditedId = null,
                AuditDate = DateTime.UtcNow
            }
        ]);
        audit.SaveAuditEntry(new SmartDigitalPsico.Domain.ModelEntity.AuditDataSelectiveEntityLog
        {
            TableName = "T",
            Operation = "I",
            KeyValue = "2",
            UserAuditedId = 9,
            AuditDate = DateTime.UtcNow
        }).GetAwaiter().GetResult();

        // Assert
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
