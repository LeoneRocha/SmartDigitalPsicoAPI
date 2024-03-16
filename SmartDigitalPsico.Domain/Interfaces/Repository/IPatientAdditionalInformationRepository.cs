using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IPatientAdditionalInformationRepository : IEntityBaseSimpleRepository<PatientAdditionalInformation>
    {
        Task<List<PatientAdditionalInformation>> FindAllByPatient(long patientId);
    }
}
