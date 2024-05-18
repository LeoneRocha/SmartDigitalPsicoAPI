using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public abstract class RecordValidator<T> : AbstractValidator<Record<T>> where T : IEntityBaseLogUser
    {
        protected readonly IUserRepository _userRepository;

        protected RecordValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(enitty => enitty.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }

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
        public List<ErrorResponse> GetMapErros(List<ValidationFailure> errors)
        {
            return errors.Select(er => new ErrorResponse() { ErrorCode = er.ErrorCode, Message = er.ErrorMessage, Name = er.PropertyName }).ToList();
        }
    }
}
