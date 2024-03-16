using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IPatientNotificationMessageService : IEntityBaseSimpleService<PatientNotificationMessage
        ,AddPatientNotificationMessageVO,UpdatePatientNotificationMessageVO, GetPatientNotificationMessageVO>
    {
        
        Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAllByPatient(long patientId);
    }
}