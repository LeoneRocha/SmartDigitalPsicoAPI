using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientNotificationMessageRepository : IEntityBaseRepository<PatientNotificationMessage>
    {
        Task<List<PatientNotificationMessage>> FindAllByPatient(long patientId);
    }
}
