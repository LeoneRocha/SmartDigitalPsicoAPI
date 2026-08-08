using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Service.Infrastructure.Authentication;
using SmartDigitalPsico.Service.Infrastructure.Notification;

namespace SmartDigitalPsico.Service.Test.Infrastructure;

[TestFixture]
public class InfrastructureMethodCoverageGapTests
{
    // Cenário: SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueService encaminha operações ao repositório criado pela factory.
    // Objetivo: cobrir Enqueue/Dequeue/Delete do wrapper.
    [Test]
    public async Task StorageQueueService_AllOperations_ForwardToRepository()
    {
        // Arrange
        var repo = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract>();
        repo.Setup(x => x.DequeueMessageAsync()).ReturnsAsync("payload");
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueRepositoryFactory>();
        factory.Setup(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.Azure, "q1")).Returns(repo.Object);
        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageQueueService(factory.Object, "q1");

        // Act
        await sut.EnqueueMessageAsync("m");
        var dequeued = await sut.DequeueMessageAsync();
        await sut.DeleteMessageAsync("id", "pop");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            dequeued.Should().Be("payload");
            repo.Verify(x => x.EnqueueMessageAsync("m"), Times.Once);
            repo.Verify(x => x.DeleteMessageAsync("id", "pop"), Times.Once);
        }
    }

    // Cenário: TokenSessionService encaminha get/save ao adaptador Azure Table.
    // Objetivo: cobrir métodos públicos do wrapper.
    [Test]
    public async Task TokenSessionService_GetAndSave_ForwardToAdapter()
    {
        // Arrange
        var adapter = new Mock<ITokenSessionPersistenceAdapter>();
        adapter.Setup(x => x.GetSessionAsync(9)).ReturnsAsync(new UserTokenSession { UserId = 9 });
        var factory = new Mock<ITokenSessionPersistenceFactory>();
        factory.Setup(x => x.Create(ETokenSessionPersistenceType.AzureStorageTable)).Returns(adapter.Object);
        var sut = new TokenSessionService(factory.Object);
        var session = new UserTokenSession { UserId = 9, RefreshToken = "rt" };

        // Act
        var loaded = await sut.GetSessionAsync(9);
        await sut.SaveSessionAsync(session);

        // Assert
        loaded!.UserId.Should().Be(9);

        adapter.Verify(x => x.SaveSessionAsync(session), Times.Once);
    }

    // Cenário: SendNotificationService e global::SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailContext/SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification.EmailService orquestram envio.
    // Objetivo: cobrir wrappers de notificação e e-mail.
    [Test]
    public async Task NotificationAndEmailWrappers_Send_InvokeDependencies()
    {
        // Arrange
        var platform = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification.INotificationPlatformService>();
        var factory = new Mock<INotificationPlatformServiceFactory>();
        factory.Setup(x => x.GetService(ENotificationServiceType.Email)).Returns(platform.Object);
        var send = new SendNotificationService(factory.Object);
        var strategy = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp.IEmailStrategy>();
        var strategyFactory = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp.IEmailStrategyFactory>();
        strategyFactory.Setup(x => x.CreateStrategy(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EEmailStrategyType.Smtp)).Returns(strategy.Object);
        var emailContext = new global::SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailContext(strategyFactory.Object);
        var emailService = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification.EmailService(emailContext);
        var template = new global::SmartDigitalPsico.Core.SDK.Domain.VO.DataNotificationTemplateVO
        {
            Subject = "S",
            Body = "Hello {Name}",
            ToEmails = ["a@test.com"]
        };

        // Act
        await send.SendNotificationAsync(template, ENotificationServiceType.Email, new Dictionary<string, string> { ["Name"] = "Ada" });
        await emailService.SendAsync(template, new Dictionary<string, string> { ["Name"] = "Ada" });

        // Assert
        platform.Verify(x => x.SendAsync(template, It.IsAny<Dictionary<string, string>>()), Times.Once);
        strategy.Verify(x => x.SendEmailAsync(It.Is<global::SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.EmailMessageDto>(m => m.Subject == "S" && m.ToEmails.Contains("a@test.com"))), Times.Once);
    }

    // Cenário: cliente SMTP sempre com EnableSsl = true.
    // Objetivo: cobrir construção do cliente e falha de conexão com SSL.
    [Test]
    public void SmtpEmailStrategy_SslAlwaysEnabled_ThrowsOnUnreachableServer()
    {
        // Arrange
        var strategy = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.SmtpEmailStrategy(new SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto
        {
            SenderEmail = "sender@test.com",
            SenderName = "Sender",
            Server = "127.0.0.1",
            Port = 1,
            Username = "user",
            Password = "pass",
            EnableSsl = true
        });

        // Act
        var action = () => strategy.SendEmailAsync(new global::SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.EmailMessageDto
        {
            Subject = "Hi",
            Message = "<b>ok</b>",
            ToEmails = ["to@test.com"]
        }).GetAwaiter().GetResult();

        // Assert
        action.Should().Throw<Exception>();
    }

    // Cenário: BlobServiceClient sem chave compartilhada.
    // Objetivo: cobrir CanGenerateSasUri == false retornando string vazia.
    [Test]
    public async Task AzureStorageBlobAdapter_CannotGenerateSas_ReturnsEmpty()
    {
        // Arrange
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["StorageServices:AzureStorage:DaysExpiresBlobSas"] = "abc"
        }).Build();
        var anonymous = new BlobServiceClient(new Uri("http://127.0.0.1:10000/devstoreaccount1"));
        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(config, anonymous);

        // Act
        var url = await sut.GetFileStorageUrlPublic("container", "blob.txt");

        // Assert
        url.Should().BeEmpty();
    }

    // Cenário: Remove em disco e cache inválido (Value null / Key false).
    // Objetivo: cobrir case Disk do Remove e return false de checkCacheIsValid.
    [Test]
    public void CacheService_DiskRemoveAndInvalidCache_ReturnsFalse()
    {
        // Arrange
        var disk = new Mock<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IDiskCacheRepository>();
        disk.Setup(x => x.TryGetAsync<CacheValue>("missing"))
            .ReturnsAsync(new KeyValuePair<bool, CacheValue>(false, null!));
        disk.Setup(x => x.TryGetAsync<CacheValue>("null-value"))
            .ReturnsAsync(new KeyValuePair<bool, CacheValue>(true, null!));
        var service = new SmartDigitalPsico.Service.Infrastructure.CacheManager.CacheService(
            Mock.Of<global::SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IMemoryCacheRepository>(),
            disk.Object,
            Mock.Of<IApplicationCacheLogRepository>(),
            Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
            {
                TypeCache = global::SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Disk,
                IsEnable = true,
                AbsoluteExpirationInHours = 1,
                SlidingExpirationInMinutes = 5
            }));

        // Act
        var removed = service.Remove<CacheValue>("any");
        var missing = service.Exists<CacheValue>("missing");
        var nullValue = service.Exists<CacheValue>("null-value");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            removed.Should().BeFalse();
            missing.Should().BeFalse();
            nullValue.Should().BeFalse();
        }
    }
}
