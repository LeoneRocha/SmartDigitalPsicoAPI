using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientAdditionalInformationRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientAdditionalInformationRepository : IEntityBaseRepository<PatientAdditionalInformation>
    {
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<List<PatientAdditionalInformation>> FindAllByPatient(long patientId);
    }
}
