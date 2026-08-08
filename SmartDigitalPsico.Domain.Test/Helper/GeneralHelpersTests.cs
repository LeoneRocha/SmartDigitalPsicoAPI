using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Moq;
using SmartDigitalPsico.Domain.Helpers;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Domain.Test.Helper;

[TestFixture]
public class GeneralHelpersTests
{
    private sealed class OrderedModel
    {
        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(2)] public string Second { get; set; } = "second";
        [System.ComponentModel.Description("Nome exibido")] [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(1)] public string First { get; set; } = "first";
        public string Ignored { get; set; } = "ignored";
    }
    private sealed class AuditEntryModel
    {
        public long Id { get; init; }
        public long? CreatedUserId { get; init; }
        public long? ModifyUserId { get; init; }
        public AuditUser? ModifyUser { get; init; }
        public string Secret { get; init; } = "secret";
    }
    private sealed class AuditUser
    {
        public string? Name { get; init; }
    }
    private sealed class SelfReferencingAuditModel
    {
        public SelfReferencingAuditModel? Next { get; set; }
    }
    private sealed class TestFile : SmartDigitalPsico.Core.SDK.Domain.ModelEntity.Contracts.FileBase { }

    // Cenário: Uma mensagem possui tokens e uma mensagem simples não possui.
    // Objetivo: Substituir somente os tokens presentes.
    [Test]
    public void LanguageAndEmailTokens_ValidTemplates_ReturnsReplacedText()
    {
        // Arrange
        const string message = "Key|{0} between {1}|Age|18";
        // Act
        var language = ApplicationLanguageHelper.ReplaceTokensInMessage(message);
        var email = SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens("Hello [{Name}] [{Missing}]", new Dictionary<string, string> { ["Name"] = "Ana" });
        // Assert
        using (Assert.EnterMultipleScope())
        {
            language.Should().Be("Key|Age between 18");
            ApplicationLanguageHelper.ReplaceTokens("No token").Should().Be("No token");
            email.Should().Be("Hello Ana [{Missing}]");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens("unchanged", []).Should().Be("unchanged");
        }
    }

    // Cenário: HTML contém conteúdo permitido e script perigoso.
    // Objetivo: Preservar conteúdo seguro e remover script.
    [Test]
    public void Sanitize_HtmlWithScript_RemovesUnsafeContent()
    {
        // Arrange
        const string html = "<div style='color:red'><strong>safe</strong><script>alert(1)</script></div>";
        // Act
        var result = SmartDigitalPsico.Core.SDK.Domain.Helpers.HtmlSanitizerHelper.Sanitize(html);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            result.Should().Contain("safe");
            result.Should().Contain("style=");
            result.Should().NotContain("<script");
        }
    }

    // Cenário: Propriedades possuem ordem, descrição e item ignorado.
    // Objetivo: Refletir metadados corretamente.
    [Test]
    public void ReflectionHelpers_OrderedModel_ReturnsOrderedPropertiesAndLabel()
    {
        // Arrange
        var model = new OrderedModel();
        // Act
        var properties = SmartDigitalPsico.Core.SDK.Domain.Helpers.ReflectionHelpers.GetProperties(model, ["Ignored"]).ToList();
        var label = SmartDigitalPsico.Core.SDK.Domain.Helpers.ReflectionHelpers.GetLabelProperty(properties[0]);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            properties.Select(x => x.Name).Should().BeEquivalentTo(["First", "Second"], o => o.WithStrictOrdering());
            label.Should().Be("Nome exibido");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.ReflectionHelpers.GetLabelProperty(typeof(OrderedModel).GetProperty(nameof(OrderedModel.Second))!).Should().Be("Second");
            new SmartDigitalPsico.Core.SDK.Domain.Helpers.OrderAttribute(7).Order.Should().Be(7);
        }
    }

    // Cenário: Datas, blob e serialização são requisitados.
    // Objetivo: Formatar e preservar dados esperados.
    [Test]
    public void GeneralHelpers_ValidInputs_ReturnExpectedValues()
    {
        // Arrange
        var date = new DateTime(2025, 2, 3, 4, 5, 6);
        var file = new TestFile { FileContentType = "image/png" };
        // Act
        var headers = SmartDigitalPsico.Core.SDK.Domain.Helpers.BlobFileHelper.GetBlobHeadersAzure(file);
        var clone = AuditLogHelper.DeepClone(new OrderedModel(), ["Ignored"]);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ConvertSecondsToTimeString(3661).Should().Be("01:01:01");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(date).Should().Be("03/02/2025 04:05:06");
            headers.ContentType.Should().Be("image/png");
            AuditLogHelper.SerializeObject(null!).Should().BeEmpty();
            AuditLogHelper.SerializeObject(new OrderedModel(), ["Ignored"]).Should().NotContain("Ignored");
            clone.Ignored.Should().Be("ignored");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowWithTimeZone(string.Empty).Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(2));
        }
    }

    // Cenário: alterações possuem dados de usuário, chave e propriedades excluídas.
    // Objetivo: montar a auditoria e aplicar os retornos padrão quando os dados não existem.
    [Test]
    public void AuditLogHelper_CompleteAndMissingAuditData_ReturnsExpectedEntry()
    {
        // Arrange
        var current = new AuditEntryModel
        {
            Id = 12,
            ModifyUserId = 7,
            Secret = "new"
        };
        var previous = new AuditEntryModel
        {
            Id = 12,
            CreatedUserId = 7,
            ModifyUser = new AuditUser { Name = "Ana" },
            Secret = "old"
        };

        // Act
        var entry = AuditLogHelper.CreateAuditEntry(previous, current, "Update", ["Secret"]);
        var fallback = AuditLogHelper.CreateAuditEntry(null!, new { Name = "without-key" }, "Create", []);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            entry.TableName.Should().Be(nameof(AuditEntryModel));
            entry.Operation.Should().Be("Update");
            entry.KeyValue.Should().Be("12");
            entry.UserAuditedId.Should().Be(7);
            entry.UserAuditedLogin.Should().Be("Ana");
            entry.OldValues.Should().NotContain("Secret");
            entry.NewValues.Should().NotContain("Secret");
            fallback.KeyValue.Should().BeEmpty();
            fallback.UserAuditedId.Should().BeNull();
            fallback.UserAuditedLogin.Should().Be("admin");
            AuditLogHelper.SerializeObject(new AuditEntryModel()).Should().Contain("Secret");
        }
    }

    // Cenário: Configurações contêm valores, coleções e seção ausente.
    // Objetivo: Expor os acessores e validar configuração nula.
    [Test]
    public void ConfigurationHelper_ConfigurationValues_ReturnsConfiguredData()
    {
        // Arrange
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionMySQL"] = "mysql",
            ["ConnectionStrings:SmartDigitalPsicoDBConnectionSQLServer"] = "sql",
            ["AppSettings:ResourcesTemp"] = "temp",
            ["AppSettings:AllowedFileExtensions:0"] = ".pdf",
            ["AppSettings:AllowedContentTypes:0"] = "application/pdf",
            ["AppSettings:MaxFileSizeMegabytes"] = "8",
            ["StorageServices:AzureStorage:ConnectionString"] = "storage",
            ["StorageServices:AzureStorage:DaysExpiresBlobSas"] = "3",
            ["SecuritySettings:AesSettings:AesKey"] = "key",
            ["SecuritySettings:AesSettings:AesIv"] = "iv"
        }).Build();
        // Act
        var extensions = ConfigurationAppSettingsHelper.GetAllowedFileExtensions(config);
        // Assert
        using (Assert.EnterMultipleScope())
        {
            ConfigurationAppSettingsHelper.GetConnectionStringMySQL(config).Should().Be("mysql");
            ConfigurationAppSettingsHelper.GetConnectionStringSQL(config).Should().Be("sql");
            ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(config).Should().Be("temp");
            extensions.Should().ContainSingle().Which.Should().Be(".pdf");
            ConfigurationAppSettingsHelper.GetAllowedContentTypes(config).Should().ContainSingle().Which.Should().Be("application/pdf");
            ConfigurationAppSettingsHelper.GetMaxFileSizeMegabytes(config).Should().Be(8);
            ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageConnectionString(config).Should().Be("storage");
            ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageDaysExpiresBlobSas(config).Should().Be("3");
            ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesKey(config).Should().Be("key");
            ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesIv(config).Should().Be("iv");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetCacheConfiguration(config)).Key.Should().Be("CacheConfiguration");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetAuthConfiguration(config)).Key.Should().Be("AuthConfiguration");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetTokenConfigurations(config)).Key.Should().Be("TokenConfigurations");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetDataBaseConfigurations(config)).Key.Should().Be("DataBaseConfigurations");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetIResiliencePolicyConfig(config)).Key.Should().Be("ResiliencePolicyConfig");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetLocationSaveFileConfigurationVO(config)).Key.Should().Be("LocationSaveFileConfigurationVO");
            ((IConfigurationSection)ConfigurationAppSettingsHelper.GetSmtpSettings(config)).Key.Should().Be("SmtpSettings");
            ((Action)(() => ConfigurationAppSettingsHelper.GetSectionApp(null, "x"))).Should().Throw<ArgumentNullException>();
            ((Action)(() => ConfigurationAppSettingsHelper.GetConnectionStringApp(null, "x"))).Should().Throw<ArgumentNullException>();
            ((Action)(() => ConfigurationAppSettingsHelper.GetValueStringConfiguration(null, "x"))).Should().Throw<ArgumentNullException>();
        }
    }

    // Cenário: configuração sem chaves de storage/security/connection.
    // Objetivo: cobrir ramos ?? string.Empty.
    [Test]
    public void ConfigurationAppSettingsHelper_MissingKeys_ReturnsEmptyStrings()
    {
        // Arrange
        var empty = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>()).Build();

        // Act
        var connection = ConfigurationAppSettingsHelper.GetConnectionStringApp(empty, "missing");
        var value = ConfigurationAppSettingsHelper.GetValueStringConfiguration(empty, "missing");
        var storage = ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageConnectionString(empty);
        var days = ConfigurationAppSettingsHelper.GetStorageServicesAzureStorageDaysExpiresBlobSas(empty);
        var aesKey = ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesKey(empty);
        var aesIv = ConfigurationAppSettingsHelper.GetSecuritySettingsAesSettingAesIv(empty);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            connection.Should().BeEmpty();
            value.Should().BeEmpty();
            storage.Should().BeEmpty();
            days.Should().BeEmpty();
            aesKey.Should().BeEmpty();
            aesIv.Should().BeEmpty();
        }
    }

    // Cenário: Culturas, fusos e localizador têm resultados disponíveis e uma falha de localização.
    // Objetivo: Expor as conversões culturais e o retorno de segurança do localizador.
    [Test]
    public void CultureDateTimeHelper_ValidAndFailingInputs_ReturnsExpectedValues()
    {
        // Arrange
        var localizer = new Mock<IStringLocalizer<GeneralHelpersTests>>();
        localizer.Setup(x => x["welcome"]).Returns(new LocalizedString("welcome", "Bem-vinda"));
        var date = new DateTime(2025, 2, 3, 4, 5, 6, DateTimeKind.Utc);

        // Act
        var cultures = SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetCultures();
        var translated = SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.TranslateCulture([new() { Id = "pt-BR" }]);
        SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.SetCulture("en-US");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZonesIds().Should().NotBeEmpty();
            cultures.Select(x => x.Id).Should().Contain(["en-US", "pt-BR", "es-ES"]);
            translated.Should().ContainSingle().Which.Name.Should().Be("pt-BR");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetNameAndCulture("welcome").Should().Be("welcome");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetKeyLocalizationRecordFormat("welcome", "pt-BR").Should().Be("welcome");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetLocalizer(localizer.Object, "welcome").Should().Be("Bem-vinda");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetLocalizer<GeneralHelpersTests>(null!, "missing").Should().Be("NotFoundLocalization");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetTimeZoneBrazil().Should().NotBeNullOrWhiteSpace();
            SmartDigitalPsico.Core.SDK.Domain.Helpers.CultureDateTimeHelper.GetCultureBrazil().Should().Be("pt-BR");
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowBrazil().Should().BeBefore(DateTime.UtcNow.AddMinutes(1));
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog().Should().BeBefore(DateTime.UtcNow.AddMinutes(1));
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowWithTimeZone("UTC").Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(2));
            SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.ApplyTimeZone(date, "UTC").Should().Be(date);
        }
    }

    // Cenário: a auditoria recebe propriedades ausentes, nulas e uma referência circular.
    // Objetivo: executar todos os retornos de segurança da serialização e leitura aninhada.
    [Test]
    public void AuditLogHelper_IncompleteAndCircularObjects_ReturnsFallbackValues()
    {
        // Arrange
        var circular = new SelfReferencingAuditModel();
        circular.Next = circular;
        var current = new { Id = 1L, UserId = (long?)9 };
        var previousWithoutName = new { ModifyUser = (AuditUser?)null };

        // Act
        var circularJson = AuditLogHelper.SerializeObject(circular);
        var missingProperty = AuditLogHelper.CreateAuditEntry(new { Other = "value" }, current, "Update", []);
        var nullNestedProperty = AuditLogHelper.CreateAuditEntry(previousWithoutName, current, "Update", []);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            circularJson.Should().NotBeNull();
            missingProperty.UserAuditedLogin.Should().Be("admin");
            nullNestedProperty.UserAuditedLogin.Should().Be("admin");
            AuditLogHelper.GetJsonSettings().ReferenceLoopHandling.Should().Be(Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }
    }

    // Cenário: serviços compartilhados estão disponíveis ou ausentes no provedor.
    // Objetivo: resolver cada serviço com segurança e rejeitar dependências não registradas.
    [Test]
    public void SharedServices_RegisteredAndMissingServices_ResolvesOrThrows()
    {
        // Arrange
        var language = new Mock<SmartDigitalPsico.Domain.Interfaces.Application.IApplicationLanguageService>().Object;
        var sender = new Mock<SmartDigitalPsico.Domain.Interfaces.Notification.ISendNotificationService>().Object;
        var template = new Mock<SmartDigitalPsico.Domain.Interfaces.Notification.INotificationTemplateService>().Object;
        var provider = new Mock<IServiceProvider>();
        provider.Setup(x => x.GetService(typeof(SmartDigitalPsico.Domain.Interfaces.Application.IApplicationLanguageService))).Returns(language);
        provider.Setup(x => x.GetService(typeof(SmartDigitalPsico.Domain.Interfaces.Notification.ISendNotificationService))).Returns(sender);
        provider.Setup(x => x.GetService(typeof(SmartDigitalPsico.Domain.Interfaces.Notification.INotificationTemplateService))).Returns(template);
        var services = new SmartDigitalPsico.Domain.DependeciesCollection.SharedServices(
            new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>().Object,
            new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService>().Object,
            provider.Object);
        var missing = new SmartDigitalPsico.Domain.DependeciesCollection.SharedServices(
            new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService>().Object,
            new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService>().Object,
            new Mock<IServiceProvider>().Object);

        // Act
        var action = () => missing.ApplicationLanguageService;

        // Assert
        using (Assert.EnterMultipleScope())
        {
            services.ApplicationLanguageService.Should().BeSameAs(language);
            services.SendNotificationService.Should().BeSameAs(sender);
            services.NotificationTemplateService.Should().BeSameAs(template);
            action.Should().Throw<InvalidOperationException>();
        }
    }
}
