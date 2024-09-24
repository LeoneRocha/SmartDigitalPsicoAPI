using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientRecordService : IEntityBaseService<PatientRecord, AddPatientRecordDto,UpdatePatientRecordDto, GetPatientRecordDto>
    { 
        Task<ServiceResponse<List<GetPatientRecordDto>>> FindAllByPatient(long patientId);
    }
}