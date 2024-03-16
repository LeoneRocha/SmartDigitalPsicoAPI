using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ISpecialtyRepository : IEntityBaseSimpleRepository<Specialty>
    {
        Task<List<Specialty>> FindByIDs(List<long> idsSpecialties);
    }
}
