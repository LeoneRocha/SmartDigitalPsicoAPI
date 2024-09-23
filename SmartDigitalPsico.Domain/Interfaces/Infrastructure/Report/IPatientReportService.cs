using SmartDigitalPsico.Domain.DTO.Report.Patient;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report
{
    public interface IPatientReportService
    {
        void SetUserId(long id);
        Task<ServiceResponse<PatientDetailReportDto>> GetPatientDetailsByIdAsync(long id);
    }
}