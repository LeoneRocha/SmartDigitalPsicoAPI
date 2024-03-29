using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientAdditionalInformationRepository : IEntityBaseRepository<PatientAdditionalInformation>
    {
        Task<List<PatientAdditionalInformation>> FindAllByPatient(long patientId);
    }
}
