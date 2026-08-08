using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationSelectOneValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientAdditionalInformationSelectOneValidator : RecordValidator<PatientAdditionalInformation>
    {

        /// <summary>
        /// Método PatientAdditionalInformationSelectOneValidator: executa a operação PatientAdditionalInformationSelectOneValidator.
        /// </summary>
        public PatientAdditionalInformationSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationSelectOneValidator.PatientAdditionalInformation.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
