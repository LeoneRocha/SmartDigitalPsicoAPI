using PatientEntity = SmartDigitalPsico.Domain.ModelEntity.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientBaseValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientBaseValidator<T> where T : IEntityPatientBase
    {
        /// <summary>
        /// Método PatientIdChanged: executa a operação PatientIdChanged.
        /// </summary>
        Task<bool> PatientIdChanged(T entity);
        /// <summary>
        /// Método PatientIdFound: executa a operação PatientIdFound.
        /// </summary>
        Task<bool> PatientIdFound(T entity);
    }
}
