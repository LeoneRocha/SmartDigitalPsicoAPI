using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Validation;

namespace SmartDigitalPsico.Domain.Validation.Base
{
    public class MedicalBaseValidator<T> : AbstractValidator<T>, IMedicalBaseValidator<T> where T : IEntityMedicalBase, IEntityBase
    {
        protected readonly IMedicalRepository _medicalRepository;
        protected readonly IEntityBaseRepository<T> _entityRepository;

        public MedicalBaseValidator(IMedicalRepository medicalRepository, IEntityBaseRepository<T> entityRepository)
        {
            _medicalRepository = medicalRepository;
            _entityRepository = entityRepository;
        }

        public virtual async Task<bool> MedicalIdChanged(T entity)
        {
            try
            {
                if (await _entityRepository.Exists(entity.Id))
                {
                    var entityBefore = await _entityRepository.FindByID(entity.MedicalId);
                    if (entityBefore.MedicalId != entity.MedicalId)
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

        public virtual async Task<bool> MedicalIdFound(T entity)
        {
            bool result = await _medicalRepository.Exists(entity.MedicalId);
            return result;
        } 
        public virtual async Task<bool> MedicalCreated(T entity, long value , long? createdUserId)
        {
            try
            {
                if (entity?.Id == 0)
                {
                    long idUser = createdUserId.GetValueOrDefault();
                    var medical = await _medicalRepository.FindByID(value);
                    if ((medical.UserId != idUser))
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

        public virtual async Task<bool> MedicalModify(T entity, long value, long? modifyUserId)
        {
            try
            {
                if (entity?.Id > 0)
                {
                    long idUser = modifyUserId.GetValueOrDefault();
                    var medical = await _medicalRepository.FindByID(value);
                    if ((medical.UserId != idUser))
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
    }
}