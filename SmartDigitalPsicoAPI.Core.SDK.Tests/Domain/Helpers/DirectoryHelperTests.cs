using Microsoft.Extensions.Configuration;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsicoAPI.Core.SDK.Tests.Helpers;

[TestFixture]
public class DirectoryHelperTests
{
    private string _tempPath = null!;

    [SetUp]
    public void SetUp() => _tempPath = Path.Combine(Path.GetTempPath(), $"smartdigitalpsico-{Guid.NewGuid():N}");

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_tempPath))
            Directory.Delete(_tempPath, true);
    }

    [Test]
    public void GetDiretory_AbsolutePath_CreatesAndReturnsPath()
    {
        // CenÃ¡rio: o caminho configurado Ã© absoluto.
        // Objetivo: criar e retornar o mesmo caminho absoluto.
        // Arrange
        var path = Path.Combine(_tempPath, "absolute");

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretory(path);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    [Test]
    public void GetDiretoryTemp_ConfiguredAbsolutePath_CreatesConfiguredDirectory()
    {
        // CenÃ¡rio: o diretÃ³rio temporÃ¡rio vem de configuraÃ§Ã£o em memÃ³ria.
        // Objetivo: retornar o diretÃ³rio configurado.
        // Arrange
        var path = Path.Combine(_tempPath, "temp");
        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = path })
            .Build();

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(configuration);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    [Test]
    public void GetPathSaveCache_AbsolutePath_CreatesAndReturnsPath()
    {
        // CenÃ¡rio: o cache usa caminho absoluto.
        // Objetivo: criar o diretÃ³rio de cache.
        // Arrange
        var path = Path.Combine(_tempPath, "cache");

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DirectoryHelper.GetPathSaveCache(path);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    // CenÃ¡rio: diretÃ³rios relativos ainda nÃ£o existem.
    // Objetivo: resolver a partir do diretÃ³rio atual e criar cada segmento.
    [Test]
    public void DirectoryMethods_RelativePaths_CreatesAndReturnsResolvedPaths()
    {
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var originalDirectory = Directory.GetCurrentDirectory();
        Directory.SetCurrentDirectory(_tempPath);

        try
        {
            // Act
            var directory = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretory("./files/nested");
            var cache = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DirectoryHelper.GetPathSaveCache("./cache/nested");

            // Assert
            directory.Should().Be(Path.Combine(_tempPath, "files", "nested"));
            cache.Should().Be(Path.Combine(_tempPath, "cache", "nested"));
            Directory.Exists(directory).Should().BeTrue();
            Directory.Exists(cache).Should().BeTrue();
        }
        finally
        {
            Directory.SetCurrentDirectory(originalDirectory);
        }
    }
}


