using Microsoft.Extensions.Options;
using Moq;
using SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager;
using SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Core.SDK.Tests.Data.Repository.CacheManager;

[TestFixture]
public class DiskCacheRepositoryTests
{
    private string _temporaryDirectory = null!;

    [SetUp]
    public void SetUp()
    {
        _temporaryDirectory = Path.Combine(Path.GetTempPath(), $"core-sdk-diskcache-{Guid.NewGuid():N}");
        Directory.CreateDirectory(_temporaryDirectory);
    }

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_temporaryDirectory))
            Directory.Delete(_temporaryDirectory, recursive: true);
    }

    [Test]
    public async Task StoresRetrievesAndRemovesJsonValues()
    {
        var repository = new FileDiskRepository();
        var cache = new DiskCacheRepository(repository, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        (await cache.TryGetAsync<CacheValue>("missing")).Key.Should().BeFalse();
        (await cache.SetAsync("entry", new CacheValue { Name = "first" })).Should().BeTrue();
        var cached = await cache.TryGetAsync<CacheValue>("entry");

        cached.Key.Should().BeTrue();
        cached.Value.Name.Should().Be("first");

        (await cache.SetAsync("entry", new CacheValue { Name = "second" })).Should().BeTrue();
        (await cache.TryGetAsync<CacheValue>("entry")).Value.Name.Should().Be("second");
        (await cache.RemoveAsync("entry")).Should().BeTrue();
        (await cache.TryGetAsync<CacheValue>("entry")).Key.Should().BeFalse();
    }

    [Test]
    public async Task DefaultDeserializedValue_ReturnsMiss()
    {
        var disk = new Mock<IFileDiskRepository>();
        disk.Setup(value => value.Exists(It.IsAny<FileData>())).Returns(true);
        disk.Setup(value => value.Get(It.IsAny<FileData>())).ReturnsAsync(System.Text.Encoding.UTF8.GetBytes("null"));
        var cache = new DiskCacheRepository(disk.Object, Options.Create(new CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        var result = await cache.TryGetAsync<CachePayload>("default-null");

        result.Key.Should().BeFalse();
    }

    [Test]
    public async Task RelativePathCache_CreatesDirectoryAndStores()
    {
        var relative = Path.Combine(".", $"rel-cache-{Guid.NewGuid():N}");
        var repository = new FileDiskRepository();
        var cache = new DiskCacheRepository(repository, Options.Create(new CacheConfigurationDto
        {
            PathCache = relative.Replace('\\', '/'),
            ExtensionCache = ".cache"
        }));

        try
        {
            (await cache.SetAsync("rel", new CacheValue { Name = "ok" })).Should().BeTrue();
            (await cache.TryGetAsync<CacheValue>("rel")).Value.Name.Should().Be("ok");
        }
        finally
        {
            var absolute = Path.Combine(Directory.GetCurrentDirectory(), relative.TrimStart('.', '/', '\\'));
            if (Directory.Exists(absolute))
                Directory.Delete(absolute, recursive: true);
        }
    }

    private sealed class CacheValue
    {
        public string Name { get; set; } = string.Empty;
    }

    private sealed class CachePayload
    {
        public string? Value { get; set; }
    }
}
