using System.Data.SqlTypes;
using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Domain.Interfaces.User;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Classe responsável por CalendarCriteriaValidator.
    /// Responsabilidade: validador FluentValidation de regras de negócio.
    /// Relação: invocado pelos Services antes da persistência.
    /// </summary>
    public class MedicalCalendarCriteriaValidator : AbstractValidator<CalendarCriteriaDto>
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Método CalendarCriteriaValidator: executa a operação CalendarCriteriaValidator.
        /// </summary>
        public MedicalCalendarCriteriaValidator(IUserRepository userRepository)
        {
            int maxDayRange = 90;
            int minMinuteInterval = 15;
            int maxMinuteInterval = 1440;

            _userRepository = userRepository;

            RuleFor(criteria => criteria.MedicalId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.MedicalId.NotNull")
                .WithMessage("Medical_Validator_IsRequired_Key|{0} is required.|MedicalId");

            RuleFor(criteria => criteria.Month)
                .InclusiveBetween(1, 12)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.Month.InclusiveBetween")
                .WithMessage("Month_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Month|1|12");

            RuleFor(criteria => criteria.Year)
                .GreaterThan(SqlDateTime.MinValue.Value.Year)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.Year.GreaterThan")
                .WithMessage("Year_Validator_GreaterThan_Key|{0} must be greater than {1}.|Year|" + SqlDateTime.MinValue.Value.Year.ToString());

            RuleFor(criteria => criteria.UserIdLogged)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.UserIdLogged.NotNull")
                .WithMessage("UserIdLogged_Validator_IsRequired_Key|{0} is required.|UserIdLogged");

            RuleFor(criteria => criteria.StartDate)
                .Must(BeValidDate)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.StartDate.Must")
                .WithMessage("StartDate_Validator_ValidDate_Key|{0} must be a valid date.|StartDate")
                .Must((criteria, startDate) => !startDate.HasValue || !criteria.EndDate.HasValue || (criteria.EndDate.Value - startDate.Value).TotalDays <= maxDayRange)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.StartDate.Must")
                .WithMessage("StartDateEndDate_Validator_DateRange_Key|{0} and EndDate cannot be more than {1} days apart.|StartDate|" + maxDayRange.ToString());

            RuleFor(criteria => criteria.EndDate)
                .Must(BeValidDate)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.EndDate.Must")
                .WithMessage("EndDate_Validator_ValidDate_Key|{0} must be a valid date.|EndDate")
                .Must((criteria, endDate) => !endDate.HasValue || !criteria.StartDate.HasValue || (endDate.Value - criteria.StartDate.Value).TotalDays <= maxDayRange)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.EndDate.Must")
                .WithMessage("StartDateEndDate_Validator_DateRange_Key|{0} and StartDate cannot be more than {1} days apart.|EndDate|" + maxDayRange.ToString());

            RuleFor(criteria => criteria.IntervalInMinutes)
                .InclusiveBetween(minMinuteInterval, maxMinuteInterval)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.IntervalInMinutes.InclusiveBetween")
                .WithMessage("IntervalInMinutes_Validator_InclusiveBetween_Key|{0} must be between {1} and {2}.|Interval In Minutes|" + minMinuteInterval.ToString() + "|" + maxMinuteInterval.ToString());

            RuleFor(criteria => criteria)
                .MustAsync(IsValidMedicalId)
                .WithErrorCode("SmartDigitalPsico.CalendarCriteriaValidator.CalendarCriteriaDto.Entity.Must")
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
