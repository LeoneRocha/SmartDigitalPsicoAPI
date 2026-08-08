using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Data;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por SpecialtyRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class SpecialtyRepository : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Specialty>, ISpecialtyRepository 
    {
        /// <summary>
        /// Método SpecialtyRepository: executa a operação SpecialtyRepository.
        /// </summary>
        public SpecialtyRepository(IEntityDataContext context) : base((Microsoft.EntityFrameworkCore.DbContext)context) { }
          
        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        public async Task<List<Specialty>> FindByIDs(List<long> idsSpecialties)
        {
            return await _dataset
                .AsNoTracking()
                .Where(p =>  idsSpecialties.Contains(p.Id)).ToListAsync();
        } 
    }
}
