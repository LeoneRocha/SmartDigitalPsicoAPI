using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientHospitalizationInformationService : IEntityBaseService<PatientHospitalizationInformation, AddPatientHospitalizationInformationDto ,UpdatePatientHospitalizationInformationDto , GetPatientHospitalizationInformationDto>
    {  
        Task<ServiceResponse<List<GetPatientHospitalizationInformationDto>>> FindAllByPatient(long patientId);
    }
}