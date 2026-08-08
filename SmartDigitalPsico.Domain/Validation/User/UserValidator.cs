using FluentValidation;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por UserValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class UserValidator : AbstractValidator<User>
    {
        private readonly IUserRepository _entityRepository;

        /// <summary>
        /// Método UserValidator: executa a operação UserValidator.
        /// </summary>
        public UserValidator(IUserRepository entityRepository)
        {
            _entityRepository = entityRepository;

            RuleFor(entity => entity.Name)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Name.NotNull")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Name.NotEmpty")
                .WithMessage("Name_Validator_IsRequired_Key|Name is required.");

            RuleFor(entity => entity.Login)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Login.NotNull")
                .WithMessage("Login_Validator_IsRequired_Key|Login is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Login.NotEmpty")
                .WithMessage("Login_Validator_IsRequired_Key|Login is required.")
                .MaximumLength(25)
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Login.MaxLength")
                .WithMessage("Login_Validator_MaxLength_Key|Login cannot exceed {0} characters.|25")
                .MustAsync(async (entity, value, c) => await UniqueLogin(entity, value))
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Login.Must")
                .WithMessage("Login_Validator_Unique_Key|Login must be unique.");

            RuleFor(entity => entity.Email)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Email.NotNull")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Email.NotEmpty")
                .WithMessage("Email_Validator_IsRequired_Key|Email is required.")
                .EmailAddress()
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Email.EmailAddress")
                .WithMessage("Email_Validator_Invalid_Key|Invalid email address.")
                .MaximumLength(100)
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Email.MaxLength")
                .WithMessage("Email_Validator_MaxLength_Key|Email cannot exceed {0} characters.|100")
                .MustAsync(async (entity, value, c) => await UniqueEmail(entity, value))
                .WithErrorCode("SmartDigitalPsico.UserValidator.User.Email.Must")
                .WithMessage("Email_Validator_Unique_Key|Email must be unique.");

        }
        private async Task<bool> UniqueEmail(User entity, string value)
        {
            try
            {
                if (!await _entityRepository.Exists(entity.Id))
                {
                    var user = await _entityRepository.FindByEmail(value);
                    if (user == null)
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
                    return true;
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
                    return true;
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
