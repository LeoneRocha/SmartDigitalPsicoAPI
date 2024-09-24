using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientAdditionalInformationService : IEntityBaseService<PatientAdditionalInformation, 
        AddPatientAdditionalInformationDto,UpdatePatientAdditionalInformationDto, GetPatientAdditionalInformationDto>
    { 
        Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAllByPatient(long patientId);
    }
}