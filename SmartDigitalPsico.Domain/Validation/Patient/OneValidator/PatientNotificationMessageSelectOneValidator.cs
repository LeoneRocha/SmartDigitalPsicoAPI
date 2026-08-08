using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientNotificationMessageSelectOneValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientNotificationMessageSelectOneValidator : RecordValidator<PatientNotificationMessage>
    {

        /// <summary>
        /// Método PatientNotificationMessageSelectOneValidator: executa a operação PatientNotificationMessageSelectOneValidator.
        /// </summary>
        public PatientNotificationMessageSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientNotificationMessageSelectOneValidator.PatientNotificationMessage.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
