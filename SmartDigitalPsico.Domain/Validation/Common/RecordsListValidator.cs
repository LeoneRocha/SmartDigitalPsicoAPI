using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por RecordsListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public abstract class RecordsListValidator<T> : AbstractValidator<RecordsList<T>> where T : IEntityBaseLogUser
    {
        protected readonly IUserRepository _userRepository;

        /// <summary>
        /// Método RecordsListValidator: executa a operação RecordsListValidator.
        /// </summary>
        protected RecordsListValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.RecordsListValidator.Entity.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }

        /// <summary>
        /// Método HasPermissionAsync: executa a operação HasPermissionAsync.
        /// </summary>
        protected virtual async Task<bool> HasPermissionAsync(RecordsList<T> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await this._userRepository.FindByID(userIdLogged);
                if (userLogged == null) { return false; }
                if (recordsList.Records.Count == 0) { return true; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                rg.CreatedUser?.Id == userIdLogged
                || userLogged.Admin
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
