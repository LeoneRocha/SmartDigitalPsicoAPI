using FluentValidation;
using FluentValidation.Results;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public abstract class RecordsListValidator<T> : AbstractValidator<RecordsList<T>> where T : IEntityBaseLogUser
    {
        protected readonly IUserRepository _userRepository;

        protected RecordsListValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");
        }

        protected virtual async Task<bool> HasPermissionAsync(RecordsList<T> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await this._userRepository.FindByID(userIdLogged);
                if (recordsList.Records.Count == 0 || userLogged == null) { return false; }

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
