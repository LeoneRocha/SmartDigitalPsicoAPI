using SpecialtyEntity = SmartDigitalPsico.Domain.EntityModels.Specialty;

namespace SmartDigitalPsico.Domain.Interfaces.Specialty
{
    /// <summary>
    /// Interface (contrato) responsável por ISpecialtyRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ISpecialtyRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<SpecialtyEntity>
    {
        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        Task<List<SpecialtyEntity>> FindByIDs(List<long> idsSpecialties);
    }
}
