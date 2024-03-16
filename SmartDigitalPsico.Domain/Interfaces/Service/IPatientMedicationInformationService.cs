using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientMedicationInformationService 
        : IEntityBaseSimpleService<PatientMedicationInformation, AddPatientMedicationInformationVO, UpdatePatientMedicationInformationVO, GetPatientMedicationInformationVO>
    { 
        Task<ServiceResponse<List<GetPatientMedicationInformationVO>>> FindAllByPatient(long patientId);
    }
}