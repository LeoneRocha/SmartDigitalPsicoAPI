using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientRepository : IEntityBaseRepository<Patient>
    {
        Task<List<Patient>> FindAllByMedicalId(long medicalId);
        Task<Patient?> FindByEmail(string value);
        Task<Patient?> FindByPatient(Patient info);
    }
}
