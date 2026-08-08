namespace SmartDigitalPsico.Domain.Test.Report;

[TestFixture]
public class QuestPdfReportAdapterTests
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
    public async Task Generate_TableAndTextPages_ReturnsAndSavesPdf()
    {
        // Cenário: o relatório possui páginas de tabela e texto.
        // Objetivo: gerar PDF em memória e em arquivo para ambos os formatos.
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var content = CreateContent();
        var adapter = new SmartDigitalPsico.Core.SDK.Domain.Report.QuestPdfReportAdapter();
        var output = Path.Combine(_tempPath, "quest.pdf");

        // Act
        var bytes = adapter.Generate(content);
        await adapter.Generate(content, output);

        // Assert
        bytes.Should().NotBeEmpty();
        bytes.Take(4).Should().BeEquivalentTo("%PDF"u8.ToArray());
        File.Exists(output).Should().BeTrue();
        new FileInfo(output).Length.Should().BeGreaterThan(0);
    }

    private static SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto CreateContent() => new()
    {
        Pages =
        [
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto { Name = "Table", PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Table, Rows = [new SampleRow { Name = "Ana", Amount = 12, Optional = null }], PropertiesToIgnore = ["Ignored"] },
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto { Name = "Text", PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Text, Rows = [new SampleRow { Name = "Bruno", Amount = 20, Optional = null }], PropertiesToIgnore = ["Ignored"] }
        ]
    };

    private sealed class SampleRow
    {
        public string Name { get; init; } = string.Empty;
        public int Amount { get; init; }
        public string? Optional { get; init; }
        public string Ignored { get; init; } = "ignored";
    }
}
