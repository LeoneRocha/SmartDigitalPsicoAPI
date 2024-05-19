using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Validation;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.Base
{
    public class PatientBaseValidator<T> : AbstractValidator<T>, IPatientBaseValidator<T> where T : IEntityPatientBase, IEntityBase
    {
        protected readonly IPatientRepository _patientRepository;
        protected readonly IEntityBaseRepository<T> _entityRepository;

        public PatientBaseValidator(IPatientRepository patientRepository, IEntityBaseRepository<T> entityRepository)
        {
            _patientRepository = patientRepository;
            _entityRepository = entityRepository;
        }

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

        public virtual async Task<bool> PatientIdFound(T entity)
        {
            bool result = await _patientRepository.Exists(entity.PatientId);
            return result;
        }
    }
}