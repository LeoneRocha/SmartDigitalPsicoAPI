using SmartDigitalPsico.Domain.DTO.Report;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;

namespace SmartDigitalPsico.Service.Infrastructure.Report
{
    public class PdfReportService : IPdfReportService
    {
        private readonly IPdfReportAdapterFactory _pdfReportAdapterFactory;
        private readonly ISharedDependenciesConfig _sharedDependenciesConfig;

        public PdfReportService(ISharedDependenciesConfig sharedDependenciesConfig, IPdfReportAdapterFactory pdfReportAdapterFactory)
        {
            _sharedDependenciesConfig = sharedDependenciesConfig;
            _pdfReportAdapterFactory = pdfReportAdapterFactory;
        }
        public async Task<string> Generate(ReportPageContentDto content)
        {
            try
            {
                string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_sharedDependenciesConfig.Configuration);
                var adapter = _pdfReportAdapterFactory.Create(Domain.Enuns.EPdfReportComponentType.PDFsharp);

                content.FileName = $"{content.FileName}.pdf";
                filePath = Path.Combine(filePath, content.FolderOutput, content.FileName);
                filePath = FileHelper.NormalizePath(filePath);
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