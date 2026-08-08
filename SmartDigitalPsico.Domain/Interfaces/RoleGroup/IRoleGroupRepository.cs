using SmartDigitalPsico.Domain.EntityModels.Schedule;

using RoleGroupEntity = SmartDigitalPsico.Domain.EntityModels.RoleGroup;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.RoleGroup
{
    /// <summary>
    /// Interface (contrato) responsável por IRoleGroupRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IRoleGroupRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<RoleGroupEntity>
    {
        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        Task<List<RoleGroupEntity>> FindByIDs(List<long>? roleGroupsIds);
    }
}
