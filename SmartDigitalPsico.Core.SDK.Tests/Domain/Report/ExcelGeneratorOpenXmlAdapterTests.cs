using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Tests.Report;

[TestFixture]
public class ExcelGeneratorOpenXmlAdapterTests
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
    public async Task Generate_SortedSheetsAndMergeCells_CreatesWorkbookContent()
    {
        // CenÃ¡rio: uma planilha contÃ©m dados tipados e cÃ©lulas mescladas.
        // Objetivo: gerar workbook ordenado com cabeÃ§alho, filtro e estilos.
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var output = Path.Combine(_tempPath, "report.xlsx");
        var workbook = new ReportWorkbookDataDto
        {
            Sheets =
            [
                new ReportSheetDataDto { Order = 2, Name = "Second", Rows = [new SampleRow { Text = "second", Number = 2, Enabled = false, Date = new DateTime(2025, 1, 2) }] },
                new ReportSheetDataDto { Order = 1, Name = "First", MergeCellReferences = ["A1:B1"], Rows = [new SampleRow { Text = "first", Number = 1, Enabled = true, Date = new DateTime(2025, 1, 1) }], PropertiesToIgnore = ["Ignored"] }
            ]
        };
        var adapter = new ExcelGeneratorOpenXmlAdapter();

        // Act
        await adapter.Generate(workbook, output);
        using var document = SpreadsheetDocument.Open(output, false);
        var workbookPart = document.WorkbookPart;
        workbookPart.Should().NotBeNull();
        var openXmlWorkbook = workbookPart!.Workbook;
        openXmlWorkbook.Should().NotBeNull();
        openXmlWorkbook!.Sheets.Should().NotBeNull();
        var sheets = openXmlWorkbook.Sheets!.Elements<Sheet>().ToList();
        sheets[0].Id.Should().NotBeNull();
        var firstSheet = workbookPart.GetPartById(sheets[0].Id!) as WorksheetPart;
        firstSheet.Should().NotBeNull();
        firstSheet!.Worksheet.Should().NotBeNull();
        var worksheet = firstSheet.Worksheet!;

        // Assert
        File.Exists(output).Should().BeTrue();
        sheets.Select(x => x.Name!.Value).Should().ContainInOrder("First", "Second");
        worksheet!.Descendants<MergeCell>().Should().ContainSingle(x => x.Reference == "A1:B1");
        worksheet.Descendants<AutoFilter>().Should().ContainSingle(x => x.Reference == "A1:D1");
        worksheet.Descendants<Row>().Should().HaveCount(2);
        ExcelGeneratorOpenXmlAdapter.GetStylesheet().Elements<CellFormats>().Should().ContainSingle().Which.ChildElements.Should().HaveCount(5);
    }

    private sealed class SampleRow
    {
        public string Text { get; init; } = string.Empty;
        public int Number { get; init; }
        public bool Enabled { get; init; }
        public DateTime Date { get; init; }
        public string Ignored { get; init; } = "ignored";
    }
}


