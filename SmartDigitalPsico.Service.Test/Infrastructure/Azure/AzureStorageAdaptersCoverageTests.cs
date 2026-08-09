using SmartDigitalPsico.Service;
using Azure;
using Azure.Data.Tables;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Azure;
                                
[TestFixture]
public class AzureStorageAdaptersCoverageTests
{
    // Cenário: adaptadores sem connection string.
    // Objetivo: cobrir ramos de cliente nulo.
    [Test]
    public async Task Adapters_WithoutConnection_UseNullClientSafePaths()
    {
        // Arrange
        var empty = new ConfigurationBuilder().AddInMemoryCollection().Build();
        var table = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity>(empty, "t");
        var queue = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter(empty, "q");
        var blob = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(empty);

        // Act
        var all = await table.GetAllAsync();
        var byId = await table.GetByIdAsync("p", "r");
        await table.InsertAsync(new UserTokenSessionTableEntity());
        await table.UpdateAsync(new UserTokenSessionTableEntity());
        await table.DeleteAsync("p", "r");
        await queue.EnqueueMessageAsync("m");
        var dequeued = await queue.DequeueMessageAsync();
        await queue.DeleteMessageAsync("id", "pop");
        var uploadUrl = await blob.UploadFileReturnUrl(new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto { ContainerName = "c", FilePath = "x" });
        var publicUrl = await blob.GetFileStorageUrlPublic("c", "b");
        await blob.CreateContainerIfNotExists("c");
        await blob.DownloadFile("c", "b", Path.GetTempFileName());

        // Assert
        using (Assert.EnterMultipleScope())
        {
            all.Should().BeEmpty();
            byId.Should().NotBeNull();
            dequeued.Should().BeEmpty();
            uploadUrl.Should().BeEmpty();
            publicUrl.Should().BeEmpty();
        }
        Assert.ThrowsAsync<InvalidOperationException>(async () => await blob.DeleteBlobAsync("c", "b"));
    }

    // Cenário: Table Adapter com TableClient injetado (sem Azurite).
    // Objetivo: cobrir CRUD completo do TableClient.
    [Test]
    public async Task TableAdapter_WithInjectedClient_PerformsCrud()
    {
        // Arrange
        var entity = new UserTokenSessionTableEntity
        {
            PartitionKey = "p1",
            RowKey = Guid.NewGuid().ToString("N"),
            RefreshToken = "rt",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1),
            ExpiresAt = DateTime.UtcNow.AddHours(1),
            CreatedDate = DateTime.UtcNow,
            ModifyDate = DateTime.UtcNow,
            ETag = ETag.All
        };

        var tableClient = new Mock<TableClient>();
        var found = new Mock<NullableResponse<UserTokenSessionTableEntity>>();
        found.SetupGet(x => x.HasValue).Returns(true);
        found.SetupGet(x => x.Value).Returns(entity);

