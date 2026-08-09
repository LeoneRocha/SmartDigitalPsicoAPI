using FluentValidation;

using SmartDigitalPsico.Domain.Interfaces.Patient;
namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientBaseValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientBaseValidator<T> : AbstractValidator<T>, IPatientBaseValidator<T> where T : IEntityPatientBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase
    {
        protected readonly IPatientRepository _patientRepository;
        protected readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<T> _entityRepository;

        /// <summary>
        /// Método PatientBaseValidator: executa a operação PatientBaseValidator.
        /// </summary>
        public PatientBaseValidator(IPatientRepository patientRepository, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<T> entityRepository)
        {
            _patientRepository = patientRepository;
            _entityRepository = entityRepository;
        }

        /// <summary>
        /// Método PatientIdChanged: executa a operação PatientIdChanged.
        /// </summary>
        public virtual async Task<bool> PatientIdChanged(T entity)
        {
            try
            {
                if (await _entityRepository.Exists(entity.Id))
                {
                    var entityBefore = await _entityRepository.FindByID(entity.PatientId);
                    if (entityBefore.PatientId != entity.PatientId)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método PatientIdFound: executa a operação PatientIdFound.
        /// </summary>
        public virtual async Task<bool> PatientIdFound(T entity)
        {
            bool result = await _patientRepository.Exists(entity.PatientId);
            return result;
        }

        /// <summary>
        /// Método MedicalCreated: executa a operação MedicalCreated.
        /// </summary>
        public virtual async Task<bool> MedicalCreated(T entity, long? createdUserId)
        {
            long idUser = createdUserId.GetValueOrDefault();
            try
            {
                var patient = await _patientRepository.FindByID(entity.PatientId);
                if (patient.Medical != null && patient.Medical.UserId != idUser)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método MedicalModify: executa a operação MedicalModify.
        /// </summary>
        public virtual async Task<bool> MedicalModify(T entity, long? modifyUserId)
        {
            long idUser = modifyUserId.GetValueOrDefault();
            try
            {
                var patient = await _patientRepository.FindByID(entity.PatientId);
                if (patient.Medical != null && patient.Medical.UserId != idUser)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
