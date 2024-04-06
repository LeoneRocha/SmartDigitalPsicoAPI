using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMedicalFileRepository : IEntityBaseRepository<MedicalFile>
    {
        Task<List<MedicalFile>> FindAllByMedical(long medicalId);
    }
}
