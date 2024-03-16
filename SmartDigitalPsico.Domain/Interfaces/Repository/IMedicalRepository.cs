using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMedicalRepository : IEntityBaseRepository<Medical>
    {
        Task<bool> Exists(string accreditation);
        Task<Medical> FindByAccreditation(string accreditation);
        Task<Medical> FindByEmail(string email);
    }
}
