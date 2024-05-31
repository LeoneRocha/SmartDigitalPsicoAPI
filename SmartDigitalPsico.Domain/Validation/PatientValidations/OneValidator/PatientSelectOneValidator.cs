using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator
{
    public class PatientSelectOneValidator : RecordValidator<Patient>
    {

        public PatientSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }
    }
}
