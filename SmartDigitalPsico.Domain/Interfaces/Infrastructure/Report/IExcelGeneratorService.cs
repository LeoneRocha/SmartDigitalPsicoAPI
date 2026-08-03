using SmartDigitalPsico.Domain.DTO.Report;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IExcelGeneratorService.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IExcelGeneratorService
    {
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        Task<string> Generate(ReportWorkbookDataDto workbook);
    }
}
