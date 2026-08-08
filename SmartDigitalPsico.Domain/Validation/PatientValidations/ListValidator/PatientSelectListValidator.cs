using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por PatientSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class PatientSelectListValidator : RecordsListValidator<Patient>
    {
        /// <summary>
        /// Método PatientSelectListValidator: executa a operação PatientSelectListValidator.
        /// </summary>
        public PatientSelectListValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.PatientSelectListValidator.Patient.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
        /// <summary>
        /// Método HasPermissionAsync: executa a operação HasPermissionAsync.
        /// </summary>
        protected override async Task<bool> HasPermissionAsync(RecordsList<Patient> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return true; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>

                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.MedicalId
                );
                return userHasPermission;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
