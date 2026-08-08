using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;
using SmartDigitalPsico.Core.SDK.Domain.Report;

namespace SmartDigitalPsico.Core.SDK.Tests.Report;

[TestFixture]
public class PDFsharpMigraDocReportAdapterTests
{
    private string _tempPath = null!;

    [OneTimeSetUp]
    public void OneTimeSetUp() => PdfSharpTestBootstrap.EnsureWindowsFonts();

    [SetUp]
    public void SetUp()
    {
        _tempPath = Path.Combine(Path.GetTempPath(), $"smartdigitalpsico-{Guid.NewGuid():N}");
    }

    [TearDown]
    public void TearDown()
    {
        if (Directory.Exists(_tempPath))
            Directory.Delete(_tempPath, true);
    }

    [Test]
    public async Task Generate_TableAndTextPages_ReturnsAndSavesPdf()
    {
        // Cenário: o relatório tem conteúdo em tabela e texto.
        // Objetivo: renderizar os dois tipos em memória e arquivo.
        // Arrange
        Directory.CreateDirectory(_tempPath);
        var content = new ReportPageContentDto
        {
            Pages =
            [
                new ReportPageDataDto { Name = "Tabela", PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Table, Rows = [new SampleRow { Name = "Ana", Value = 3, Empty = null }], PropertiesToIgnore = ["Empty"] },
                new ReportPageDataDto { Name = "Texto", PageType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Text, Rows = [new SampleRow { Name = "Bruno", Value = 8, Empty = null }], PropertiesToIgnore = ["Empty"] }
            ]
        };
        var adapter = new PDFsharpMigraDocReportAdapter();
        var output = Path.Combine(_tempPath, "migradoc.pdf");

        // Act
        var bytes = adapter.Generate(content);
        await adapter.Generate(content, output);

        // Assert
        bytes.Should().NotBeEmpty();
        bytes.Take(4).Should().BeEquivalentTo("%PDF"u8.ToArray());
        File.Exists(output).Should().BeTrue();
        new FileInfo(output).Length.Should().BeGreaterThan(0);
    }

    private sealed class SampleRow
    {
        public string Name { get; init; } = string.Empty;
        public int Value { get; init; }
        public string? Empty { get; init; }
    }
}

