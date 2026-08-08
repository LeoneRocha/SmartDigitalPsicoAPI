using Bogus;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsicoAPI.Core.SDK.Domain.AppException;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using System.Text;

namespace SmartDigitalPsicoAPI.Core.SDK.Tests.Helpers;

[TestFixture]
public class FileHelperTests
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
    public async Task FileOperations_ValidInputs_ProcessesFiles()
    {
        // CenÃ¡rio: arquivos temporÃ¡rios sÃ£o usados nas operaÃ§Ãµes de leitura, cÃ³pia e exclusÃ£o.
        // Objetivo: validar os fluxos bem-sucedidos do helper.
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var faker = new Faker();
        var content = faker.Lorem.Sentence();
        var source = Path.Combine(_tempPath, "source.txt");
        var destination = Path.Combine(_tempPath, "destination.txt");
        await File.WriteAllTextAsync(source, content);

        // Act
        var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser(source);
        await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.CopyFile(source, destination);
        await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.Delete(destination);

        // Assert
        result.FileContents.Should().BeEquivalentTo(Encoding.UTF8.GetBytes(content));
        result.ContentType.Should().Be("text/plain");
        File.Exists(destination).Should().BeFalse();
    }

    [Test]
    public async Task FormFiles_ValidInput_ReturnsContentAndBytes()
    {
        // CenÃ¡rio: um upload contÃ©m texto UTF-8.
        // Objetivo: ler o upload como texto e bytes.
        // Arrange
        var data = Encoding.UTF8.GetBytes("conteÃºdo de teste");
        var file = new FormFile(new MemoryStream(data), 0, data.Length, "file", "input.txt");

        // Act
        var text = await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileFormDataUpload(file);
        var bytes = await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetByteDataFromIFormFile(file);

        // Assert
        text.Should().Be("conteÃºdo de teste");
        bytes.Should().BeEquivalentTo(data);
    }

    [Test]
    public async Task GetFileByRequest_FileWithName_SavesAndReturnsRelativePath()
    {
        // CenÃ¡rio: a requisiÃ§Ã£o possui um arquivo vÃ¡lido.
        // Objetivo: persistir o arquivo no diretÃ³rio de destino.
        // Arrange
        var folder = Path.Combine(_tempPath, "upload");
        Directory.CreateDirectory(folder);
        var file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("upload")), 0, 6, "file", "report.txt")
        {
            Headers = new HeaderDictionary { ["Content-Disposition"] = "form-data; name=\"file\"; filename=\"report.txt\"" }
        };
        var request = new Mock<HttpRequest>();
        request.SetupGet(x => x.Form).Returns(new FormCollection(new Dictionary<string, Microsoft.Extensions.Primitives.StringValues>(), new FormFileCollection { file }));
        var originalDirectory = Directory.GetCurrentDirectory();
        Directory.SetCurrentDirectory(_tempPath);

        try
        {
            // Act
            var result = await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileByRequest(request.Object, "upload");

            // Assert
            result.Should().Be(Path.Combine("upload", "report.txt"));
            (await File.ReadAllTextAsync(Path.Combine(folder, "report.txt"))).Should().Be("upload");
        }
        finally
        {
            Directory.SetCurrentDirectory(originalDirectory);
        }
    }

    [Test]
    public async Task GetFileByRequest_EmptyOrMissingName_ReturnsEmptyOrThrowsWarning()
    {
        // CenÃ¡rio: uploads vazio e sem nome no content disposition.
        // Objetivo: cobrir os retornos alternativos da requisiÃ§Ã£o.
        // Arrange
        var empty = new Mock<IFormFile>();
        empty.SetupGet(x => x.Length).Returns(0);
        var emptyRequest = new Mock<HttpRequest>();
        emptyRequest.SetupGet(x => x.Form).Returns(new FormCollection(new Dictionary<string, Microsoft.Extensions.Primitives.StringValues>(), new FormFileCollection { empty.Object }));
        var unnamed = new Mock<IFormFile>();
        unnamed.SetupGet(x => x.Length).Returns(1);
        unnamed.SetupGet(x => x.ContentDisposition).Returns("form-data; name=\"file\"");
        var unnamedRequest = new Mock<HttpRequest>();
        unnamedRequest.SetupGet(x => x.Form).Returns(new FormCollection(new Dictionary<string, Microsoft.Extensions.Primitives.StringValues>(), new FormFileCollection { unnamed.Object }));

        // Act
        var emptyResult = await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileByRequest(emptyRequest.Object, "ignored");
        var action = async () => await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileByRequest(unnamedRequest.Object, "ignored");

        // Assert
        emptyResult.Should().BeEmpty();
        await action.Should().ThrowAsync<AppWarningException>();
    }

    [Test]
    public async Task UtilityMethods_EdgeCases_ReturnExpectedValues()
    {
        // CenÃ¡rio: caminhos, base64 e arquivos temporÃ¡rios tÃªm entradas distintas.
        // Objetivo: validar normalizaÃ§Ã£o e ramificaÃ§Ãµes de utilitÃ¡rios.
        // Arrange
        var relative = Path.Combine(".", "folder", "..", "file.txt");
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = _tempPath }).Build();
        var output = Path.Combine(_tempPath, "bytes.bin");

        // Act
        Directory.CreateDirectory(_tempPath);
        await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp([1, 2, 3], "bytes.bin", config);
        await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(null!, "ignored.bin", config);
        var missingCopy = async () => await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.CopyFile(Path.Combine(_tempPath, "missing"), output);
        var missingDelete = async () => await SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.Delete(output + ".missing");

        // Assert
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileExtension("application/json").Should().Be("jso");
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(relative).Should().Be(Path.GetFullPath(relative));
        ((Action)(() => SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(" "))).Should().Throw<ArgumentException>();
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileFromBase64String(Convert.ToBase64String(Encoding.UTF8.GetBytes("ok"))).Should().Be("ok");
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFileFromBase64String(string.Empty).Should().BeEmpty();
        File.ReadAllBytes(output).Should().BeEquivalentTo([1, 2, 3]);
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetContentType("unknown.custom").Should().Be("application/octet-stream");
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetSameName("archive.tar.gz").Should().Be("archive.tar.gz");
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFilePath(_tempPath, "bytes.bin").Should().Be(output);
        await missingCopy.Should().ThrowAsync<FileNotFoundException>();
        await missingDelete.Should().ThrowAsync<FileNotFoundException>();
    }

    // CenÃ¡rio: origem relativa e download pelo diretÃ³rio sÃ£o solicitados.
    // Objetivo: compor o caminho relativo e retornar o conteÃºdo para o navegador.
    [Test]
    public void Download_RelativeFolder_ReturnsFileContent()
    {
        // Arrange
        var originalDirectory = Directory.GetCurrentDirectory();
        Directory.CreateDirectory(_tempPath);
        Directory.SetCurrentDirectory(_tempPath);
        Directory.CreateDirectory("downloads");
        File.WriteAllText(Path.Combine("downloads", "report.txt"), "conteÃºdo");

        try
        {
            // Act
            var filePath = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.GetFilePath("downloads", "report.txt");
            var result = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser("downloads", "report.txt");

            // Assert
            using (Assert.EnterMultipleScope())
            {
                filePath.Should().Be(Path.Combine(_tempPath, "downloads", "report.txt"));
                result.FileContents.Should().BeEquivalentTo(Encoding.UTF8.GetBytes("conteÃºdo"));
                result.FileDownloadName.Should().Be(filePath);
            }
        }
        finally
        {
            Directory.SetCurrentDirectory(originalDirectory);
        }
    }

    [Test]
    public void CreateDiretory_MissingDirectory_CreatesDirectory()
    {
        // CenÃ¡rio: o diretÃ³rio de destino ainda nÃ£o existe.
        // Objetivo: criar o diretÃ³rio de forma idempotente.
        // Arrange
        var directory = Path.Combine(_tempPath, "created");

        // Act
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.CreateDiretory(directory);
        SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.CreateDiretory(directory);

        // Assert
        Directory.Exists(directory).Should().BeTrue();
    }
}


