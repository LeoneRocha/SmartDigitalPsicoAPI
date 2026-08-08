using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IRoleGroupRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IRoleGroupRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<RoleGroup>
    {
        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds);
    }
}
