using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    public abstract class BasePatientSelectListValidator<T> : RecordsListValidator<T> where T : IEntityBaseLogUser, IEntityPatientBase
    { 
        public BasePatientSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }
        protected override async Task<bool> HasPermissionAsync(RecordsList<T> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return false; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                rg.Patient != null &&
                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.Patient.MedicalId
                );
                return userHasPermission;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
