using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientMedicationInformationSelectListValidator
        : BasePatientSelectListValidator<PatientMedicationInformation>

    {
        /// <summary>
        /// Método PatientMedicationInformationSelectListValidator: executa a operação PatientMedicationInformationSelectListValidator.
        /// </summary>
        public PatientMedicationInformationSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationSelectListValidator.PatientMedicationInformation.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
