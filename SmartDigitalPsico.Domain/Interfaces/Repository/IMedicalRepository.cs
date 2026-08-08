using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMedicalRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Medical>
    {
        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        Task<bool> Exists(string accreditation);
        /// <summary>
        /// Método FindByAccreditation: consulta e retorna dados.
        /// </summary>
        Task<Medical?> FindByAccreditation(string accreditation);
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<Medical?> FindByEmail(string email);
    }
}
