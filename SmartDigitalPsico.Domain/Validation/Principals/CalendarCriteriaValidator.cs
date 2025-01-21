using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class CalendarCriteriaValidator : AbstractValidator<CalendarCriteriaDto>
    {
        private readonly IUserRepository _userRepository;

        public CalendarCriteriaValidator(IUserRepository userRepository)
        {
            int maxDayRange = 90;
            int minMinuteInterval = 15;
            int maxMinuteInterval = 1440;

            _userRepository = userRepository;

            RuleFor(criteria => criteria.MedicalId)
                .NotNull()
                .WithMessage("MedicalId is required.");

            RuleFor(criteria => criteria.Month)
                .InclusiveBetween(1, 12)
                .WithMessage("Month must be between 1 and 12.");

            RuleFor(criteria => criteria.Year)
                .GreaterThan(0)
                .WithMessage("Year must be greater than 0.");

            RuleFor(criteria => criteria.UserIdLogged)
                .NotNull()
                .WithMessage("UserIdLogged is required.");

            RuleFor(criteria => criteria.StartDate)
                .Must(BeValidDate)
                .WithMessage("StartDate must be a valid date.")
                .Must((criteria, startDate) => !criteria.EndDate.HasValue || (criteria.EndDate.Value - startDate!.Value).TotalDays <= maxDayRange)
                .WithMessage($"StartDate and EndDate cannot be more than  {maxDayRange} days apart.");

            RuleFor(criteria => criteria.EndDate)
                .Must(BeValidDate)
                .WithMessage("EndDate must be a valid date.")
                .Must((criteria, endDate) => !criteria.StartDate.HasValue || (endDate!.Value - criteria.StartDate.Value).TotalDays <= maxDayRange)
                .WithMessage($"StartDate and EndDate cannot be more than {maxDayRange} days apart.");

            RuleFor(criteria => criteria.IntervalInMinutes)
                .InclusiveBetween(minMinuteInterval, maxMinuteInterval)
                .WithMessage($"Interval In Minutes must be between {minMinuteInterval} and {maxMinuteInterval}.");

            RuleFor(criteria => criteria)
                .MustAsync(IsValidMedicalId)
                .WithMessage("ErrorValidator_Invalid_MedicalId");
        }

        private static bool BeValidDate(DateTime? date)
        {
            return !date.HasValue || date.Value > DateTime.MinValue;
        }

        private async Task<bool> IsValidMedicalId(CalendarCriteriaDto criteria, CancellationToken cancellationToken)
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