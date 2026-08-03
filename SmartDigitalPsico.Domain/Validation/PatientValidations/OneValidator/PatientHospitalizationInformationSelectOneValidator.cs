using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationSelectOneValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientHospitalizationInformationSelectOneValidator : RecordValidator<PatientHospitalizationInformation>
    {

        /// <summary>
        /// Método PatientHospitalizationInformationSelectOneValidator: executa a operação PatientHospitalizationInformationSelectOneValidator.
        /// </summary>
        public PatientHospitalizationInformationSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationSelectOneValidator.PatientHospitalizationInformation.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
