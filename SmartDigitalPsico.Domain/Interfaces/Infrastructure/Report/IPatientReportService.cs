using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.DTO.Report.Enitty;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientReportService.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientReportService
    {
        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long id);
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<PatientDetailReportDto>> GetPatientDetailsByIdAsync(long id);
        /// <summary>
        /// Método DownloadReportPatientDetailsById: executa a operação DownloadReportPatientDetailsById.
        /// </summary>
        Task<FileContentResult> DownloadReportPatientDetailsById(long id, EReportOutputType eReportOutputType);
    }
}
