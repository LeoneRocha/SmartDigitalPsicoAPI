using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    /// <summary>
    /// Classe responsável por RecordValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public abstract class RecordValidator<T> : AbstractValidator<Record<T>> where T : IEntityBaseLogUser
    {
        protected readonly IUserRepository _userRepository;

        /// <summary>
        /// Método RecordValidator: executa a operação RecordValidator.
        /// </summary>
        protected RecordValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(enitty => enitty.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.RecordValidator.Entity.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }

        /// <summary>
        /// Método HasPermissionAsync: executa a operação HasPermissionAsync.
        /// </summary>
        protected virtual async Task<bool> HasPermissionAsync(Record<T> enittyRecord, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                bool userHasPermission = false;
                User userLogged = await _userRepository.FindByID(userIdLogged);
                userHasPermission = enittyRecord.RecordEntity.CreatedUser?.Id == userIdLogged || userLogged.Admin;
                return userHasPermission;
            }
            catch (Exception)
            {
                return false;
            }
        } 
    }
}
