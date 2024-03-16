using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Principals
{
    public class UserValidator : AbstractValidator<User>
    {
        private IUserRepository _entityRepository;
        //https://docs.fluentvalidation.net/en/latest/start.html        
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
            var userActual = await _entityRepository.FindByID(entity.Id);
            bool newUser = userActual == null; 
            var user = await _entityRepository.FindByEmail(value);
            if (newUser && user == null || user?.Id == 0)
            {
                return true;
            } 
            bool changingEmail = userActual != null && userActual.Email != value;
            if (!changingEmail)
            {
                return true;
            } 
            return false;
        }
        private async Task<bool> UniqueLogin(User entity, string value)
        {
            var userActual = await _entityRepository.FindByID(entity.Id);
            bool newUser = userActual == null; 
            var user = await _entityRepository.FindByLogin(value);
            if (newUser && user == null || user?.Id == 0)
            {
                return true;
            } 
            bool changingEmail = userActual != null && userActual.Login != value;
            if (!changingEmail)
            {
                return true;
            } 
            return false;
        }
    }
}
