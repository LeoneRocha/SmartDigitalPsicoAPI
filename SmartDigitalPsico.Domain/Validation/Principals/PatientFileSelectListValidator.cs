using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    /// <summary>
    /// Classe responsável por MedicalFileSelectListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class MedicalFileSelectListValidator : RecordsListValidator<MedicalFile>
    {

        /// <summary>
        /// Método MedicalFileSelectListValidator: executa a operação MedicalFileSelectListValidator.
        /// </summary>
        public MedicalFileSelectListValidator(IUserRepository userRepository)
           : base(userRepository)
        {  
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.MedicalFileSelectListValidator.MedicalFile.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }

        /// <summary>
        /// Método HasPermissionAsync: executa a operação HasPermissionAsync.
        /// </summary>
        protected override async Task<bool> HasPermissionAsync(RecordsList<MedicalFile> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await base._userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return true; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                (
                rg.CreatedUser?.Id == userIdLogged
                && userLogged.MedicalId == rg.MedicalId)
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
