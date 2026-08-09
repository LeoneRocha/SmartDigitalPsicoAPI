using System.Data;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Specialty;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por SpecialtyRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class SpecialtyRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Specialty>, ISpecialtyRepository
    {
        /// <summary>
        /// Método SpecialtyRepository: executa a operação SpecialtyRepository.
        /// </summary>
        public SpecialtyRepository(IEntityDataContext context) : base(context) { }

        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        public async Task<List<Specialty>> FindByIDs(List<long> idsSpecialties)
        {
            return await _dataset
                .AsNoTracking()
                .Where(p => idsSpecialties.Contains(p.Id)).ToListAsync();
        }
    }
}
