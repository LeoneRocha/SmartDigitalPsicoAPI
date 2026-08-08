using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using Microsoft.Extensions.Options;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class FileAndDiskCacheRepositoryTests
{
    private string _temporaryDirectory = null!;

    [SetUp]
    public void SetUp()
    {
        _temporaryDirectory = Path.Combine(Path.GetTempPath(), $"smart-digital-psico-{Guid.NewGuid():N}");
    }

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_temporaryDirectory))
            Directory.Delete(_temporaryDirectory, recursive: true);
    }

    // Cenário: salvar, ler, substituir e excluir arquivo em disco.
    // Objetivo: cobrir Save, Exists, Get e Delete do SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository.
    [Test]
    public async Task FileDiskRepository_PersistsReadsReplacesAndDeletesFiles()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var criteria = new FileData
        {
            FolderDestination = _temporaryDirectory,
            FilePath = _temporaryDirectory,
            FileName = "payload.bin",
            FileData = [1, 2, 3]
        };

        // Act
        (await repository.Save(new FileData { FileData = null! })).Should().BeFalse();
        (await repository.Save(criteria)).Should().BeTrue();
        repository.Exists(criteria).Should().BeTrue();
        (await repository.Get(criteria)).Should().Equal(1, 2, 3);

        criteria.FileData = [4, 5];
        (await repository.Save(criteria)).Should().BeTrue();
        (await repository.Get(new FileData { FilePath = Path.Combine(_temporaryDirectory, criteria.FileName), FileName = "ignored" })).Should().Equal(4, 5);
        (await repository.Get(new FileData { FilePath = Path.Combine(_temporaryDirectory, "missing.bin"), FileName = "missing.bin" })).Should().BeEmpty();

        await repository.Delete(criteria);

        // Assert
        repository.Exists(criteria).Should().BeFalse();
        await repository.Delete(new FileData { FilePath = Path.Combine(_temporaryDirectory, "missing.bin"), FileName = "missing.bin" });
    }

    // Cenário: cache em disco com valores JSON serializados.
    // Objetivo: cobrir Set, TryGet e Remove do SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository.
    [Test]
    public async Task DiskCacheRepository_StoresRetrievesAndRemovesJsonValues()
    {
        // Arrange
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        var cache = new SmartDigitalPsico.Core.SDK.Data.Repository.CacheManager.DiskCacheRepository(repository, Options.Create(new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto
        {
            PathCache = _temporaryDirectory,
            ExtensionCache = ".cache"
        }));

        // Act
        (await cache.TryGetAsync<CacheValue>("missing")).Key.Should().BeFalse();
        (await cache.SetAsync("entry", new CacheValue { Name = "first" })).Should().BeTrue();
        var cached = await cache.TryGetAsync<CacheValue>("entry");

        // Assert
        cached.Key.Should().BeTrue();
        cached.Value.Name.Should().Be("first");

        (await cache.SetAsync("entry", new CacheValue { Name = "second" })).Should().BeTrue();
        (await cache.TryGetAsync<CacheValue>("entry")).Value.Name.Should().Be("second");
        (await cache.RemoveAsync("entry")).Should().BeTrue();
        (await cache.TryGetAsync<CacheValue>("entry")).Key.Should().BeFalse();
    }

    private sealed class CacheValue
    {
        public string Name { get; set; } = string.Empty;
    }
}
