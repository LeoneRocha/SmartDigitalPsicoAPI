using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMedicalRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<MedicalEntity>
    {
        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        Task<bool> Exists(string accreditation);
        /// <summary>
        /// Método FindByAccreditation: consulta e retorna dados.
        /// </summary>
        Task<MedicalEntity?> FindByAccreditation(string accreditation);
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<MedicalEntity?> FindByEmail(string email);
    }
}
