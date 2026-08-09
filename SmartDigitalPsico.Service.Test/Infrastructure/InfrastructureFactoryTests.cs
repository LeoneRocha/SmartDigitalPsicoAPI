using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
namespace SmartDigitalPsico.Service.Test.Infrastructure;

[TestFixture]
public class InfrastructureFactoryTests
{
    // Cenário: uma estratégia de e-mail válida é solicitada.
    // Objetivo: garantir que a fábrica cria as estratégias SMTP e de terceiro.
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EEmailStrategyType.Smtp, typeof(SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.SmtpEmailStrategy))]
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EEmailStrategyType.ThirdParty, typeof(SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.ThirdPartyEmailStrategy))]
    public void CreateStrategy_ValidStrategyType_ReturnsExpectedStrategy(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EEmailStrategyType strategyType, Type expectedType)
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailStrategyFactory(new SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto());

        var result = factory.CreateStrategy(strategyType);

        // Assert
        result.Should().BeOfType(expectedType);
    }

    // Cenário: um tipo de estratégia desconhecido é solicitado.
    // Objetivo: garantir que a fábrica rejeita configurações inválidas.
    [Test]
    public void CreateStrategy_InvalidStrategyType_ThrowsArgumentException()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailStrategyFactory(new SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto());

        var action = () => factory.CreateStrategy((global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EEmailStrategyType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: uma plataforma de notificação registrada é solicitada.
    // Objetivo: garantir que cada enum resolve o serviço correspondente.
    [TestCase(ENotificationServiceType.Email)]
    [TestCase(ENotificationServiceType.Sms)]
    [TestCase(ENotificationServiceType.WhatsApp)]
    public void GetService_RegisteredPlatform_ReturnsRegisteredService(ENotificationServiceType serviceType)
    {
        // Arrange

        // Act
        var services = new ServiceCollection();
        global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification.INotificationPlatformService expectedService;
        switch (serviceType)
        {
            case ENotificationServiceType.Email:
                var emailService = Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp.IEmailService>();
                services.AddSingleton(emailService);
                expectedService = emailService;
                break;
            case ENotificationServiceType.Sms:
                var smsService = Mock.Of<global::SmartDigitalPsico.Domain.Interfaces.Notification.ISmsService>();
                services.AddSingleton(smsService);
                expectedService = smsService;
                break;
            case ENotificationServiceType.WhatsApp:
                var whatsAppService = Mock.Of<global::SmartDigitalPsico.Domain.Interfaces.Notification.IWhatsAppService>();
                services.AddSingleton(whatsAppService);
                expectedService = whatsAppService;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(serviceType));
        }
        using var provider = services.BuildServiceProvider();
        var factory = new NotificationPlatformServiceFactory(provider);

        var result = factory.GetService(serviceType);

        // Assert
        result.Should().BeSameAs(expectedService);
    }

    // Cenário: uma plataforma de notificação desconhecida é solicitada.
    // Objetivo: garantir que a fábrica não retorna um serviço incorreto.
    [Test]
    public void GetService_InvalidPlatform_ThrowsArgumentException()
    {
        // Arrange

        // Act
        var factory = new NotificationPlatformServiceFactory(new ServiceCollection().BuildServiceProvider());

        var action = () => factory.GetService((ENotificationServiceType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: um componente PDF suportado é solicitado.
    // Objetivo: garantir que a fábrica fornece os adaptadores corretos.
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.QuestPDF, typeof(SmartDigitalPsico.Core.SDK.Domain.Report.QuestPdfReportAdapter))]
    [TestCase(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.PDFsharp, typeof(SmartDigitalPsico.Core.SDK.Domain.Report.PDFsharpMigraDocReportAdapter))]
    public void Create_SupportedPdfComponent_ReturnsExpectedAdapter(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType componentType, Type expectedType)
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report.PdfReportAdapterFactory();

        var result = factory.Create(componentType);

        // Assert
        result.Should().BeOfType(expectedType);
    }

    // Cenário: um componente PDF inválido é solicitado.
    // Objetivo: garantir que a fábrica sinaliza a configuração incorreta.
    [Test]
    public void Create_InvalidPdfComponent_ThrowsArgumentException()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report.PdfReportAdapterFactory();

        var action = () => factory.Create((global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: um gerador Excel é solicitado.
    // Objetivo: garantir que o adaptador OpenXML é disponibilizado.
    [Test]
    public void Create_ExcelGeneratorRequested_ReturnsOpenXmlAdapter()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report.ExcelGeneratorFactory();

        var result = factory.Create();

        // Assert
        result.Should().BeOfType<SmartDigitalPsico.Core.SDK.Domain.Report.ExcelGeneratorOpenXmlAdapter>();
    }

    // Cenário: factory de fila de storage.
    // Objetivo: criar repositório genérico com adaptador Azure.
    [Test]
    public void StorageQueueRepositoryFactory_Create_ReturnsGenericRepository()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueRepositoryFactory(new Microsoft.Extensions.Configuration.ConfigurationBuilder().Build());

        var result = factory.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, "notifications");

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: factory de tabela de storage.
    // Objetivo: criar repositório genérico com adaptador Azure.
    [Test]
    public void StorageTableRepositoryFactory_Create_ReturnsGenericRepository()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableRepositoryFactory(
            new Microsoft.Extensions.Configuration.ConfigurationBuilder().Build());

        var result = factory.Create<SmartDigitalPsico.Domain.TableEntityNoSQL.PatientRecordTableEntity>(
            global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure,
            "patient-records");

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: factory de persistência de sessão de token.
    // Objetivo: resolver adaptadores Database e Azure Storage Table.
    [Test]
    public void TokenSessionPersistenceFactory_Create_ReturnsExpectedAdapters()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddSingleton(new Microsoft.Extensions.Configuration.ConfigurationBuilder().Build());
        services.AddSingleton(Mock.Of<SmartDigitalPsico.Domain.Interfaces.Common.IUserTokenSessionRepository>());
        services.AddSingleton(Mock.Of<IAppMapper>());
        services.AddSingleton(Mock.Of<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<SmartDigitalPsico.Domain.TableEntityNoSQL.UserTokenSessionTableEntity>>());
        using var provider = services.BuildServiceProvider();
        var factory = new SmartDigitalPsico.Service.TokenSessionPersistenceFactory(provider);

        var database = factory.Create(ETokenSessionPersistenceType.DataBase);
        var table = factory.Create(ETokenSessionPersistenceType.AzureStorageTable);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            database.Should().BeOfType<SmartDigitalPsico.Service.DatabaseTokenSessionAdapter>();
            table.Should().BeOfType<SmartDigitalPsico.Service.TableStorageTokenSessionAdapter>();
        }
    }

    // Cenário: tipo de persistência de token inválido.
    // Objetivo: lançar ArgumentException.
    [Test]
    public void TokenSessionPersistenceFactory_InvalidType_ThrowsArgumentException()
    {
        // Arrange

        // Act
        var factory = new SmartDigitalPsico.Service.TokenSessionPersistenceFactory(
            new ServiceCollection().BuildServiceProvider());

        var action = () => factory.Create((ETokenSessionPersistenceType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }
}
