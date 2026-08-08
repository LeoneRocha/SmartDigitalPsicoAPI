using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Data.Repository.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Report;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Core.SDK.Tests.Service.Infrastructure;

[TestFixture]
public class InfrastructureFactoriesAndSmtpTests
{
    public sealed class TestTableEntity : BaseEntityTable;

    [Test]
    public void EmailStrategyFactory_CreatesStrategiesOrThrows()
    {
        var settings = new SmtpSettingsDto { Server = "localhost", Port = 25, SenderEmail = "a@b.c", SenderName = "A" };
        var factory = new EmailStrategyFactory(settings);

        factory.CreateStrategy(EEmailStrategyType.Smtp).Should().BeOfType<SmtpEmailStrategy>();
        factory.CreateStrategy(EEmailStrategyType.ThirdParty).Should().BeOfType<ThirdPartyEmailStrategy>();
        ((Action)(() => factory.CreateStrategy((EEmailStrategyType)99))).Should().Throw<ArgumentException>();
    }

    [Test]
    public async Task ThirdPartyEmailStrategy_AndEmailContext_SendWithoutError()
    {
        var strategy = new ThirdPartyEmailStrategy();
        await strategy.SendEmailAsync(new EmailMessageDto { Subject = "s", Message = "m", ToEmails = ["a@b.c"] });

        var factory = new Mock<IEmailStrategyFactory>();
        factory.Setup(x => x.CreateStrategy(EEmailStrategyType.ThirdParty)).Returns(strategy);
        var context = new EmailContext(factory.Object);
        await context.SendEmailAsync(EEmailStrategyType.ThirdParty, new EmailMessageDto());
        factory.Verify(x => x.CreateStrategy(EEmailStrategyType.ThirdParty), Times.Once);
    }

    [Test]
    public async Task EmailService_ReplacesTokensAndDelegatesToContext()
    {
        var factory = new Mock<IEmailStrategyFactory>();
        factory.Setup(x => x.CreateStrategy(EEmailStrategyType.Smtp)).Returns(new ThirdPartyEmailStrategy());
        var emailService = new EmailService(new EmailContext(factory.Object));

        await emailService.SendAsync(
            new DataNotificationTemplateVO("Hello", "Body [{Name}]") { ToEmails = ["a@b.c"] },
            new Dictionary<string, string> { ["Name"] = "Ana" });

        factory.Verify(x => x.CreateStrategy(EEmailStrategyType.Smtp), Times.Once);
    }

    [Test]
    public void ReportFactories_CreateAdaptersOrThrow()
    {
        var pdf = new PdfReportAdapterFactory();
        var excel = new ExcelGeneratorFactory();

        pdf.Create(EPdfReportComponentType.QuestPDF).Should().NotBeNull();
        pdf.Create(EPdfReportComponentType.PDFsharp).Should().NotBeNull();
        excel.Create().Should().NotBeNull();
        ((Action)(() => pdf.Create((EPdfReportComponentType)99))).Should().Throw<ArgumentException>();
    }

    [Test]
    public void StorageFactories_CreateContracts()
    {
        var configuration = new ConfigurationBuilder().AddInMemoryCollection().Build();
        var tableFactory = new StorageTableRepositoryFactory(configuration);
        var queueFactory = new StorageQueueRepositoryFactory(configuration);

        tableFactory.Create<TestTableEntity>(EStorageAdapterType.Azure, "t1").Should().NotBeNull();
        queueFactory.Create(EStorageAdapterType.Azure, "q1").Should().NotBeNull();
    }

    [Test]
    public async Task StorageQueueService_AndGenericRepository_DelegateToAdapter()
    {
        var adapter = new Mock<IStorageQueueContract>();
        adapter.Setup(x => x.DequeueMessageAsync()).ReturnsAsync("msg");
        adapter.Setup(x => x.EnqueueMessageAsync("x")).Returns(Task.CompletedTask);
        adapter.Setup(x => x.DeleteMessageAsync("id", "pop")).Returns(Task.CompletedTask);

        var repository = new GenericStorageQueueRepository(adapter.Object, "q");
        await repository.EnqueueMessageAsync("x");
        (await repository.DequeueMessageAsync()).Should().Be("msg");
        await repository.DeleteMessageAsync("id", "pop");

        var factory = new Mock<IStorageQueueRepositoryFactory>();
        factory.Setup(x => x.Create(EStorageAdapterType.Azure, "queue")).Returns(adapter.Object);
        var service = new StorageQueueService(factory.Object, "queue");
        await service.EnqueueMessageAsync("x");
        (await service.DequeueMessageAsync()).Should().Be("msg");
        await service.DeleteMessageAsync("id", "pop");
    }

    [Test]
    public void ServiceResponseCacheVO_Constructors_CopyData()
    {
        var response = new ServiceResponse<string> { Data = "v", Success = true, Message = "ok" };
        var fromResponse = new ServiceResponseCacheVO<string>(response, "k", DateTime.UtcNow.AddMinutes(1));
        var fromData = new ServiceResponseCacheVO<string>("payload", "k2", DateTime.UtcNow.AddMinutes(2));
        var empty = new ServiceResponseCacheVO<string>();

        using (Assert.EnterMultipleScope())
        {
            fromResponse.Data.Should().Be("v");
            fromResponse.CacheKey.Should().Be("k");
            fromData.Data.Should().Be("payload");
            fromData.Success.Should().BeTrue();
            empty.CacheKey.Should().BeEmpty();
        }
    }

    [Test]
    public void DataNotificationTemplateVO_InitializesCollections()
    {
        var notification = new DataNotificationTemplateVO("Subject", "Body");
        var empty = new DataNotificationTemplateVO();
        notification.ToEmails.Add("a@b.c");
        empty.ToPhoneNumbers.Add("123");

        using (Assert.EnterMultipleScope())
        {
            notification.Subject.Should().Be("Subject");
            notification.Body.Should().Be("Body");
            notification.ToEmails.Should().ContainSingle();
            empty.ToPhoneNumbers.Should().ContainSingle();
        }
    }
}
