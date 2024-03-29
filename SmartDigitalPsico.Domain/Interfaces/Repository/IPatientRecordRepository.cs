using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientRecordRepository : IEntityBaseRepository<PatientRecord>
    {
        Task<List<PatientRecord>> FindAllByPatient(long patientId);
    }
}
