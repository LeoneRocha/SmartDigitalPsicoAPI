using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientRecordService : IEntityBaseSimpleService<PatientRecord, AddPatientRecordVO,UpdatePatientRecordVO, GetPatientRecordVO>
    { 
        Task<ServiceResponse<List<GetPatientRecordVO>>> FindAllByPatient(long patientId);
    }
}