using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientAdditionalInformationSelectListValidator : BasePatientSelectListValidator<PatientAdditionalInformation>
    {

        /// <summary>
        /// Método PatientAdditionalInformationSelectListValidator: executa a operação PatientAdditionalInformationSelectListValidator.
        /// </summary>
        public PatientAdditionalInformationSelectListValidator(IUserRepository userRepository)
             : base(userRepository)
        {

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientAdditionalInformationSelectListValidator.PatientAdditionalInformation.UserIdLogged.Must")
                .WithMessage("User_Not_Permission_Key|User does not have permission.");

        }
    }
}
