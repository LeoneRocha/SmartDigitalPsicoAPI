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
using SmartDigitalPsico.Core.SDK.Domain.DTO;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Core.SDK.Tests.Service.Infrastructure.Azure;

[TestFixture]
public class AzureStorageAdaptersCoverageTests
{
    public sealed class TestTableEntity : BaseEntityTable
    {
        public string Payload { get; set; } = string.Empty;
    }

    [Test]
    public async Task Adapters_WithoutConnection_UseNullClientSafePaths()
    {
        var empty = new ConfigurationBuilder().AddInMemoryCollection().Build();
        var table = new AzureStorageTableAdapter<TestTableEntity>(empty, "t");
        var queue = new AzureStorageQueueAdapter(empty, "q");
        var blob = new AzureStorageBlobAdapter(empty);

        var all = await table.GetAllAsync();
        var byId = await table.GetByIdAsync("p", "r");
        await table.InsertAsync(new TestTableEntity());
        await table.UpdateAsync(new TestTableEntity());
        await table.DeleteAsync("p", "r");
        await queue.EnqueueMessageAsync("m");
        var dequeued = await queue.DequeueMessageAsync();
        await queue.DeleteMessageAsync("id", "pop");
        var uploadUrl = await blob.UploadFileReturnUrl(new BlobFileDto { ContainerName = "c", FilePath = "x" });
        var publicUrl = await blob.GetFileStorageUrlPublic("c", "b");
        await blob.CreateContainerIfNotExists("c");
        await blob.DownloadFile("c", "b", Path.GetTempFileName());

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

    [Test]
    public async Task TableAdapter_WithInjectedClient_PerformsCrud()
    {
        var entity = new TestTableEntity
        {
            PartitionKey = "p1",
            RowKey = Guid.NewGuid().ToString("N"),
            Payload = "rt",
            ETag = ETag.All
        };

        var tableClient = new Mock<TableClient>();
        var found = new Mock<NullableResponse<TestTableEntity>>();
        found.SetupGet(x => x.HasValue).Returns(true);
        found.SetupGet(x => x.Value).Returns(entity);

        var missing = new Mock<NullableResponse<TestTableEntity>>();
        missing.SetupGet(x => x.HasValue).Returns(false);

        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<TestTableEntity>(
                entity.PartitionKey, entity.RowKey, It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(found.Object);
        tableClient
            .Setup(x => x.GetEntityIfExistsAsync<TestTableEntity>(
                "missing", "missing", It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(missing.Object);
        tableClient
            .Setup(x => x.QueryAsync<TestTableEntity>(
                It.IsAny<string>(), It.IsAny<int?>(), It.IsAny<IEnumerable<string>>(), It.IsAny<CancellationToken>()))
            .Returns(AsyncPageable<TestTableEntity>.FromPages(
            [
                Page<TestTableEntity>.FromValues([entity], null, Mock.Of<Response>())
            ]));
        tableClient
            .Setup(x => x.AddEntityAsync(It.IsAny<TestTableEntity>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());
        tableClient
            .Setup(x => x.UpdateEntityAsync(
                It.IsAny<TestTableEntity>(), It.IsAny<ETag>(), It.IsAny<TableUpdateMode>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());
        tableClient
            .Setup(x => x.DeleteEntityAsync(
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<ETag>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(Mock.Of<Response>());

        var sut = new AzureStorageTableAdapter<TestTableEntity>(tableClient.Object);

        await sut.InsertAsync(entity);
        var byId = await sut.GetByIdAsync(entity.PartitionKey, entity.RowKey);
        var all = (await sut.GetAllAsync()).ToList();
        byId.Payload = "updated";
        await sut.UpdateAsync(byId);
        var notFound = await sut.GetByIdAsync("missing", "missing");
        await sut.DeleteAsync(entity.PartitionKey, entity.RowKey);

        using (Assert.EnterMultipleScope())
        {
            byId.RowKey.Should().Be(entity.RowKey);
            all.Should().Contain(x => x.RowKey == entity.RowKey);
            notFound.PartitionKey.Should().BeEmpty();
        }
    }

    [Test]
    public async Task QueueAdapter_WithInjectedClient_EnqueuesDequeuesAndDeletes()
    {
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

        var sut = new AzureStorageQueueAdapter(queueClient.Object);

        var empty = await sut.DequeueMessageAsync();
        await sut.EnqueueMessageAsync("hello-queue");
        var message = await sut.DequeueMessageAsync();
        await sut.DeleteMessageAsync("id1", "pop1");

        using (Assert.EnterMultipleScope())
        {
            empty.Should().BeEmpty();
            message.Should().Be("hello-queue");
        }
    }

    [Test]
    public async Task BlobAdapter_WithInjectedClient_CoversHappyPathAndValidationBranches()
    {
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

        var sut = new AzureStorageBlobAdapter(cfg, blobService.Object);

        try
        {
            var url = await sut.UploadFileReturnUrl(new BlobFileDto
            {
                ContainerName = "container1",
                FilePath = tempFile,
                BlobName = "file.txt"
            });
            var sas = await sut.GetFileStorageUrlPublic("container1", "file.txt");
            await sut.DownloadFile("container1", "file.txt", downloadPath);
            await sut.DeleteBlobAsync("container1", "file.txt");
            await sut.CreateContainerIfNotExists("validname");

            using (Assert.EnterMultipleScope())
            {
                url.Should().Be("http://localhost/c/file.txt");
                sas.Should().Contain("sas=1");
                File.Exists(downloadPath).Should().BeTrue();
                AzureStorageBlobAdapter.ResolveBlobName(null, tempFile).Should().Be(Path.GetFileName(tempFile));
                AzureStorageBlobAdapter.ResolveBlobName("explicit", tempFile).Should().Be("explicit");
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

    [Test]
    public void InjectedConstructors_CreateAdapters()
    {
        var table = new AzureStorageTableAdapter<TestTableEntity>(new Mock<TableClient>().Object);
        var queue = new AzureStorageQueueAdapter(new Mock<QueueClient>().Object);
        var blob = new AzureStorageBlobAdapter(
            new ConfigurationBuilder().AddInMemoryCollection().Build(),
            new Mock<BlobServiceClient>().Object);

        using (Assert.EnterMultipleScope())
        {
            table.Should().NotBeNull();
            queue.Should().NotBeNull();
            blob.Should().NotBeNull();
        }
    }

    [Test]
    public async Task BlobAdapter_CanGenerateSasFalse_ReturnsEmpty()
    {
        var blobClient = new Mock<BlobClient>();
        blobClient.SetupGet(x => x.CanGenerateSasUri).Returns(false);
        var containerClient = new Mock<BlobContainerClient>();
        containerClient.Setup(x => x.GetBlobClient(It.IsAny<string>())).Returns(blobClient.Object);
        var blobService = new Mock<BlobServiceClient>();
        blobService.Setup(x => x.GetBlobContainerClient(It.IsAny<string>())).Returns(containerClient.Object);

        var sut = new AzureStorageBlobAdapter(new ConfigurationBuilder().AddInMemoryCollection().Build(), blobService.Object);
        (await sut.GetFileStorageUrlPublic("c", "b")).Should().BeEmpty();
    }
}
