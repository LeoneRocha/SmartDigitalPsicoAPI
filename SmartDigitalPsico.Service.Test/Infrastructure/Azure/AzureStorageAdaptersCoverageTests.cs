using Azure.Data.Tables;
using Azure.Storage.Blobs;
using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Azure;

[TestFixture]
public class AzureStorageAdaptersCoverageTests
{
    private const string AzuriteConnectionString =
        "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;BlobEndpoint=http://127.0.0.1:10000/devstoreaccount1;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;TableEndpoint=http://127.0.0.1:10002/devstoreaccount1;";

    // Cenário: adaptadores sem connection string.
    // Objetivo: cobrir ramos de cliente nulo.
    [Test]
    public async Task Adapters_WithoutConnection_UseNullClientSafePaths()
    {
        // Arrange
        var empty = new ConfigurationBuilder().AddInMemoryCollection().Build();
        var table = new AzureStorageTableAdapter<UserTokenSessionTableEntity>(empty, "t");
        var queue = new AzureStorageQueueAdapter(empty, "q");
        var blob = new AzureStorageBlobAdapter(empty);

        // Act / Assert
        (await table.GetAllAsync()).Should().BeEmpty();
        (await table.GetByIdAsync("p", "r")).Should().NotBeNull();
        await table.InsertAsync(new UserTokenSessionTableEntity());
        await table.UpdateAsync(new UserTokenSessionTableEntity());
        await table.DeleteAsync("p", "r");

        await queue.EnqueueMessageAsync("m");
        (await queue.DequeueMessageAsync()).Should().BeEmpty();
        await queue.DeleteMessageAsync("id", "pop");

        (await blob.UploadFileReturnUrl(new BlobFileDto { ContainerName = "c", FilePath = "x" })).Should().BeEmpty();
        (await blob.GetFileStorageUrlPublic("c", "b")).Should().BeEmpty();
        await blob.CreateContainerIfNotExists("c");
        await blob.DownloadFile("c", "b", Path.GetTempFileName());
        Assert.ThrowsAsync<InvalidOperationException>(async () => await blob.DeleteBlobAsync("c", "b"));
    }

