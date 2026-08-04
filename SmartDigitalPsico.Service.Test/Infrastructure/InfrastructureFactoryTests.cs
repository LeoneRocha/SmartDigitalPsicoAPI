using Microsoft.Extensions.DependencyInjection;
using Moq;
using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Infrastructure.Notification;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Test.Infrastructure;

[TestFixture]
public class InfrastructureFactoryTests
{
    // Cenário: uma estratégia de e-mail válida é solicitada.
    // Objetivo: garantir que a fábrica cria as estratégias SMTP e de terceiro.
    [TestCase(EEmailStrategyType.Smtp, typeof(SmtpEmailStrategy))]
    [TestCase(EEmailStrategyType.ThirdParty, typeof(ThirdPartyEmailStrategy))]
    public void CreateStrategy_ValidStrategyType_ReturnsExpectedStrategy(EEmailStrategyType strategyType, Type expectedType)
    {
        // Arrange
        var factory = new EmailStrategyFactory(new SmtpSettingsDto());

        // Act
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
        var factory = new EmailStrategyFactory(new SmtpSettingsDto());

        // Act
        var action = () => factory.CreateStrategy((EEmailStrategyType)999);

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
        var services = new ServiceCollection();
        INotificationPlatformService expectedService;
        switch (serviceType)
        {
            case ENotificationServiceType.Email:
                var emailService = Mock.Of<IEmailService>();
                services.AddSingleton(emailService);
                expectedService = emailService;
                break;
            case ENotificationServiceType.Sms:
                var smsService = Mock.Of<ISmsService>();
                services.AddSingleton(smsService);
                expectedService = smsService;
                break;
            case ENotificationServiceType.WhatsApp:
                var whatsAppService = Mock.Of<IWhatsAppService>();
                services.AddSingleton(whatsAppService);
                expectedService = whatsAppService;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(serviceType));
        }
        using var provider = services.BuildServiceProvider();
        var factory = new NotificationPlatformServiceFactory(provider);

        // Act
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
        var factory = new NotificationPlatformServiceFactory(new ServiceCollection().BuildServiceProvider());

        // Act
        var action = () => factory.GetService((ENotificationServiceType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: um componente PDF suportado é solicitado.
    // Objetivo: garantir que a fábrica fornece os adaptadores corretos.
    [TestCase(EPdfReportComponentType.QuestPDF, typeof(SmartDigitalPsico.Domain.Report.QuestPdfReportAdapter))]
    [TestCase(EPdfReportComponentType.PDFsharp, typeof(SmartDigitalPsico.Domain.Report.PDFsharpMigraDocReportAdapter))]
    public void Create_SupportedPdfComponent_ReturnsExpectedAdapter(EPdfReportComponentType componentType, Type expectedType)
    {
        // Arrange
        var factory = new PdfReportAdapterFactory();

        // Act
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
        var factory = new PdfReportAdapterFactory();

        // Act
        var action = () => factory.Create((EPdfReportComponentType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }

    // Cenário: um gerador Excel é solicitado.
    // Objetivo: garantir que o adaptador OpenXML é disponibilizado.
    [Test]
    public void Create_ExcelGeneratorRequested_ReturnsOpenXmlAdapter()
    {
        // Arrange
        var factory = new ExcelGeneratorFactory();

        // Act
        var result = factory.Create();

        // Assert
        result.Should().BeOfType<SmartDigitalPsico.Domain.Report.ExcelGeneratorOpenXmlAdapter>();
    }

    // Cenário: factory de fila de storage.
    // Objetivo: criar repositório genérico com adaptador Azure.
    [Test]
    public void StorageQueueRepositoryFactory_Create_ReturnsGenericRepository()
    {
        // Arrange
        var factory = new SmartDigitalPsico.Domain.Interfaces.Infrastructure.StorageQueueRepositoryFactory(new Microsoft.Extensions.Configuration.ConfigurationBuilder().Build());

        // Act
        var result = factory.Create(EStorageAdapterType.Azure, "notifications");

        // Assert
        result.Should().NotBeNull();
    }

    // Cenário: factory de tabela de storage.
    // Objetivo: criar repositório genérico com adaptador Azure.
    [Test]
    public void StorageTableRepositoryFactory_Create_ReturnsGenericRepository()
    {
        // Arrange
        var factory = new SmartDigitalPsico.Service.Infrastructure.StorageTableRepositoryFactory(
            new Microsoft.Extensions.Configuration.ConfigurationBuilder().Build());

        // Act
        var result = factory.Create<SmartDigitalPsico.Domain.TableEntityNoSQL.PatientRecordTableEntity>(
            EStorageAdapterType.Azure,
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
        services.AddSingleton(Mock.Of<SmartDigitalPsico.Domain.Interfaces.Repository.IUserTokenSessionRepository>());
        services.AddSingleton(Mock.Of<AutoMapper.IMapper>());
        services.AddSingleton(Mock.Of<SmartDigitalPsico.Domain.Interfaces.TableEntity.IStorageTableContract<SmartDigitalPsico.Domain.TableEntityNoSQL.UserTokenSessionTableEntity>>());
        using var provider = services.BuildServiceProvider();
        var factory = new SmartDigitalPsico.Service.Infrastructure.Authentication.TokenSessionPersistenceFactory(provider);

        // Act
        var database = factory.Create(ETokenSessionPersistenceType.DataBase);
        var table = factory.Create(ETokenSessionPersistenceType.AzureStorageTable);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            database.Should().BeOfType<SmartDigitalPsico.Service.Infrastructure.Authentication.DatabaseTokenSessionAdapter>();
            table.Should().BeOfType<SmartDigitalPsico.Service.Infrastructure.Authentication.TableStorageTokenSessionAdapter>();
        }
    }

    // Cenário: tipo de persistência de token inválido.
    // Objetivo: lançar ArgumentException.
    [Test]
    public void TokenSessionPersistenceFactory_InvalidType_ThrowsArgumentException()
    {
        // Arrange
        var factory = new SmartDigitalPsico.Service.Infrastructure.Authentication.TokenSessionPersistenceFactory(
            new ServiceCollection().BuildServiceProvider());

        // Act
        var action = () => factory.Create((ETokenSessionPersistenceType)999);

        // Assert
        action.Should().Throw<ArgumentException>();
    }
}
