using Microsoft.Extensions.Configuration;
using Moq;
using Serilog;
using SmartDigitalPsico.Domain.DTO.Report;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Report;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Report;

[TestFixture]
public class PdfReportServiceTests
{
    // Cenário: geração de PDF bem-sucedida.
    // Objetivo: criar diretório, invocar adaptador e retornar caminho do arquivo.
    [Test]
    public async Task Generate_ValidContent_ReturnsFilePath()
    {
        // Arrange
        var tempRoot = Path.Combine(Path.GetTempPath(), $"pdf-test-{Guid.NewGuid():N}");
        Directory.CreateDirectory(tempRoot);
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["AppSettings:ResourcesTemp"] = tempRoot
        }).Build();
        var configMock = new Mock<ISharedDependenciesConfig>();
        configMock.SetupGet(x => x.Configuration).Returns(config);
        configMock.SetupGet(x => x.Logger).Returns(Mock.Of<ILogger>());
        var adapter = new Mock<IPdfReportAdapter>();
        var expectedPath = Path.Combine(tempRoot, "Reports_PDF", "report.pdf");
        adapter.Setup(x => x.Generate(It.IsAny<ReportPageContentDto>(), expectedPath)).Returns(Task.CompletedTask);
        var factory = new Mock<IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);
        var content = new ReportPageContentDto { FileName = "report", FolderOutput = "Reports_PDF", Title = "Test" };

        try
        {
            // Act
            var result = await service.Generate(content);

            // Assert
            result.Should().Be(expectedPath);
            adapter.Verify(x => x.Generate(It.IsAny<ReportPageContentDto>(), expectedPath), Times.Once);
        }
        finally
        {
            if (Directory.Exists(tempRoot))
                Directory.Delete(tempRoot, true);
        }
    }

    // Cenário: falha na geração do PDF.
    // Objetivo: registrar erro e retornar caminho vazio.
    [Test]
    public async Task Generate_AdapterThrows_ReturnsEmptyPath()
    {
        // Arrange
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["AppSettings:ResourcesTemp"] = Path.GetTempPath()
        }).Build();
        var logger = new Mock<ILogger>();
        var configMock = new Mock<ISharedDependenciesConfig>();
        configMock.SetupGet(x => x.Configuration).Returns(config);
        configMock.SetupGet(x => x.Logger).Returns(logger.Object);
        var adapter = new Mock<IPdfReportAdapter>();
        adapter.Setup(x => x.Generate(It.IsAny<ReportPageContentDto>(), It.IsAny<string>())).ThrowsAsync(new InvalidOperationException("pdf error"));
        var factory = new Mock<IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);

        // Act
        var result = await service.Generate(new ReportPageContentDto { FileName = "fail", FolderOutput = "Reports_PDF" });

        // Assert
        result.Should().BeEmpty();

        logger.Verify(x => x.Error(It.IsAny<Exception>(), It.IsAny<string>()), Times.Once);
    }

    // Cenário: arquivo PDF já existe no destino.
    // Objetivo: remover arquivo anterior antes de regenerar.
    [Test]
    public async Task Generate_ExistingFile_DeletesBeforeRegenerating()
    {
        // Arrange
        var tempRoot = Path.Combine(Path.GetTempPath(), $"pdf-test-{Guid.NewGuid():N}");
        var outputDir = Path.Combine(tempRoot, "Reports_PDF");
        Directory.CreateDirectory(outputDir);
        var existingFile = Path.Combine(outputDir, "report.pdf");

        // Act
        await File.WriteAllTextAsync(existingFile, "old");

        // Assert
        var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
        {
            ["AppSettings:ResourcesTemp"] = tempRoot
        }).Build();
        var configMock = new Mock<ISharedDependenciesConfig>();
        configMock.SetupGet(x => x.Configuration).Returns(config);
        configMock.SetupGet(x => x.Logger).Returns(Mock.Of<ILogger>());
        var adapter = new Mock<IPdfReportAdapter>();
        adapter.Setup(x => x.Generate(It.IsAny<ReportPageContentDto>(), existingFile)).Returns(Task.CompletedTask);
        var factory = new Mock<IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);

        try
        {
            var result = await service.Generate(new ReportPageContentDto { FileName = "report", FolderOutput = "Reports_PDF" });

            result.Should().Be(existingFile);
            adapter.Verify(x => x.Generate(It.IsAny<ReportPageContentDto>(), existingFile), Times.Once);
        }
        finally
        {
            if (Directory.Exists(tempRoot))
                Directory.Delete(tempRoot, true);
        }
    }
}
