using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientService : IEntityBaseService<Patient, AddPatientDto, UpdatePatientDto, GetPatientDto>
    {
        Task<ServiceResponse<List<GetPatientDto>>> FindAll(long medicalId);
        Task<ServiceResponse<GetPatientDto>> FindByPatient(GetPatientDto info);
    }
}