using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientService : IEntityBaseService<Patient, AddPatientVO, UpdatePatientVO, GetPatientVO>
    {
        Task<ServiceResponse<List<GetPatientVO>>> FindAll(long medicalId);
        Task<ServiceResponse<GetPatientVO>> FindByPatient(GetPatientVO info);
    }
}