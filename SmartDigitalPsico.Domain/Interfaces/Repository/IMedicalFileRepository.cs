using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalFileRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMedicalFileRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalFile>
    {
        /// <summary>
        /// Método FindAllByMedical: consulta e retorna dados.
        /// </summary>
        Task<List<MedicalFile>> FindAllByMedical(long medicalId);
    }
}
