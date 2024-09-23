using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.VO.Report;
using System.Reflection;

namespace SmartDigitalPsico.Domain.Report
{
    public class PDFsharpMigraDocReportAdapter : IPdfReportAdapter
    {
        //https://docs.pdfsharp.net/index.html
        public byte[] Generate(ReportContent content)
        {
            var document = CreateDocument(content);
            return RenderDocumentToBytes(document);
        }
        public void Generate(ReportContent content, string filePath)
        {
            var document = CreateDocument(content);
            RenderDocumentToFile(document, filePath);
        }
        private Document CreateDocument(ReportContent content)
        {
            var document = new Document();
            foreach (var page in content.Pages)
            {
                var section = document.AddSection();
                AddHeader(section, page);
                AddFooter(section, page);
                AddPageContent(section, page);
            }
            return document;
        }

        private void AddHeader(Section section, ReportPageDataVO page)
        {
            var header = section.Headers.Primary.AddParagraph();
            header.AddText(page.Name);
            header.Format.Font.Size = page.FontSizeHeader;
            header.Format.Font.Bold = true;
            header.Format.Font.Color = Colors.Blue;
            header.Format.Alignment = ParagraphAlignment.Center;
        }

        private void AddFooter(Section section, ReportPageDataVO page)
        {
            var footer = section.Footers.Primary.AddParagraph();
            footer.AddText($"{page.FooterTitle}");
            footer.AddPageField();
            footer.Format.Font.Size = page.FontSizeDefaultTextStyle;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.Format.Font.Color = Colors.Gray;
        }


        private void AddPageContent(Section section, ReportPageDataVO page)
        {
            if (page.PageType == EReportPageType.Table)
            {
                AddTable(section, page);
            }
            else if (page.PageType == EReportPageType.Text)
            {
                AddText(section, page);
            }
        }
        private void AddTable(Section section, ReportPageDataVO page)
        {
            var table = section.AddTable();
            var properties = GetProperties(page);
            DefineTableColumns(table, properties.Length);
            AddTableRows(table, page.Rows, properties);
        }
        private void AddText(Section section, ReportPageDataVO page)
        {
            var properties = GetProperties(page).ToList();
            page.Rows.ForEach(row =>
            {
                AddRowContent(section, row, properties);
            });
        }
        private static void AddRowContent(Section section, object row, List<PropertyInfo> properties)
        {
            properties.ForEach(prop =>
            {
                AddRowContentProperties(section, row, prop);
            });
        }
        private static void AddRowContentProperties(Section section, object row, PropertyInfo prop)
        {
            var label = ReflectionHelpers.GetLabelProperty(prop);
            var value = prop.GetValue(row)?.ToString() ?? string.Empty;

            AddLabel(section, label);
            AddSeparator(section);
            AddValue(section, value);
            AddSpacing(section);
        }
        private static void AddSpacing(Section section)
        {
            section.AddParagraph(""); // Linha em branco para espaçamento
        }
        private static void AddValue(Section section, string value)
        {
            section.AddParagraph(value);
        }
        private static void AddSeparator(Section section)
        {
            var paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "5pt";
            paragraph.Format.Borders.Bottom.Width = 1;
            paragraph.Format.Borders.Bottom.Color = Colors.Blue;
        }
        private static void AddLabel(Section section, string label)
        {
            var paragraph = section.AddParagraph();
            paragraph.AddFormattedText(label, TextFormat.Bold);
        }
        private PropertyInfo[] GetProperties(ReportPageDataVO page)
        {
            return ReflectionHelpers.GetProperties(page.Rows[0], page.PropertiesToIgnore).ToArray();
        }
        private void DefineTableColumns(MigraDoc.DocumentObjectModel.Tables.Table table, int propertyCount)
        {
            for (int i = 0; i < propertyCount; i++)
            {
                table.AddColumn();
            }
        }
        private void AddTableRows(MigraDoc.DocumentObjectModel.Tables.Table table, List<object> rows, PropertyInfo[] properties)
        {
            foreach (var row in rows)
            {
                var tableRow = table.AddRow();
                for (int i = 0; i < properties.Length; i++)
                {
                    tableRow.Cells[i].AddParagraph(properties[i].GetValue(row)?.ToString()!);
                }
            }
        }
        private byte[] RenderDocumentToBytes(Document document)
        {
            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();
            using (var stream = new MemoryStream())
            {
                renderer.PdfDocument.Save(stream, false);
                return stream.ToArray();
            }
        }
        private void RenderDocumentToFile(Document document, string filePath)
        {
            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filePath);
        }
    }
}