using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por PatientFileSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientFileSelectListValidator : BasePatientSelectListValidator<PatientFile>
    { 
        /// <summary>
        /// Método PatientFileSelectListValidator: executa a operação PatientFileSelectListValidator.
        /// </summary>
        public PatientFileSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        { 

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientFileSelectListValidator.PatientFile.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