    // Cenário: Table Adapter com Azurite.
    // Objetivo: cobrir CRUD completo do TableClient.
    [Test]
    public async Task TableAdapter_WithAzurite_PerformsCrud()
    {
        // Arrange
        AssumeAzuriteAvailable();
        var tableName = $"tok{Guid.NewGuid():N}"[..12];
        var sut = new AzureStorageTableAdapter<UserTokenSessionTableEntity>(BuildAzuriteConfig(), tableName);
        var now = DateTime.UtcNow;
        var entity = new UserTokenSessionTableEntity
        {
            PartitionKey = "p1",
            RowKey = Guid.NewGuid().ToString("N"),
            RefreshToken = "rt",
            RefreshTokenExpiryTime = now.AddDays(1),
            ExpiresAt = now.AddHours(1),
            CreatedDate = now,
            ModifyDate = now
        };

        // Act
        await sut.InsertAsync(entity);
        var byId = await sut.GetByIdAsync(entity.PartitionKey, entity.RowKey);
        var all = (await sut.GetAllAsync()).ToList();
        byId.RefreshToken = "updated";
        byId.ModifyDate = DateTime.UtcNow;
        byId.ETag = global::Azure.ETag.All;
        await sut.UpdateAsync(byId);
        var missing = await sut.GetByIdAsync("missing", "missing");
        await sut.DeleteAsync(entity.PartitionKey, entity.RowKey);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            byId.RowKey.Should().Be(entity.RowKey);
            all.Should().Contain(x => x.RowKey == entity.RowKey);
            missing.PartitionKey.Should().BeEmpty();
        }
    }

    // Cenário: Queue Adapter com Azurite.
    // Objetivo: cobrir enqueue/dequeue/delete e fila vazia.
    [Test]
    public async Task QueueAdapter_WithAzurite_EnqueuesDequeuesAndDeletes()
    {
        // Arrange
        AssumeAzuriteAvailable();
        var queueName = $"q{Guid.NewGuid():N}"[..12];
        var queueClient = CreateQueueClient(queueName);
        var sut = new AzureStorageQueueAdapter(BuildAzuriteConfig(), queueName);

        // Act
        var empty = await sut.DequeueMessageAsync();
        await sut.EnqueueMessageAsync("hello-queue");
        var message = await sut.DequeueMessageAsync();
        await sut.EnqueueMessageAsync("to-delete");
        var pending = (await queueClient.ReceiveMessagesAsync(1)).Value;
        await sut.DeleteMessageAsync(pending[0].MessageId, pending[0].PopReceipt);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            empty.Should().BeEmpty();
            message.Should().Be("hello-queue");
            pending.Should().ContainSingle();
        }
    }

    // Cenário: Blob Adapter com Azurite e cenários de validação.
    // Objetivo: cobrir upload/download/SAS/delete e ramos de erro.
    [Test]
    public async Task BlobAdapter_WithAzurite_CoversHappyPathAndValidationBranches()
    {
        // Arrange
        AssumeAzuriteAvailable();
        var cfg = BuildAzuriteConfig(includeDaysExpire: false);
        var blobService = new BlobServiceClient(AzuriteConnectionString, new BlobClientOptions(BlobClientOptions.ServiceVersion.V2020_12_06));
        var sut = new AzureStorageBlobAdapter(cfg, blobService);
        var container = $"c{Guid.NewGuid():N}"[..12];
        var tempFile = Path.GetTempFileName();
        await File.WriteAllTextAsync(tempFile, "blob-content");
        var downloadPath = Path.Combine(Path.GetTempPath(), $"dl-{Guid.NewGuid():N}.txt");

        try
        {
            // Act
            var url = await sut.UploadFileReturnUrl(new BlobFileDto
            {
                ContainerName = container,
                FilePath = tempFile,
                BlobName = "file.txt"
            });
            var sas = await sut.GetFileStorageUrlPublic(container, "file.txt");
            await sut.DownloadFile(container, "file.txt", downloadPath);
            await sut.DeleteBlobAsync(container, "file.txt");

            // Assert
            using (Assert.EnterMultipleScope())
            {
                url.Should().NotBeNullOrWhiteSpace();
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

    // Cenário: Table/Queue via configuração Azurite (sem ctor de cliente injetado).
    // Objetivo: cobrir operações CRUD/enqueue com clientes criados pelo adapter.
    [Test]
    public async Task ConfigClients_WithAzurite_CoverTableAndQueueOperations()
    {
        // Arrange
        AssumeAzuriteAvailable();
        var tableName = $"inj{Guid.NewGuid():N}"[..12];
        var queueName = $"injq{Guid.NewGuid():N}"[..12];
        var cfg = BuildAzuriteConfig();
        var table = new AzureStorageTableAdapter<UserTokenSessionTableEntity>(cfg, tableName);
        var queue = new AzureStorageQueueAdapter(cfg, queueName);
        var now = DateTime.UtcNow;
        var entity = new UserTokenSessionTableEntity
        {
            PartitionKey = "p",
            RowKey = "r1",
            RefreshTokenExpiryTime = now.AddDays(1),
            ExpiresAt = now.AddHours(1),
            CreatedDate = now,
            ModifyDate = now
        };

        // Act
        await table.InsertAsync(entity);
        await queue.EnqueueMessageAsync("injected");
        var dequeued = await queue.DequeueMessageAsync();

        // Assert
        dequeued.Should().Be("injected");
        (await table.GetByIdAsync("p", "r1")).RowKey.Should().Be("r1");
    }

    // Cenário: ctors com connection string apontando para Azurite.
    // Objetivo: cobrir CreateIfNotExists e criação de clientes no ctor.
    [Test]
    public void ConfigConstructors_WithAzurite_CreateClients()
    {
        // Arrange
        AssumeAzuriteAvailable();
        var cfg = BuildAzuriteConfig();

        // Act
        var table = new AzureStorageTableAdapter<UserTokenSessionTableEntity>(cfg, $"cfg{Guid.NewGuid():N}"[..12]);
        var queue = new AzureStorageQueueAdapter(cfg, $"cfgq{Guid.NewGuid():N}"[..12]);
        var blob = new AzureStorageBlobAdapter(cfg);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            table.Should().NotBeNull();
            queue.Should().NotBeNull();
            blob.Should().NotBeNull();
        }
    }

    private static void AssumeAzuriteAvailable()
    {
        try
        {
            CreateTableClient("healthcheck").CreateIfNotExists();
        }
        catch (Exception ex)
        {
            Assert.Ignore($"Azurite unavailable or incompatible: {ex.Message}");
        }
    }

    private static TableClient CreateTableClient(string tableName)
        => new(AzuriteConnectionString, tableName, new TableClientOptions(TableClientOptions.ServiceVersion.V2020_12_06));

    private static QueueClient CreateQueueClient(string queueName)
        => new(AzuriteConnectionString, queueName, new QueueClientOptions(QueueClientOptions.ServiceVersion.V2020_12_06));

    private static IConfiguration BuildAzuriteConfig(bool includeDaysExpire = true)
    {
        var values = new Dictionary<string, string?>
        {
            ["StorageServices:AzureStorage:ConnectionString"] = AzuriteConnectionString
        };
        if (includeDaysExpire)
        {
            values["StorageServices:AzureStorage:DaysExpiresBlobSas"] = "7";
        }
        return new ConfigurationBuilder().AddInMemoryCollection(values).Build();
    }
}
