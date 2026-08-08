using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using Serilog;
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.Security;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;
using SmartDigitalPsico.Core.SDK.Service.Configure.ApiExplorer;
using SmartDigitalPsico.Core.SDK.Service.Configure.AppSettings;
using SmartDigitalPsico.Core.SDK.Service.Configure.Caching;
using SmartDigitalPsico.Core.SDK.Service.Configure.Cors;
using SmartDigitalPsico.Core.SDK.Service.Configure.Documentation;
using SmartDigitalPsico.Core.SDK.Service.Configure.Localization;
using SmartDigitalPsico.Core.SDK.Service.Configure.Logging;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mapping;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mvc;
using SmartDigitalPsico.Core.SDK.Service.Configure.Queue;
using SmartDigitalPsico.Core.SDK.Service.Configure.Repository;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;
using SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Tests.Service.Configure;

[TestFixture]
public class CoreConfigureServiceCollectionTests
{
    [Test]
    public void AddCore_StandardExtensions_RegistersExpectedServices()
    {
        var services = new ServiceCollection();

        services.AddCoreMapper();
        services.AddCoreCaching();
        services.AddCoreCors();
        services.AddCoreSwagger("Core.SDK.Tests", "test", "1.0.0");
        services.AddCoreEndpointsApiExplorer();
        services.AddCoreMvcControllers();
        services.AddCoreRequestLocalization();
        services.AddCoreLogging(new LoggerConfiguration().CreateLogger());
        services.AddCoreJwtBearer(new TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();

        provider.GetRequiredService<IMemoryCache>().Should().NotBeNull();
        services.Should().Contain(x => x.ServiceType == typeof(IAppLogger));
        services.Should().Contain(x => x.ServiceType == typeof(IConfigureOptions<RequestLocalizationOptions>));
        services.Should().Contain(x => x.ServiceType == typeof(AutoMapper.IMapper));
    }

    [Test]
    public void AddCoreAppSettings_BindsAndRegistersConfigurationObjects()
    {
        var configuration = BuildConfiguration();
        var services = new ServiceCollection();

        services.AddCoreAppSettings(configuration);
        var token = services.AddAndReturnTokenConfiguration(configuration);
        using var provider = services.BuildServiceProvider();

        using (Assert.EnterMultipleScope())
        {
            token.Issuer.Should().Be("issuer");
            token.Audience.Should().Be("audience");
            provider.GetRequiredService<ITokenConfigurationDto>().Issuer.Should().Be("issuer");
            provider.GetRequiredService<IResiliencePolicyConfig>().Should().NotBeNull();
            provider.GetRequiredService<ILocationSaveFileConfigurationDto>().Should().NotBeNull();
        }
    }

    [TestCase("MSsqlServer", ETypeDataBase.MSsqlServer)]
    [TestCase("Mysql", ETypeDataBase.Mysql)]
    public void AddAndReturnTypeDataBase_ValidValue_ReturnsConfiguredDatabase(string configuredValue, ETypeDataBase expected)
    {
        var configuration = BuildConfiguration(new Dictionary<string, string?>
        {
            ["DataBaseConfigurations:TypeDataBase"] = configuredValue
        });

        var result = AppSettingsServiceCollectionExtensions.AddAndReturnTypeDataBase(configuration);

        result.Should().Be(expected);
    }

    [Test]
    public void CryptoService_EncryptDecryptAndInvalidCipher_DelegatesToAdapter()
    {
        var encryptedBytes = new byte[] { 1, 2, 3 };
        var adapter = new Mock<ICryptoAdpter>();
        adapter.Setup(x => x.Encrypt("plain")).Returns(encryptedBytes);
        adapter.Setup(x => x.Decrypt(encryptedBytes)).Returns("plain");
        var factory = new Mock<ICryptoAdapterFactory>();
        factory.Setup(x => x.Create(ECryptoServiceType.Aes, It.IsAny<string>(), "iv")).Returns(adapter.Object);
        var service = new CryptoService(BuildConfiguration(), factory.Object);

        var encryptedFromConfiguredKey = service.Encrypt("plain");
        var encryptedFromProvidedKey = service.Encrypt("override-key", "plain");
        var decrypted = service.Decrypt(encryptedFromConfiguredKey);
        var decryptedWithKey = service.Decrypt("override-key", encryptedFromConfiguredKey);
        var invalid = service.Decrypt("not base64!");
        var blank = service.Decrypt("   ");

        using (Assert.EnterMultipleScope())
        {
            encryptedFromConfiguredKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            encryptedFromProvidedKey.Should().Be(Convert.ToBase64String(encryptedBytes));
            decrypted.Should().Be("plain");
            decryptedWithKey.Should().Be("plain");
            invalid.Should().BeEmpty();
            blank.Should().BeEmpty();
        }
        factory.Verify(x => x.Create(ECryptoServiceType.Aes, "key", "iv"), Times.Exactly(2));
        factory.Verify(x => x.Create(ECryptoServiceType.Aes, "override-key", "iv"), Times.Exactly(2));
    }

    [Test]
    public async Task AzureStorageBlobAdapter_WithoutConnection_UsesSafeNoClientBehavior()
    {
        var adapter = new AzureStorageBlobAdapter(new ConfigurationBuilder().AddInMemoryCollection().Build());

        var upload = await adapter.UploadFileReturnUrl(new BlobFileDto { ContainerName = "files", FilePath = "unused" });
        var url = await adapter.GetFileStorageUrlPublic("files", "test.txt");
        await adapter.CreateContainerIfNotExists("files");
        await adapter.DownloadFile("files", "test.txt", Path.GetTempFileName());

        using (Assert.EnterMultipleScope())
        {
            upload.Should().BeEmpty();
            url.Should().BeEmpty();
        }
        Assert.ThrowsAsync<InvalidOperationException>(async () => await adapter.DeleteBlobAsync("files", "test.txt"));
    }

    [Test]
    public void AddCoreJwtBearerAndSwagger_ResolvesOptions()
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        var environment = new Mock<Microsoft.AspNetCore.Hosting.IWebHostEnvironment>();
        environment.SetupGet(x => x.ApplicationName).Returns("SmartDigitalPsico.Core.SDK.Tests");
        environment.SetupGet(x => x.ContentRootPath).Returns(Directory.GetCurrentDirectory());
        environment.SetupGet(x => x.EnvironmentName).Returns("Development");
        services.AddSingleton(environment.Object);
        services.AddSingleton<Microsoft.Extensions.Hosting.IHostEnvironment>(environment.Object);
        services.AddCoreSwagger("Core.SDK.Tests", "test", "1.0.0");
        services.AddCoreJwtBearer(new TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();

        var jwt = provider.GetRequiredService<IOptionsMonitor<JwtBearerOptions>>()
            .Get(JwtBearerDefaults.AuthenticationScheme);
        var swaggerOptions = provider.GetRequiredService<IOptions<Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions>>().Value;
        var auth = provider.GetRequiredService<IAuthorizationPolicyProvider>()
            .GetPolicyAsync("Bearer").GetAwaiter().GetResult();

        using (Assert.EnterMultipleScope())
        {
            jwt.TokenValidationParameters.ValidIssuer.Should().Be("issuer");
            swaggerOptions.SwaggerGeneratorOptions.SwaggerDocs.Should().ContainKey("v1");
            auth.Should().NotBeNull();
        }
    }

    [Test]
    public async Task AddCoreCorsMvcLogLocalization_ExecuteInternalCallbacks()
    {
        var services = new ServiceCollection();
        var serilogLogger = new LoggerConfiguration().CreateLogger();
        services.AddCoreCors();
        services.AddCoreMvcControllers();
        services.AddCoreLogging(serilogLogger);
        services.AddCoreRequestLocalization();

        using var provider = services.BuildServiceProvider();

        var cors = provider.GetRequiredService<ICorsPolicyProvider>();
        var policy = await cors.GetPolicyAsync(new DefaultHttpContext(), null);
        var localization = provider.GetRequiredService<IConfigureOptions<RequestLocalizationOptions>>();
        var options = new RequestLocalizationOptions();
        localization.Configure(options);
        var mvc = provider.GetRequiredService<IOptions<MvcOptions>>().Value;

        using (Assert.EnterMultipleScope())
        {
            policy.Should().NotBeNull();
            options.SupportedCultures.Should().NotBeEmpty();
            mvc.RespectBrowserAcceptHeader.Should().BeTrue();
            provider.GetRequiredService<IAppLogger>().Should().BeOfType<SerilogAppLoggerAdapter>();
            ((SerilogAppLoggerAdapter)provider.GetRequiredService<IAppLogger>()).Logger.Should().BeSameAs(serilogLogger);
        }
    }

    [Test]
    public void AddCoreCryptoSmtpQueueAndCacheRepositories_RegisterDescriptors()
    {
        var services = new ServiceCollection();
        services.AddSingleton(BuildConfiguration());
        services.AddLogging();
        services.AddMemoryCache();

        services.AddCoreCrypto();
        services.AddCoreSmtp();
        services.AddCoreStorageQueue("general-queue");
        services.AddCoreCacheAndStorageRepositories();

        using (Assert.EnterMultipleScope())
        {
            services.Should().Contain(x => x.ServiceType == typeof(ICryptoService));
            services.Should().Contain(x => x.ServiceType == typeof(IEmailService));
            services.Should().Contain(x => x.ServiceType == typeof(IStorageQueueContract));
            services.Should().Contain(x => x.ServiceType == typeof(IMemoryCacheRepository));
            services.Should().Contain(x => x.ServiceType == typeof(IStorageBlobAdapter));
        }
    }

    [Test]
    public void AddCoreJwtBearer_ResolvesDefaultAuthenticateScheme()
    {
        var services = new ServiceCollection();
        services.AddLogging();
        services.AddCoreMvcControllers();
        services.AddCoreJwtBearer(new TokenConfigurationDto
        {
            Issuer = "issuer",
            Audience = "audience",
            Secret = "a sufficiently long signing secret for tests"
        });

        using var provider = services.BuildServiceProvider();
        var authSchemes = provider.GetRequiredService<IAuthenticationSchemeProvider>();
        var defaultScheme = authSchemes.GetDefaultAuthenticateSchemeAsync().GetAwaiter().GetResult();

        using (Assert.EnterMultipleScope())
        {
            provider.GetRequiredService<IOptions<MvcOptions>>().Value.RespectBrowserAcceptHeader.Should().BeTrue();
            defaultScheme!.Name.Should().Be(JwtBearerDefaults.AuthenticationScheme);
        }
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
            ["DataBaseConfigurations:TypeDataBase"] = "MSsqlServer",
            ["SmtpSettings:Host"] = "localhost",
            ["SmtpSettings:Port"] = "25",
            ["CacheConfiguration:IsEnable"] = "true"
        };

        if (overrides is not null)
        {
            foreach (var item in overrides)
                values[item.Key] = item.Value;
        }

        return new ConfigurationBuilder().AddInMemoryCollection(values).Build();
    }
}
