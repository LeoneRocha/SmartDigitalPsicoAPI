using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientHospitalizationInformationSelectListValidator : BasePatientSelectListValidator<PatientHospitalizationInformation>
    {

        /// <summary>
        /// Método PatientHospitalizationInformationSelectListValidator: executa a operação PatientHospitalizationInformationSelectListValidator.
        /// </summary>
        public PatientHospitalizationInformationSelectListValidator(IUserRepository userRepository)
           : base(userRepository)
        { 
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientHospitalizationInformationSelectListValidator.PatientHospitalizationInformation.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
