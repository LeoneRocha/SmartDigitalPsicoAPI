using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientRecordSelectOneValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientRecordSelectOneValidator : RecordValidator<PatientRecord>
    {

        /// <summary>
        /// Método PatientRecordSelectOneValidator: executa a operação PatientRecordSelectOneValidator.
        /// </summary>
        public PatientRecordSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientRecordSelectOneValidator.PatientRecord.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