        var missing = new Mock<NullableResponse<UserTokenSessionTableEntity>>();
        missing.SetupGet(x => x.HasValue).Returns(false);

        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<UserTokenSessionTableEntity>(
                entity.PartitionKey, entity.RowKey, It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(found.Object);
        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<UserTokenSessionTableEntity>(
                "missing", "missing", It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(missing.Object);
        tableClient
            .Setup(x => x.QueryAsync<UserTokenSessionTableEntity>(
                It.IsAny<string>(), It.IsAny<int?>(), It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .Returns(AsyncPageable<UserTokenSessionTableEntity>.FromPages(
            [
                Page<UserTokenSessionTableEntity>.FromValues([entity], null, Mock.Of<Response>())
            ]));
        tableClient
            .Setup(x => x.AddEntityAsync(It.IsAny<UserTokenSessionTableEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());
        tableClient
            .Setup(x => x.UpdateEntityAsync(
                It.IsAny<UserTokenSessionTableEntity>(), It.IsAny<ETag>(), It.IsAny<TableUpdateMode>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());
        tableClient
            .Setup(x => x.DeleteEntityAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ETag>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());

        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity>(tableClient.Object);

        // Act
        await sut.InsertAsync(entity);
        var byId = await sut.GetByIdAsync(entity.PartitionKey, entity.RowKey);
        var all = (await sut.GetAllAsync()).ToList();
        byId.RefreshToken = "updated";
        await sut.UpdateAsync(byId);
        var notFound = await sut.GetByIdAsync("missing", "missing");
        await sut.DeleteAsync(entity.PartitionKey, entity.RowKey);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            byId.RowKey.Should().Be(entity.RowKey);
            all.Should().Contain(x => x.RowKey == entity.RowKey);
            notFound.PartitionKey.Should().BeEmpty();
        }
        tableClient.Verify(x => x.AddEntityAsync(entity, It.IsAny<CancellationToken>()), Times.Once);
        tableClient.Verify(x => x.DeleteEntityAsync(entity.PartitionKey, entity.RowKey, It.IsAny<ETag>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    // Cenário: Queue Adapter com QueueClient injetado (sem Azurite).
    // Objetivo: cobrir enqueue/dequeue/delete e fila vazia.
    [Test]
    public async Task QueueAdapter_WithInjectedClient_EnqueuesDequeuesAndDeletes()
    {
        // Arrange
        var queueClient = new Mock<QueueClient>();
        queueClient
            .Setup(x => x.SendMessageAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response<SendReceipt>>());
        queueClient
            .Setup(x => x.SendMessageAsync(It.IsAny<string>()))
            .ReturnsAsync(Mock.Of<Response<SendReceipt>>());
        queueClient
            .SetupSequence(x => x.ReceiveMessagesAsync(1, It.IsAny<TimeSpan?>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Response.FromValue(Array.Empty<QueueMessage>(), Mock.Of<Response>()))
            .ReturnsAsync(Response.FromValue(
                new[] { QueuesModelFactory.QueueMessage("id1", "pop1", "hello-queue", dequeueCount: 1) },
                Mock.Of<Response>()));
        queueClient
            .Setup(x => x.DeleteMessageAsync("id1", "pop1", It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());

        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter(queueClient.Object);

        // Act
        var empty = await sut.DequeueMessageAsync();
        await sut.EnqueueMessageAsync("hello-queue");
        var message = await sut.DequeueMessageAsync();
        await sut.DeleteMessageAsync("id1", "pop1");

        // Assert
        using (Assert.EnterMultipleScope())
        {
            empty.Should().BeEmpty();
            message.Should().Be("hello-queue");
        }
        queueClient.Verify(x => x.SendMessageAsync("hello-queue"), Times.Once);
        queueClient.Verify(x => x.DeleteMessageAsync("id1", "pop1", It.IsAny<CancellationToken>()), Times.Once);
    }

    // Cenário: Blob Adapter com BlobServiceClient injetado (sem Azurite).
    // Objetivo: cobrir upload/download/SAS/delete e ramos de erro.
    [Test]
    public async Task BlobAdapter_WithInjectedClient_CoversHappyPathAndValidationBranches()
    {
        // Arrange
        var cfg = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["StorageServices:AzureStorage:DaysExpiresBlobSas"] = "7"
            })
            .Build();

        var tempFile = Path.GetTempFileName();
        var downloadPath = Path.Combine(Path.GetTempPath(), $"dl-{Guid.NewGuid():N}.txt");
        await File.WriteAllTextAsync(tempFile, "blob-content");

        var blobClient = new Mock<BlobClient>();
        blobClient.SetupGet(x => x.Uri).Returns(new Uri("http://localhost/c/file.txt"));
        blobClient.SetupGet(x => x.CanGenerateSasUri).Returns(true);
        blobClient
            .Setup(x => x.GenerateSasUri(It.IsAny<BlobSasBuilder>()))
            .Returns(new Uri("http://localhost/c/file.txt?sas=1"));
        blobClient
            .Setup(x => x.UploadAsync(
                It.IsAny<string>(),
                It.IsAny<BlobHttpHeaders>(),
                It.IsAny<IDictionary<string, string>>(),
                It.IsAny<BlobRequestConditions>(),
                It.IsAny<IProgress<long>>(),
                It.IsAny<AccessTier?>(),
                It.IsAny<StorageTransferOptions>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response<BlobContentInfo>>());
        blobClient
            .Setup(x => x.DownloadToAsync(It.IsAny<Stream>(), It.IsAny<CancellationToken>()))
            .Returns<Stream, CancellationToken>(async (stream, cancellationToken) =>
            {
                var bytes = await File.ReadAllBytesAsync(tempFile, cancellationToken);
                await stream.WriteAsync(bytes, cancellationToken);
                return Mock.Of<Response>(r => r.Status == 200);
            });
        blobClient
            .Setup(x => x.DeleteIfExistsAsync(It.IsAny<DeleteSnapshotsOption>(), It.IsAny<BlobRequestConditions>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Response.FromValue(true, Mock.Of<Response>()));

        var containerClient = new Mock<BlobContainerClient>();
        containerClient
            .Setup(x => x.CreateIfNotExistsAsync(It.IsAny<PublicAccessType>(), It.IsAny<IDictionary<string, string>>(), It.IsAny<BlobContainerEncryptionScopeOptions>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response<BlobContainerInfo>>());
        containerClient.Setup(x => x.GetBlobClient(It.IsAny<string>())).Returns(blobClient.Object);

        var blobService = new Mock<BlobServiceClient>();
        blobService.Setup(x => x.GetBlobContainerClient(It.IsAny<string>())).Returns(containerClient.Object);

        var sut = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(cfg, blobService.Object);

        try
        {
            // Act
            var url = await sut.UploadFileReturnUrl(new SmartDigitalPsico.Core.SDK.Domain.DTO.BlobFileDto
            {
                ContainerName = "container1",
                FilePath = tempFile,
                BlobName = "file.txt"
            });
            var sas = await sut.GetFileStorageUrlPublic("container1", "file.txt");
            await sut.DownloadFile("container1", "file.txt", downloadPath);
            await sut.DeleteBlobAsync("container1", "file.txt");

            // Assert
            using (Assert.EnterMultipleScope())
            {
                url.Should().Be("http://localhost/c/file.txt");
                sas.Should().Contain("sas=1");
                File.Exists(downloadPath).Should().BeTrue();
            }

            Assert.ThrowsAsync<AppWarningException>(async () => await sut.CreateContainerIfNotExists(""));
            Assert.ThrowsAsync<AppWarningException>(async () => await sut.CreateContainerIfNotExists(new string('a', 64)));
            Assert.ThrowsAsync<ArgumentException>(async () => await sut.GetFileStorageUrlPublic("", "b"));
            Assert.ThrowsAsync<ArgumentException>(async () => await sut.GetFileStorageUrlPublic("c", ""));
        }
        finally
        {
            if (File.Exists(tempFile)) File.Delete(tempFile);
            if (File.Exists(downloadPath)) File.Delete(downloadPath);
        }
    }

    // Cenário: Table/Queue via clientes injetados (sem Azurite).
    // Objetivo: cobrir operações CRUD/enqueue com clientes criados pelo adapter.
    [Test]
    public async Task InjectedClients_CoverTableAndQueueOperations()
    {
        // Arrange
        var entity = new UserTokenSessionTableEntity
        {
            PartitionKey = "p",
            RowKey = "r1",
            RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(1),
            ExpiresAt = DateTime.UtcNow.AddHours(1),
            CreatedDate = DateTime.UtcNow,
            ModifyDate = DateTime.UtcNow
        };

        var tableClient = new Mock<TableClient>();
        var found = new Mock<NullableResponse<UserTokenSessionTableEntity>>();
        found.SetupGet(x => x.HasValue).Returns(true);
        found.SetupGet(x => x.Value).Returns(entity);
        tableClient
            .Setup(x => x.AddEntityAsync(It.IsAny<UserTokenSessionTableEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());
        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<UserTokenSessionTableEntity>(
                "p", "r1", It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(found.Object);

        var queueClient = new Mock<QueueClient>();
        queueClient
            .Setup(x => x.SendMessageAsync("injected", It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response<SendReceipt>>());
        queueClient
            .Setup(x => x.SendMessageAsync("injected"))
            .ReturnsAsync(Mock.Of<Response<SendReceipt>>());
        queueClient
            .Setup(x => x.ReceiveMessagesAsync(1, It.IsAny<TimeSpan?>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Response.FromValue(
                new[] { QueuesModelFactory.QueueMessage("id", "pop", "injected", dequeueCount: 1) },
                Mock.Of<Response>()));

        var table = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity>(tableClient.Object);
        var queue = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter(queueClient.Object);

        // Act
        await table.InsertAsync(entity);
        await queue.EnqueueMessageAsync("injected");
        var dequeued = await queue.DequeueMessageAsync();

        // Assert
        dequeued.Should().Be("injected");
        (await table.GetByIdAsync("p", "r1")).RowKey.Should().Be("r1");
    }

    // Cenário: ctors com clientes injetados.
    // Objetivo: cobrir criação dos adapters sem depender de Azurite.
    [Test]
    public void InjectedConstructors_CreateAdapters()
    {
        // Arrange
        var table = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageTableAdapter<UserTokenSessionTableEntity>(new Mock<TableClient>().Object);
        var queue = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageQueueAdapter(new Mock<QueueClient>().Object);
        var blob = new SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage.AzureStorageBlobAdapter(
            new ConfigurationBuilder().AddInMemoryCollection().Build(),
            new Mock<BlobServiceClient>().Object);

        // Act

        // Assert
        using (Assert.EnterMultipleScope())
        {
            table.Should().NotBeNull();
            queue.Should().NotBeNull();
            blob.Should().NotBeNull();
        }
    }
}
