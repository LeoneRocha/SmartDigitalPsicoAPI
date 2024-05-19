using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Principals
{
    public class UserValidator : AbstractValidator<User>
    {
        private readonly IUserRepository _entityRepository;

        public UserValidator(IUserRepository entityRepository)
        {
            _entityRepository = entityRepository;

            RuleFor(entity => entity.Name)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_Name_Null");

            RuleFor(entity => entity.Login)
                .NotNull().NotEmpty()
                .WithMessage("ErrorValidator_Login_Null")
                .MaximumLength(25)
                .WithMessage("O Login não pode ultrapassar {MaxLength} carateres.")
                .MustAsync(async (entity, value, c) => await UniqueLogin(entity, value))
               .WithMessage("ErrorValidator_Login_Unique");

            RuleFor(entity => entity.Email)
               .NotNull().NotEmpty()
               .WithMessage("ErrorValidator_Email_Null")
               .EmailAddress()
               .WithMessage("ErrorValidator_Email_Invalid")
               .MaximumLength(100)
               .WithMessage("O Email não pode ultrapassar {MaxLength} carateres.")
               .MustAsync(async (entity, value, c) => await UniqueEmail(entity, value))
               .WithMessage("ErrorValidator_Email_Unique");

        }
        private async Task<bool> UniqueEmail(User entity, string value)
        {
            try
            {
                if (!await _entityRepository.Exists(entity.Id))
                {    
                    var user = await _entityRepository.FindByEmail(value);
                    if (user == null || user?.Id == 0)
                    {
                        return true;
                    }
                }
                else
                {
                    var existingEnity = await _entityRepository.FindByID(entity.Id);
                    bool changingProp = !existingEnity.Email.Equals(value, StringComparison.OrdinalIgnoreCase);
                    if (changingProp)
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return false;
        }
        private async Task<bool> UniqueLogin(User entity, string value)
        { 
            try
            {
                if (!await _entityRepository.Exists(entity.Id))
                {
                    var user = await _entityRepository.FindByLogin(value);
                    if (user == null)
                    {
                        return true;
                    }
                }
                else
                {
                    var existingEnity = await _entityRepository.FindByID(entity.Id);
                    bool changingProp = !existingEnity.Login.Equals(value, StringComparison.OrdinalIgnoreCase);
                    if (changingProp)
                    {
                        return false;
                    }
                } 
            }
            catch (Exception)
            {
                return false;
            } 
            return false;
        }
    }
}
