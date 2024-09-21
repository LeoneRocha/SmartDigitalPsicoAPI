using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Report;
using SmartDigitalPsico.Domain.VO.Report;

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

        public async Task Generate(ReportWorkbookDataVO workbook)
        {
            string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_configuration);
            var excelGenerator = _excelGeneratorFactory.Create();
            filePath = Path.Combine(filePath, workbook.FolderOutput, $"{workbook.WorkbookName}.xlsx");
            await excelGenerator.Generate(workbook, filePath);
        }
    }
}
