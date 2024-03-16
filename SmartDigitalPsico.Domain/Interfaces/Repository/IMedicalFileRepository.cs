using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMedicalFileRepository : IEntityBaseSimpleRepository<MedicalFile>
    {
        Task<List<MedicalFile>> FindAllByMedical(long medicalId);
    }
}
