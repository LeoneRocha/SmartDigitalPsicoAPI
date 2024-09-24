using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientNotificationMessageService : IEntityBaseService<PatientNotificationMessage
        ,AddPatientNotificationMessageDto,UpdatePatientNotificationMessageDto, GetPatientNotificationMessageVO>
    {
        
        Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAllByPatient(long patientId);
    }
}