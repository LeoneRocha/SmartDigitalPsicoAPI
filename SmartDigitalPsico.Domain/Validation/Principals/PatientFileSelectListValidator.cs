using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public class MedicalFileSelectListValidator : RecordsListValidator<MedicalFile>
    {

        public MedicalFileSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");  
        }
        protected override async Task<bool> HasPermissionAsync(RecordsList<MedicalFile> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await base._userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return false; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                (
                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.MedicalId)
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
