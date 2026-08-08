using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por RoleGroupRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class RoleGroupRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<RoleGroup>, IRoleGroupRepository
    {
        /// <summary>
        /// Método RoleGroupRepository: executa a operação RoleGroupRepository.
        /// </summary>
        public RoleGroupRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }

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
