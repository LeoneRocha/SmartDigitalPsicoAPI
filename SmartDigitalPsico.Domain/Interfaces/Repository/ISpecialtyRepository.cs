using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por ISpecialtyRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ISpecialtyRepository : IEntityBaseRepository<Specialty>
    {
        /// <summary>
        /// Método FindByIDs: consulta e retorna dados.
        /// </summary>
        Task<List<Specialty>> FindByIDs(List<long> idsSpecialties);
    }
}
