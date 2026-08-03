using System.Threading.Tasks;

namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    /// <summary>
    /// Interface (contrato) responsável por IMedicalBaseValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMedicalBaseValidator<T> where T : IEntityMedicalBase
    {
        /// <summary>
        /// Método MedicalIdChanged: executa a operação MedicalIdChanged.
        /// </summary>
        Task<bool> MedicalIdChanged(T entity);
        /// <summary>
        /// Método MedicalIdFound: executa a operação MedicalIdFound.
        /// </summary>
        Task<bool> MedicalIdFound(T entity);
        /// <summary>
        /// Método MedicalModify: executa a operação MedicalModify.
        /// </summary>
        Task<bool> MedicalModify(T entity, long value, long? modifyUserId);

        /// <summary>
        /// Método MedicalCreated: executa a operação MedicalCreated.
        /// </summary>
        Task<bool> MedicalCreated(T entity, long value, long? createdUserId);
    }
}
