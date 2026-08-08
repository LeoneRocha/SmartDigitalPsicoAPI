using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.DTO.Report;
using System.Reflection;


namespace SmartDigitalPsico.Domain.Report
{
    /// <summary>
    /// Classe responsável por PDFsharpMigraDocReportAdapter.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class PDFsharpMigraDocReportAdapter : IPdfReportAdapter
    {
        //https://docs.pdfsharp.net/index.html
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        public byte[] Generate(ReportPageContentDto content)
        {
            var document = CreateDocument(content);
            return RenderDocumentToBytes(document);
        }
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        public async Task Generate(ReportPageContentDto content, string filePath)
        {
            await Task.Run(() => GeneratePDF(content, filePath));
        } 
        private static void GeneratePDF(ReportPageContentDto content, string filePath)
        {
            var document = CreateDocument(content);
            RenderDocumentToFile(document, filePath);
        }
        private static Document CreateDocument(ReportPageContentDto content)
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

        private static void AddHeader(Section section, ReportPageDataDto page)
        {
            var header = section.Headers.Primary.AddParagraph();
            header.AddText(page.Name);
            header.Format.Font.Size = page.FontSizeHeader;
            header.Format.Font.Bold = true;
            header.Format.Font.Color = Colors.Blue;
            header.Format.Alignment = ParagraphAlignment.Center;
        }

        private static void AddFooter(Section section, ReportPageDataDto page)
        {
            var footer = section.Footers.Primary.AddParagraph();
            footer.AddText($"{page.FooterTitle}");
            footer.AddPageField();
            footer.Format.Font.Size = page.FontSizeDefaultTextStyle;
            footer.Format.Alignment = ParagraphAlignment.Center;
            footer.Format.Font.Color = Colors.Gray;
        }
        private static void AddPageContent(Section section, ReportPageDataDto page)
        {
            if (page.PageType == SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EReportPageType.Table)
            {
                AddTable(section, page);
            }
            else if (page.PageType == SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EReportPageType.Text)
            {
                AddText(section, page);
            }
        }
        private static void AddTable(Section section, ReportPageDataDto page)
        {
            var table = section.AddTable();
            var properties = GetProperties(page);
            DefineTableColumns(table, properties.Length);
            AddTableRows(table, page.Rows, properties);
        }
        private static void AddText(Section section, ReportPageDataDto page)
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
            var label = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ReflectionHelpers.GetLabelProperty(prop);
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
        private static PropertyInfo[] GetProperties(ReportPageDataDto page)
        {
            return SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.ReflectionHelpers.GetProperties(page.Rows[0], page.PropertiesToIgnore).ToArray();
        }
        private static void DefineTableColumns(MigraDoc.DocumentObjectModel.Tables.Table table, int propertyCount)
        {
            for (int i = 0; i < propertyCount; i++)
            {
                table.AddColumn();
            }
        }
        private static void AddTableRows(MigraDoc.DocumentObjectModel.Tables.Table table, List<object> rows, PropertyInfo[] properties)
        {
            foreach (var row in rows)
            {
                var tableRow = table.AddRow();
                for (int i = 0; i < properties.Length; i++)
                {
                    tableRow.Cells[i].AddParagraph(properties[i].GetValue(row)?.ToString() ?? string.Empty);
                }
            }
        }
        private static byte[] RenderDocumentToBytes(Document document)
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
        private static void RenderDocumentToFile(Document document, string filePath)
        {
            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filePath);
        }

    }
}
