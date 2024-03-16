using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientAdditionalInformationService : IEntityBaseSimpleService<PatientAdditionalInformation, 
        AddPatientAdditionalInformationVO,UpdatePatientAdditionalInformationVO, GetPatientAdditionalInformationVO>
    { 
        Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAllByPatient(long patientId);
    }
}