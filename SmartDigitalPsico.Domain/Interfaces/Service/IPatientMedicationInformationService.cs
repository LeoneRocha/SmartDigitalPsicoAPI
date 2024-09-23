using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientMedicationInformationService 
        : IEntityBaseService<PatientMedicationInformation, AddPatientMedicationInformationDto, UpdatePatientMedicationInformationDto, GetPatientMedicationInformationDto>
    { 
        Task<ServiceResponse<List<GetPatientMedicationInformationDto>>> FindAllByPatient(long patientId);
    }
}