using SmartDigitalPsico.Domain.Helpers;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Service
{
                                    /// <summary>
    /// Classe responsável por PdfReportService.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PdfReportService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportService
    {
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory _pdfReportAdapterFactory;
        private readonly ISharedDependenciesConfig _sharedDependenciesConfig;

        /// <summary>
        /// Método PdfReportService: executa a operação PdfReportService.
        /// </summary>
        public PdfReportService(ISharedDependenciesConfig sharedDependenciesConfig, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report.IPdfReportAdapterFactory pdfReportAdapterFactory)
        {
            _sharedDependenciesConfig = sharedDependenciesConfig;
            _pdfReportAdapterFactory = pdfReportAdapterFactory;
        }
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        public async Task<string> Generate(SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto content)
        {
            try
            {
                string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_sharedDependenciesConfig.Configuration);
                var adapter = _pdfReportAdapterFactory.Create(SmartDigitalPsico.Core.SDK.Domain.Enuns.EPdfReportComponentType.PDFsharp);

                content.FileName = $"{content.FileName}.pdf";
                filePath = Path.Combine(filePath, content.FolderOutput, content.FileName);
                filePath = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(filePath);
                string directoryPath = Path.GetDirectoryName(filePath)!;
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                await adapter.Generate(content, filePath);
                return filePath;
            }
            catch (Exception ex)
            {
                _sharedDependenciesConfig.Logger.Error(ex, "Erro ao gerar PDF");
            }
            return string.Empty;
        }
    }
}
