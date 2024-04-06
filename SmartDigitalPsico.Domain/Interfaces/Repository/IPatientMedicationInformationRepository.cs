using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientMedicationInformationRepository : IEntityBaseRepository<PatientMedicationInformation>
    {
        Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId);
    }
}
