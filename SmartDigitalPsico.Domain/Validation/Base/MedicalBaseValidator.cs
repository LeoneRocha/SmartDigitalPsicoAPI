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
        protected readonly IUserRepository _userRepository;

        public MedicalBaseValidator(IMedicalRepository medicalRepository, IEntityBaseRepository<T> entityRepository, IUserRepository userRepository)
        {
            _medicalRepository = medicalRepository;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
        }

        public virtual async Task<bool> MedicalIdChanged(T entity)
        {
            try
            {
                if (await _entityRepository.Exists(entity.Id))
                {
                    var entityBefore = await _entityRepository.FindByID(entity.Id);
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
        public virtual async Task<bool> MedicalCreated(T entity, long value, long? createdUserId)
        {
            try
            {
                if (entity?.Id == 0)
                {
                    long idUser = createdUserId.GetValueOrDefault();  
                    var userMedical = await _userRepository.FindByID(idUser);
                    //Usuario for medico e o id do medico of mesmo do usuario permite a criacao
                    if (userMedical.Medical != null && entity.MedicalId == userMedical.Medical.Id)
                    {
                        return true;
                    }
                    else
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
                    var userMedical = await _userRepository.FindByID(idUser);
                    //Usuario for medico e o id do medico of mesmo do usuario permite a edicao
                    if (userMedical.Medical != null && entity.MedicalId == userMedical.Medical.Id)
                    {
                        return true;
                    }
                    else
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