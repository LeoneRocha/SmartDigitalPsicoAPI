using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.Office;

namespace SmartDigitalPsico.Data.Repository
{
    /// <summary>
    /// Classe responsável por OfficeRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class OfficeRepository : Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<Office>, IOfficeRepository
    {
        /// <summary>
        /// Método OfficeRepository: executa a operação OfficeRepository.
        /// </summary>
        public OfficeRepository(IEntityDataContext context) : base(context) { }
    }
}
