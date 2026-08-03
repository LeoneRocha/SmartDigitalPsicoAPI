using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationSelectOneValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientMedicationInformationSelectOneValidator : RecordValidator<PatientMedicationInformation>
    {

        /// <summary>
        /// Método PatientMedicationInformationSelectOneValidator: executa a operação PatientMedicationInformationSelectOneValidator.
        /// </summary>
        public PatientMedicationInformationSelectOneValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientMedicationInformationSelectOneValidator.PatientMedicationInformation.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
