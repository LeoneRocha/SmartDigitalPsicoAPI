using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por LeavesRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class LeavesRepository : GenericRepositoryEntityBase<Leaves>, ILeavesRepository
    {
        /// <summary>
        /// Método LeavesRepository: executa a operação LeavesRepository.
        /// </summary>
        public LeavesRepository(IEntityDataContext context) : base(context) { }

       
    }
}
