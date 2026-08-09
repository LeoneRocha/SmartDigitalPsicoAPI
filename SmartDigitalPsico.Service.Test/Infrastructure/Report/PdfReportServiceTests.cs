using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;

using SmartDigitalPsico.Domain.Interfaces.Common;
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
        configMock.SetupGet(x => x.Logger).Returns(Mock.Of<IAppLogger>());
        var adapter = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapter>();
        var expectedPath = Path.Combine(tempRoot, "Reports_PDF", "report.pdf");
        adapter.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>(), expectedPath)).Returns(Task.CompletedTask);
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);
        var content = new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto { FileName = "report", FolderOutput = "Reports_PDF", Title = "Test" };

        try
        {
            // Act
            var result = await service.Generate(content);

            // Assert
            result.Should().Be(expectedPath);
            adapter.Verify(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>(), expectedPath), Times.Once);
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
        var logger = new Mock<IAppLogger>();
        var configMock = new Mock<ISharedDependenciesConfig>();
        configMock.SetupGet(x => x.Configuration).Returns(config);
        configMock.SetupGet(x => x.Logger).Returns(logger.Object);
        var adapter = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapter>();
        adapter.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>(), It.IsAny<string>())).ThrowsAsync(new InvalidOperationException("pdf error"));
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);

        // Act
        var result = await service.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto { FileName = "fail", FolderOutput = "Reports_PDF" });

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
        configMock.SetupGet(x => x.Logger).Returns(Mock.Of<IAppLogger>());
        var adapter = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapter>();
        adapter.Setup(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>(), existingFile)).Returns(Task.CompletedTask);
        var factory = new Mock<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory>();
        factory.Setup(x => x.Create(global::SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.PDFsharp)).Returns(adapter.Object);
        var service = new PdfReportService(configMock.Object, factory.Object);

        try
        {
            var result = await service.Generate(new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto { FileName = "report", FolderOutput = "Reports_PDF" });

            result.Should().Be(existingFile);
            adapter.Verify(x => x.Generate(It.IsAny<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto>(), existingFile), Times.Once);
        }
        finally
        {
            if (Directory.Exists(tempRoot))
                Directory.Delete(tempRoot, true);
        }
    }
}
