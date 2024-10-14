using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class ScheduleCriteriaValidator : AbstractValidator<ScheduleCriteriaDto>
    {
        private readonly IUserRepository _userRepository;

        public ScheduleCriteriaValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            RuleFor(criteria => criteria)
                .MustAsync(IsValidMedicalId)
                .WithMessage("ErrorValidator_Invalid_MedicalId");
        }

        private async Task<bool> IsValidMedicalId(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            try
            {
                User userLogged = await _userRepository.FindByID(criteria.UserIdLogged);

                return criteria.MedicalId == userLogged.MedicalId;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}