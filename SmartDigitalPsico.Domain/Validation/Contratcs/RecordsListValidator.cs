using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public abstract class RecordsListValidator<T> : AbstractValidator<RecordsList<T>> where T : IEntityBaseLogUser
    {
        protected readonly IUserRepository _userRepository;

        public RecordsListValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");  
        }

        protected virtual async Task<bool> HasPermissionAsync(RecordsList<T> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            bool userHasPermission = false;
            User? userLogged = await this._userRepository.FindByID(userIdLogged);
            if (recordsList.Records.Count == 0 || userLogged == null) { return false; }

            userHasPermission = recordsList.Records.TrueForAll(rg =>
            rg.CreatedUser?.Id == userIdLogged 
            || userLogged.Admin 
            ); 

            return userHasPermission;
        }
        public List<ErrorResponse> GetMapErros(List<ValidationFailure> errors)
        {
            return errors.DistinctBy(d=> d.PropertyName).Select(er => new ErrorResponse() { ErrorCode = er.ErrorCode, Message = er.ErrorMessage, Name = er.PropertyName }).ToList();
        }
    }
}
