using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ISpecialtyRepository : IEntityBaseRepository<Specialty>
    {
        Task<List<Specialty>> FindByIDs(List<long> idsSpecialties);
    }
}
