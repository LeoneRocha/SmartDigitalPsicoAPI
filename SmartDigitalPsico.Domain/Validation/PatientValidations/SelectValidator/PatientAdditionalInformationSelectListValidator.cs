using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public class PatientAdditionalInformationSelectListValidator : RecordsListValidator<PatientAdditionalInformation>
    {

        public PatientAdditionalInformationSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(this.HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }
        protected override async Task<bool> HasPermissionAsync(RecordsList<PatientAdditionalInformation> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            bool userHasPermission = false;
            User? userLogged = await base._userRepository.FindByID(userIdLogged);

            if (recordsList.Records.Count == 0 || userLogged == null) { return false; }

            userHasPermission = recordsList.Records.All(rg =>
            (
            rg.CreatedUser?.Id == userIdLogged
            && userLogged.MedicalId == rg.Patient.MedicalId) 
            );

            return userHasPermission;
        }


    }
}
