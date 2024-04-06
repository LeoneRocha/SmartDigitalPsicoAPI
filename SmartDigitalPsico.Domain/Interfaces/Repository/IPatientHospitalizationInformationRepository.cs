using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientHospitalizationInformationRepository : IEntityBaseRepository<PatientHospitalizationInformation>
    {
        Task<List<PatientHospitalizationInformation>> FindAllByPatient(long patientId);
    }
}
