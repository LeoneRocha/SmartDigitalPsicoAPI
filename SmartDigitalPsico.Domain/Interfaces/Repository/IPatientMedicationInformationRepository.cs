using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientMedicationInformationRepository : IEntityBaseSimpleRepository<PatientMedicationInformation>
    {
        Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId);
    }
}
