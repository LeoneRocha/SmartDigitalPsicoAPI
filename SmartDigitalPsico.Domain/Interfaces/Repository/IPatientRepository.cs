using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientRepository : IEntityBaseRepository<Patient>
    {
        Task<List<Patient>> FindAllByMedicalId(long medicalId);
        Task<Patient?> FindByEmail(string email);
        Task<Patient> FindByPatient(Patient patient);
        Task<Patient> GetPatientDetailsByIdAsync(long id);
    }
}
