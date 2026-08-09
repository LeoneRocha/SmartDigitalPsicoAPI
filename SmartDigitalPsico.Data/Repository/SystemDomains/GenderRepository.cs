using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

using SmartDigitalPsico.Domain.Interfaces.Gender;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por GenderRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class GenderRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Gender>, IGenderRepository
    {
        /// <summary>
        /// Método GenderRepository: executa a operação GenderRepository.
        /// </summary>
        public GenderRepository(IEntityDataContext context) : base(context) { }
    }
}
