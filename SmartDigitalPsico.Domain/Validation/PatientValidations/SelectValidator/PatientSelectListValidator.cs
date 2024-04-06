using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
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

        protected override Task<bool> HasPermissionAsync(RecordsList<Patient> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            return base.HasPermissionAsync(recordsList, userIdLogged, cancellationToken);
        }
    }
}
