using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using System.Data.SqlTypes;

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
                .WithMessage("Medical_Validator_IsRequired_Key|{0} is required.|MedicalId");

            RuleFor(criteria => criteria.Month)
                .InclusiveBetween(1, 12)
                .WithMessage("Month_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Month|1|12");

            RuleFor(criteria => criteria.Year)
                .GreaterThan(SqlDateTime.MinValue.Value.Year)
                .WithMessage("Year_Validator_GreaterThan_Key|{0} must be greater than {1}.|Year|" + SqlDateTime.MinValue.Value.Year.ToString());

            RuleFor(criteria => criteria.UserIdLogged)
                .NotNull()
                .WithMessage("UserIdLogged_Validator_IsRequired_Key|{0} is required.|UserIdLogged");

            RuleFor(criteria => criteria.StartDate)
                .Must(BeValidDate)
                .WithMessage("StartDate_Validator_ValidDate_Key|{0} must be a valid date.|StartDate")
                .Must((criteria, startDate) => !criteria.EndDate.HasValue || (criteria.EndDate.Value - startDate!.Value).TotalDays <= maxDayRange)
                .WithMessage("StartDateEndDate_Validator_DateRange_Key|{0} and EndDate cannot be more than {1} days apart.|StartDate|" + maxDayRange.ToString());

            RuleFor(criteria => criteria.EndDate)
                .Must(BeValidDate)
                .WithMessage("EndDate_Validator_ValidDate_Key|{0} must be a valid date.|EndDate")
                .Must((criteria, endDate) => !criteria.StartDate.HasValue || (endDate!.Value - criteria.StartDate.Value).TotalDays <= maxDayRange)
                .WithMessage("StartDateEndDate_Validator_DateRange_Key|{0} and StartDate cannot be more than {1} days apart.|EndDate|" + maxDayRange.ToString());

            RuleFor(criteria => criteria.IntervalInMinutes)
                .InclusiveBetween(minMinuteInterval, maxMinuteInterval)
                .WithMessage("IntervalInMinutes_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Interval In Minutes|" + minMinuteInterval.ToString() + "|" + maxMinuteInterval.ToString());

            RuleFor(criteria => criteria)
                .MustAsync(IsValidMedicalId)
                .WithMessage("ErrorValidator_Invalid_MedicalId|{0} is invalid.|MedicalId");
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
