using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    public class ExcelGeneratorService : IExcelGeneratorService
    {
        private readonly IExcelGeneratorFactory _excelGeneratorFactory;
        private readonly IConfiguration _configuration;

        public ExcelGeneratorService(IConfiguration configuration, IExcelGeneratorFactory excelGeneratorFactory)
        {
            _configuration = configuration;
            _excelGeneratorFactory = excelGeneratorFactory;
        }

        public async Task<string> Generate(ReportWorkbookDataDto workbook)
        {
            string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_configuration);
            var excelGenerator = _excelGeneratorFactory.Create();
            workbook.FileName = $"{workbook.FileName}.xlsx";
            filePath = Path.Combine(filePath, workbook.FolderOutput, workbook.FileName);
            filePath = FileHelper.NormalizePath(filePath);
            string directoryPath = Path.GetDirectoryName(filePath)!;
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            await excelGenerator.Generate(workbook, filePath);
            return filePath;
        }
    }
}