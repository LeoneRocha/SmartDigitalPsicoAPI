namespace SmartDigitalPsico.Domain.Interfaces.Validation
{
    public interface IPatientBaseValidator<T> where T : IEntityPatientBase
    {
        Task<bool> PatientIdChanged(T entity);
        Task<bool> PatientIdFound(T entity);
    }
}