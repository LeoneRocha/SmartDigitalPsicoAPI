using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientFileService : IEntityBaseService<PatientFile, AddPatientFileVO, UpdatePatientFileVO, GetPatientFileVO>
    {
        Task<GetPatientFileVO> DownloadFileById(long fileId);
        Task<bool> PostFileAsync(AddPatientFileVO entity);
    }
}