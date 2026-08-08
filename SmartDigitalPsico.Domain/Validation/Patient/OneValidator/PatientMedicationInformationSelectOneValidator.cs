using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
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
