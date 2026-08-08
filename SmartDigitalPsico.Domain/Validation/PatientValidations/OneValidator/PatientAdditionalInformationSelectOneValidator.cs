using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator
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
