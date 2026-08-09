using FluentValidation;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.User;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientRecordSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientRecordSelectListValidator
             : BasePatientSelectListValidator<PatientRecord>
    {
        /// <summary>
        /// Método PatientRecordSelectListValidator: executa a operação PatientRecordSelectListValidator.
        /// </summary>
        public PatientRecordSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientRecordSelectListValidator.PatientRecord.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
