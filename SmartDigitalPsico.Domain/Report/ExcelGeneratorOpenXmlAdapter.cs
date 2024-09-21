using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.VO.Report;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Report
{
    public class ExcelGeneratorOpenXmlAdapter : IExcelGenerator
    {
        public async Task Generate(ReportWorkbookDataVO workbookDataInput, string filePath)
        {
            await Task.Run(() => GenerateExcel(workbookDataInput, filePath));
        }

        private static void GenerateExcel(ReportWorkbookDataVO workbookDataInput, string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath)!;
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            } 
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = CreateWorkbookPart(document);

                // Add Sheets to the Workbook.
                workbookPart.Workbook.AppendChild(new Sheets());

                AddWorkbookStyles(workbookPart);
                uint sheetIndex = 1;
                foreach (var sheetDataInput in workbookDataInput.Sheets.OrderBy(x => x.Order))
                {
                    WorksheetPart worksheetPart = CreateWorksheetPart(workbookPart);
                    MergeCells? mergeCells = GetMergeCell(sheetDataInput);
                    AddSheetToWorkbook(workbookPart, worksheetPart, sheetDataInput.SheetName, sheetIndex, mergeCells);

                    PopulateSheetData(worksheetPart, sheetDataInput.Rows, sheetDataInput.PropertiesToIgnore);
                    sheetIndex++;
                }
            }
        }

        private static void AddWorkbookStyles(WorkbookPart workbookPart)
        {
            WorkbookStylesPart stylePart = workbookPart.AddNewPart<WorkbookStylesPart>();
            stylePart.Stylesheet = GetStylesheet();
        }

        private static MergeCells? GetMergeCell(ReportSheetDataVO sheetData)
        {
            var mergeCells = new MergeCells();
            if (sheetData.MergeCellReferences?.Any() == true)
            {
                foreach (var reference in sheetData.MergeCellReferences)
                {
                    mergeCells.Append(new MergeCell { Reference = new StringValue(reference) });
                }
                return mergeCells;
            }
            return null;
        }
        private static WorkbookPart CreateWorkbookPart(SpreadsheetDocument document)
        {
            WorkbookPart workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            return workbookPart;
        }

        private static WorksheetPart CreateWorksheetPart(WorkbookPart workbookPart)
        {
            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());
            return worksheetPart;
        }

        private static void AddSheetToWorkbook(WorkbookPart workbookPart, WorksheetPart worksheetPart,
            string sheetName, uint sheetId, MergeCells? mergeCells)
        {
            if (workbookPart != null)
            {
                //Clone the MergeCells object before inserting it.
                if (mergeCells != null)
                {
                    MergeCells clonedMergeCells = (MergeCells)mergeCells.CloneNode(true);
                    // Insert a MergeCells object into the specified position.  
                    if (worksheetPart.Worksheet.Elements<CustomSheetView>().Any())
                        worksheetPart.Worksheet.InsertAfter(clonedMergeCells, worksheetPart.Worksheet.Elements<CustomSheetView>().First());
                    else
                        worksheetPart.Worksheet.InsertAfter(clonedMergeCells, worksheetPart.Worksheet.Elements<SheetData>().First());
                }

                Sheets sheetsInWorkbook = workbookPart.Workbook.GetFirstChild<Sheets>()!;

                Sheet sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = sheetId,
                    Name = sheetName
                };
                sheetsInWorkbook.Append(sheet);
            }
        }

        private static void PopulateSheetData(WorksheetPart worksheetPart, List<object> rows, List<string> propertiesToIgnore)
        {
            if (worksheetPart == null) throw new ArgumentNullException(nameof(worksheetPart));
            if (rows == null) throw new ArgumentNullException(nameof(rows));
            if (propertiesToIgnore == null) throw new ArgumentNullException(nameof(propertiesToIgnore));

            var sheetDataElement = worksheetPart.Worksheet.GetFirstChild<SheetData>()
                ?? throw new InvalidOperationException("SheetData not found.");

            // Adiciona a linha de cabeçalho
            AddHeaderRow(rows.First(), propertiesToIgnore, sheetDataElement);

            // Verifica se T é uma classe
            AddRowsData(rows, propertiesToIgnore, sheetDataElement);

            AddBestFit(worksheetPart);

            AddAutoFilter(worksheetPart, rows, propertiesToIgnore);
        }

        private static void AddAutoFilter(WorksheetPart worksheetPart, List<object> rows, List<string> propertiesToIgnore)
        {
            // Calcula a referência do AutoFilter dinamicamente
            int columnCount = rows.First().GetType().GetProperties().Count(p => !propertiesToIgnore.Contains(p.Name));
            string endColumn = GetExcelColumnName(columnCount);
            AutoFilter autoFilter = new AutoFilter() { Reference = $"A1:{endColumn}1" };
            worksheetPart.Worksheet.Append(autoFilter);
        }

        private static void AddBestFit(WorksheetPart worksheetPart)
        {
            foreach (Column column in worksheetPart.Worksheet.Descendants<Column>())
            {
                column.BestFit = true;
            }
        }

        // Método auxiliar para obter o nome da coluna no formato Excel (A, B, ..., Z, AA, AB, ...)
        private static string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";
            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar(65 + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }
            return columnName;
        }

        private static void AddHeaderRow(object firstRow, List<string> propertiesToIgnore, SheetData sheetDataElement)
        {
            if (firstRow == null) return;

            var headerRow = new Row();
            var properties = GetProperties(firstRow, propertiesToIgnore);

            foreach (var property in properties)
            {
                var headerText = property.Name;
                var descriptionAttribute = property.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
                if (descriptionAttribute != null)
                {
                    headerText = descriptionAttribute.Description;
                }

                var cell = CreateTextCell(headerText, 2);
                headerRow.Append(cell);
            }

            sheetDataElement.Append(headerRow);
        }

        private static IOrderedEnumerable<System.Reflection.PropertyInfo> GetProperties(object firstRow, List<string> propertiesToIgnore)
        {
            return firstRow.GetType().GetProperties()
                        .Where(p => !propertiesToIgnore.Contains(p.Name))
                        .OrderBy(p => p.GetCustomAttributes(typeof(OrderAttribute), false)
                        .Cast<OrderAttribute>().FirstOrDefault()?.Order ?? int.MaxValue);
        }

        private static void AddRowsData(List<object> rows, List<string> propertiesToIgnore, SheetData sheetDataElement)
        {
            foreach (var rowData in rows)
            {
                var row = new Row();
                var properties = GetProperties(rowData, propertiesToIgnore);

                foreach (var property in properties)
                {
                    var cellValue = property.GetValue(rowData)?.ToString() ?? string.Empty;
                    var cell = CreateCell(cellValue, property.PropertyType, 4);
                    row.Append(cell);
                }

                sheetDataElement.Append(row);
            }
        }

        private static Cell CreateCell(string cellValue, Type propertyType, uint styleIndex = 0)
        {
            CellValues dataType;

            if (propertyType == typeof(int) || propertyType == typeof(double) || propertyType == typeof(float) || propertyType == typeof(decimal))
            {
                dataType = CellValues.Number;
            }
            else if (propertyType == typeof(bool))
            {
                dataType = CellValues.Boolean;
            }
            else if (propertyType == typeof(DateTime))
            {
                dataType = CellValues.Date;
            }
            else
            {
                dataType = CellValues.String;
            }

            return new Cell
            {
                CellValue = new CellValue(cellValue),
                DataType = dataType,
                StyleIndex = styleIndex
            };
        }

        private static Cell CreateTextCell(string cellValue, uint styleIndex = 0)
        {
            return new Cell
            {
                CellValue = new CellValue(cellValue),
                DataType = CellValues.String,
                StyleIndex = styleIndex

            };
        }

        public static Stylesheet GetStylesheet()
        {
            Fonts fonts = new Fonts(
               new Font( // Index 0 - default
                   new FontSize() { Val = 11 },
                   new FontName() { Val = "Calibri" }
               ),
               new Font( // Index 1 - header
                   new FontSize() { Val = 12 },
                   new Bold(),
                   new Color() { Rgb = "000000" },
                   new FontName() { Val = "Calibri" }
               )
               );
            Fills fills = new Fills(
                    new Fill(new PatternFill() { PatternType = PatternValues.None }), // Index 0 - default
                    new Fill(new PatternFill() { PatternType = PatternValues.Gray125 }), // Index 1 - default
                    new Fill(new PatternFill(new ForegroundColor { Rgb = new HexBinaryValue() { Value = "E7E6E6" } }) { PatternType = PatternValues.Solid }) // Index 2 - header 
                );

            Borders borders = new Borders(
                    new Border(), // index 0 default
                    new Border(
                        new LeftBorder(new Color() { Auto = true }) { Style = BorderStyleValues.Thin },
                        new RightBorder(new Color() { Auto = true }) { Style = BorderStyleValues.Thin },
                        new TopBorder(new Color() { Auto = true }) { Style = BorderStyleValues.Thin },
                        new BottomBorder(new Color() { Auto = true }) { Style = BorderStyleValues.Thin },
                        new DiagonalBorder()
                        ) // index 1  FULL BORDER
                );
            CellFormats cellFormats = new CellFormats(
                    new CellFormat(), //index 0 - default
                    new CellFormat() { FontId = 0, FillId = 0, BorderId = 0, ApplyBorder = true, }, // index 1 - body   none border
                    new CellFormat() { FontId = 1, FillId = 2, BorderId = 1, ApplyFill = true, ApplyBorder = true, Alignment = new Alignment() { Horizontal = HorizontalAlignmentValues.Center } },// index 2 -  header 1,2                      
                    new CellFormat() { FontId = 0, FillId = 0, BorderId = 1, ApplyFill = true },// index 3 - body value total 
                    new CellFormat() { FontId = 0, FillId = 0, BorderId = 1, ApplyBorder = true, }// index 4 -  full border 
                );
            Stylesheet styleSheet = new Stylesheet(fonts, fills, borders, cellFormats);
            return styleSheet;
        }
    }
}
