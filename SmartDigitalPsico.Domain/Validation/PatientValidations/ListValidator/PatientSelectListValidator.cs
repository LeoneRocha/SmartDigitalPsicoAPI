using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    public class PatientSelectListValidator : RecordsListValidator<Patient>
    {
        public PatientSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }
        protected override async Task<bool> HasPermissionAsync(RecordsList<Patient> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return false; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>

                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.MedicalId
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
