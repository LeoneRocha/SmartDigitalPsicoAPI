using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientNotificationMessageRepository : IEntityBaseSimpleRepository<PatientNotificationMessage>
    {
        Task<List<PatientNotificationMessage>> FindAllByPatient(long patientId);
    }
}
