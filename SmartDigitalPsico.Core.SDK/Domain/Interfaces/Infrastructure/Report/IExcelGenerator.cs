using SmartDigitalPsico.Core.SDK.Domain.DTO.Report;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IExcelGenerator.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IExcelGenerator
    {
        /// <summary>
        /// Método Generate: executa a operação Generate.
        /// </summary>
        Task Generate(ReportWorkbookDataDto workbookDataInput, string filePath);
    }
}
