using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    public class PatientAdditionalInformationSelectListValidator : BasePatientSelectListValidator<PatientAdditionalInformation>
    {

        public PatientAdditionalInformationSelectListValidator(IUserRepository userRepository)
             : base(userRepository)
        {

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("User_Not_Permission_Key|User does not have permission.");

        }
    }
}
