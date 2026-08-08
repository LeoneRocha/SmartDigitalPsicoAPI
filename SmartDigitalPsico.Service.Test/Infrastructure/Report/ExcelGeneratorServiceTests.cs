using Microsoft.Extensions.Configuration;
using Moq;
using SmartDigitalPsico.Domain.DTO.Report;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Report;

namespace SmartDigitalPsico.Service.Test.Infrastructure.Report;

[TestFixture]
public class ExcelGeneratorServiceTests
{
    // Cenário: geração de workbook com pasta inexistente.
    // Objetivo: criar diretório, delegar ao factory e retornar caminho normalizado.
    [Test]
    public async Task Generate_NewOutputFolder_CreatesDirectoryAndReturnsPath()
    {
        // Arrange
        var tempRoot = Path.Combine(Path.GetTempPath(), "excel-gen-tests", Guid.NewGuid().ToString("N"));
        var configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(new Dictionary<string, string?> { ["AppSettings:ResourcesTemp"] = tempRoot })
            .Build();
        var generator = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGenerator>();
        generator.Setup(x => x.Generate(It.IsAny<SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto>(), It.IsAny<string>()))
            .Returns(Task.CompletedTask);
        var factory = new Mock<SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorFactory>();
        factory.Setup(x => x.Create()).Returns(generator.Object);
        var service = new ExcelGeneratorService(configuration, factory.Object);
        var workbook = new SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto { FileName = "report", FolderOutput = "exports" };

        // Act
        var path = await service.Generate(workbook);

        // Assert
        using (Assert.EnterMultipleScope())
        {
            path.Should().EndWith("report.xlsx");
            Directory.Exists(Path.GetDirectoryName(path)).Should().BeTrue();
            workbook.FileName.Should().Be("report.xlsx");
        }
        generator.Verify(x => x.Generate(workbook, path), Times.Once);
    }
}
