using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.RoleGroup;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por RoleGroupRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class RoleGroupRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<RoleGroup>, IRoleGroupRepository
    {
        /// <summary>
        /// Método RoleGroupRepository: executa a operação RoleGroupRepository.
        /// </summary>
        public RoleGroupRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        public async Task<List<RoleGroup>> FindByIDs(List<long>? roleGroupsIds)
        {
            if (roleGroupsIds == null) { return new List<RoleGroup>(); }

            return await _dataset
                .AsNoTracking()
                .Where(p => roleGroupsIds.Contains(p.Id)).ToListAsync();
        }
    }
}
