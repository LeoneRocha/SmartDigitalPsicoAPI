using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;

using IEntityBase = SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase;
namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    /// <summary>
    /// Classe responsável por BasePatientSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public abstract class BasePatientSelectListValidator<T> : RecordsListValidator<T> where T : IEntityBaseLogUser, IEntityPatientBase
    {
        /// <summary>
        /// Método BasePatientSelectListValidator: executa a operação BasePatientSelectListValidator.
        /// </summary>
        protected BasePatientSelectListValidator(IUserRepository userRepository)
          : base(userRepository)
        { 

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.BasePatientSelectListValidator.Entity.UserIdLogged.Must")
                .WithMessage("User_Not_Permission_Key|User does not have permission.");
        }
        /// <summary>
        /// Método HasPermissionAsync: executa a operação HasPermissionAsync.
        /// </summary>
        protected override async Task<bool> HasPermissionAsync(RecordsList<T> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return true; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                rg.Patient != null &&
                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.Patient.MedicalId
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
