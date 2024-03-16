using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientHospitalizationInformationService : IEntityBaseSimpleService<PatientHospitalizationInformation, AddPatientHospitalizationInformationVO ,UpdatePatientHospitalizationInformationVO , GetPatientHospitalizationInformationVO>
    {  
        Task<ServiceResponse<List<GetPatientHospitalizationInformationVO>>> FindAllByPatient(long patientId);
    }
}