using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.VO.Report;

namespace SmartDigitalPsico.Domain.Report
{
    public class QuestPDFReportAdapter : IPdfReportAdapter
    {
        public QuestPDFReportAdapter()
        {
            QuestPDF.Settings.License = LicenseType.Community;//Commercial not free
        }
        public void Generate(ReportContent content, string filePath)
        {
            var document = Document.Create(container =>
            {
                createDocumentTable(content, container);
            });
            document.GeneratePdf(filePath);
        }

        private static void createDocumentTable(ReportContent content, IDocumentContainer container)
        {
            foreach (var pageAdd in content.Pages)
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    // Adicionando o cabeçalho
                    AddHeader(page, pageAdd.Name);

                    page.Content().Table(table =>
                    {
                        var properties = ReflectionHelpers.GetProperties(pageAdd.Rows[0], pageAdd.PropertiesToIgnore).ToArray();
                        int propertyCount = properties.Length > 0 ? properties.Length : 0;

                        // Definindo as colunas da tabela dinamicamente
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < propertyCount; i++)
                            {
                                columns.RelativeColumn();
                            }
                        });

                        foreach (var row in pageAdd.Rows)
                        {
                            AddRowContent(table, row, properties);
                        }
                    });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span(pageAdd.FooterTitle);
                            x.CurrentPageNumber();
                        });
                });
            }
        }

        private static void AddHeader(PageDescriptor page, string name)
        {
            page.Header()
                .Text(name)
                .AlignCenter()
                .Bold()
                .FontSize(36)
                .FontColor(Colors.Blue.Medium);
        }

        private static void AddRowContent(TableDescriptor table, object row, System.Reflection.PropertyInfo[] properties)
        {

            foreach (var property in properties)
            {
                var value = property.GetValue(row)?.ToString() ?? string.Empty;
                table.Cell().Element(container =>
                {
                    container.Border(1).Padding(5).Text(value);
                });
            }
        }


        private void CellStyle(IContainer container)
        {
            container.Border(1).Padding(5);
        }
        public byte[] Generate(ReportContent content)
        {
            var document = Document.Create(container =>
            {
                foreach (var pageAdd in content.Pages)
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(20));

                        page.Header()
                            .Text(pageAdd.Name)
                            .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Column(column =>
                            {
                                foreach (var paragraph in pageAdd.Rows)
                                {
                                    column.Item().Text("paragraph");
                                }
                            });

                        page.Footer()
                            .AlignCenter()
                            .Text(x =>
                            {
                                x.Span("Página ");
                                x.CurrentPageNumber();
                            });
                    });
                }

            });

            return document.GeneratePdf();
        }
    }
}