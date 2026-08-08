using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Test.Helpers;

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
        // Cenário: o caminho configurado é absoluto.
        // Objetivo: criar e retornar o mesmo caminho absoluto.
        // Arrange
        var path = Path.Combine(_tempPath, "absolute");

        // Act
        var result = SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretory(path);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    [Test]
    public void GetDiretoryTemp_ConfiguredAbsolutePath_CreatesConfiguredDirectory()
    {
        // Cenário: o diretório temporário vem de configuração em memória.
        // Objetivo: retornar o diretório configurado.
        // Arrange
        var path = Path.Combine(_tempPath, "temp");
        IConfiguration configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = path })
            .Build();

        // Act
        var result = SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(configuration);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    [Test]
    public void GetPathSaveCache_AbsolutePath_CreatesAndReturnsPath()
    {
        // Cenário: o cache usa caminho absoluto.
        // Objetivo: criar o diretório de cache.
        // Arrange
        var path = Path.Combine(_tempPath, "cache");

        // Act
        var result = SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetPathSaveCache(path);

        // Assert
        result.Should().Be(path);
        Directory.Exists(path).Should().BeTrue();
    }

    // Cenário: diretórios relativos ainda não existem.
    // Objetivo: resolver a partir do diretório atual e criar cada segmento.
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
            var directory = SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretory("./files/nested");
            var cache = SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetPathSaveCache("./cache/nested");

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
