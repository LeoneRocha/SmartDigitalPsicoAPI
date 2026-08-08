using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.ModelEntity;

using SmartDigitalPsico.Domain.Interfaces.User;
namespace SmartDigitalPsico.Domain.Validation.Principals.Calendar
{
    /// <summary>
    /// Classe responsável por MedicalCalendarListValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class MedicalCalendarListValidator : AbstractValidator<RecordsList<MedicalCalendar>>
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Método MedicalCalendarListValidator: executa a operação MedicalCalendarListValidator.
        /// </summary>
        public MedicalCalendarListValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarListValidator.Entity.UserIdLogged.Must")
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }

        private async Task<bool> HasPermissionAsync(RecordsList<MedicalCalendar> recordsList, long userIdLogged, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(userIdLogged);

                if (recordsList.Records.Count == 0) { return true; }

                bool userHasPermission = recordsList.Records.TrueForAll(rg =>
                rg.CreatedUserId == userIdLogged
                && rg.MedicalId == userLogged.MedicalId
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
