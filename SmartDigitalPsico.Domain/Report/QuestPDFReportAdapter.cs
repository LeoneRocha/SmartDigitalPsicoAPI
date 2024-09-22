using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.VO.Report;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Report
{
    //https://www.questpdf.com/api-reference/line.html
    public class QuestPDFReportAdapter : IPdfReportAdapter
    {
        public QuestPDFReportAdapter()
        {
            QuestPDF.Settings.License = LicenseType.Community;//Commercial not free
        }
        public byte[] Generate(ReportContent content)
        {
            var document = Document.Create(container =>
            {
                CreateDocument(content, container);
            });
            return document.GeneratePdf();
        }
        public void Generate(ReportContent content, string filePath)
        {
            var document = Document.Create(container =>
            {
                CreateDocument(content, container);
            });
            document.GeneratePdf(filePath);
        }

        private static void CreateDocument(ReportContent content, IDocumentContainer container)
        {
            content.Pages.ForEach(pageAdd => AddPage(container, pageAdd));
        }

        private static void AddPage(IDocumentContainer container, ReportPageDataVO pageAdd)
        {
            if (pageAdd.PageType == Enuns.EReportPageType.Table)
            {
                container.Page(page =>
                {
                    ConfigurePage(page, pageAdd);
                    AddHeader(page, pageAdd);
                    AddTable(page, pageAdd);
                    AddFooter(page, pageAdd.FooterTitle);
                });
            }
            if (pageAdd.PageType == Enuns.EReportPageType.Text)
            {
                container.Page(page =>
                {
                    ConfigurePage(page, pageAdd);
                    AddHeader(page, pageAdd);
                    AddSimpleTextContent(page, pageAdd);
                    AddFooter(page, pageAdd.FooterTitle);
                });
            }
        }

        private static void ConfigurePage(PageDescriptor page, ReportPageDataVO pageAdd)
        {
            page.Size(PageSizes.A4);
            page.Margin(2, Unit.Centimetre);
            page.PageColor(Colors.White);
            page.DefaultTextStyle(x => x.FontSize(pageAdd.FontSizeDefaultTextStyle));
        }

        private static void AddTable(PageDescriptor page, ReportPageDataVO pageAdd)
        {
            page.Content().Table(table =>
            {
                var properties = GetProperties(pageAdd);
                DefineTableColumns(table, properties.Length);
                AddTableRows(table, pageAdd.Rows, properties);
            });
        }
        private static PropertyInfo[] GetProperties(ReportPageDataVO pageAdd)
        {
            return ReflectionHelpers.GetProperties(pageAdd.Rows[0], pageAdd.PropertiesToIgnore).ToArray();
        }

        private static void DefineTableColumns(TableDescriptor table, int propertyCount)
        {
            table.ColumnsDefinition(columns =>
            {
                for (int i = 0; i < propertyCount; i++)
                {
                    columns.RelativeColumn();
                }
            });
        }

        private static void AddTableRows(TableDescriptor table, List<object> rows, PropertyInfo[] properties)
        {
            rows.ForEach(row => AddRowContent(table, row, properties));
        }
        private static void AddFooter(PageDescriptor page, string footerTitle)
        {
            page.Footer()
                .AlignCenter()
                .Text(x =>
                {
                    x.Span(footerTitle);
                    x.CurrentPageNumber();
                });
        }
        private static void AddHeader(PageDescriptor page, ReportPageDataVO pageAdd)
        {
            page.Header()
                .Text(pageAdd.Name)
                .AlignCenter()
                .Bold()
                .FontSize(pageAdd.FontSizeHeader)
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

        private static void AddSimpleTextContent(PageDescriptor page, ReportPageDataVO pageAdd)
        {
            var properties = GetProperties(pageAdd).ToList();
            page.Content().Column(column =>
            {
                pageAdd.Rows.ForEach(row =>
                {
                    AddRowContent(column, row, properties);
                });
            });
        }

        private static void AddRowContent(ColumnDescriptor column, object row, List<PropertyInfo> properties)
        {
            properties.ForEach(prop =>
            {
                AddRowContentProperties(column, row, prop);
            });
        }

        private static void AddRowContentProperties(ColumnDescriptor column, object row, PropertyInfo prop)
        {
            var label = prop.Name;
            var value = prop.GetValue(row)?.ToString() ?? string.Empty;

            AddLabel(column, label);
            AddSeparator(column);
            AddValue(column, value);
            AddSpacing(column);
        }

        private static void AddSpacing(ColumnDescriptor column)
        {
            column.Item().Text(""); // Linha em branco para espaçamento
        }

        private static void AddValue(ColumnDescriptor column, string value)
        {
            column.Item().Text(value);
        }

        private static void AddSeparator(ColumnDescriptor column)
        {
            column.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Blue.Medium);
        }

        private static void AddLabel(ColumnDescriptor column, string label)
        {
            column.Item().Element(container =>
            {
                container.Text(text =>
                {
                    text.Span(label).Bold();
                });
            });
        }
    }
}