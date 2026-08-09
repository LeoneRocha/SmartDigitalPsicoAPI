using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Leaves;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por LeavesRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class LeavesRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Leaves>, ILeavesRepository
    {
        /// <summary>
        /// Método LeavesRepository: executa a operação LeavesRepository.
        /// </summary>
        public LeavesRepository(IEntityDataContext context) : base(context) { }


    }
}
