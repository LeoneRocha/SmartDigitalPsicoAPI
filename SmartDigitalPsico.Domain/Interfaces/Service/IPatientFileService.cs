using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientFile;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientFileService : IEntityBaseService<PatientFile, AddPatientFileDto, UpdatePatientFileDto, GetPatientFileDto>
    {
        Task<GetPatientFileDto> DownloadFileById(long fileId);
        Task<bool> PostFileAsync(AddPatientFileDto entity);
           
        Task<ServiceResponse<List<GetPatientFileDto>>> FindAllByPatient(long patientId); 
    }
}