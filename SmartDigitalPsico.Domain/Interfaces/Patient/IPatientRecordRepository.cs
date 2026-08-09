using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRecordRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientRecordRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientRecord>
    {
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<List<PatientRecord>> FindAllByPatient(long patientId);
    }
}
