using System.Threading.Tasks;

namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    public interface IMedicalBaseValidator<T> where T : IEntityMedicalBase
    {
        Task<bool> MedicalIdChanged(T entity);
        Task<bool> MedicalIdFound(T entity);
        Task<bool> MedicalModify(T entity, long value, long? modifyUserId);

        Task<bool> MedicalCreated(T entity, long value, long? createdUserId);
    }
}