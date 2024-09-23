using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.DTO.Report;

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
        public void Generate(ReportContentDto content)
        {
            try
            {
                string filePath = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(_sharedDependenciesConfig.Configuration);
                var adapter = _pdfReportAdapterFactory.Create(Domain.Enuns.EPdfReportComponentType.PDFsharp);

                filePath = Path.Combine(filePath, content.FolderOutput, $"{content.FileName}.pdf");
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
                adapter.Generate(content, filePath);
            }
            catch (Exception ex)
            {
                _sharedDependenciesConfig.Logger.Error(ex, "Erro ao gerar PDF");
            }
        }
    }
}