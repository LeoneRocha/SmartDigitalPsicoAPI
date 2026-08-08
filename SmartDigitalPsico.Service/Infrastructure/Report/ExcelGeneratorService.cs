using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    /// <summary>
    /// Classe responsável por ExcelGeneratorService.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ExcelGeneratorService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorService
    {
        private readonly SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorFactory _excelGeneratorFactory;
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Método ExcelGeneratorService: executa a operação ExcelGeneratorService.
        /// </summary>
        public ExcelGeneratorService(IConfiguration configuration, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.Report.IExcelGeneratorFactory excelGeneratorFactory)
        {
            _configuration = configuration;
            _excelGeneratorFactory = excelGeneratorFactory;
        }

        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        public async Task<string> Generate(SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto workbook)
        {
            string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_configuration);
            var excelGenerator = _excelGeneratorFactory.Create();
            workbook.FileName = $"{workbook.FileName}.xlsx";
            filePath = Path.Combine(filePath, workbook.FolderOutput, workbook.FileName);
            filePath = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(filePath);
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
