using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalCalendarRangeValidator : AbstractValidator<MedicalCalendar>
    {
        private readonly IMedicalCalendarRepository _entityRepository;

        public MedicalCalendarRangeValidator(IMedicalCalendarRepository entityRepository)
        {
            _entityRepository = entityRepository;

            RuleFor(m => m)
                .MustAsync(NoDateConflict)
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same doctor.");
        }

        private async Task<bool> NoDateConflict(MedicalCalendar calendar, CancellationToken cancellationToken)
        {
            return await ValidConflict(calendar, _entityRepository);
        }

        public static async Task<bool> ValidConflict(MedicalCalendar calendar, IMedicalCalendarRepository _entityRepository)
        {
            var existingCalendars = await _entityRepository.GetMedicalCalendarsForMedicalAsync(
                 calendar.MedicalId, calendar.StartDateTime, calendar.EndDateTime.GetValueOrDefault());

            var existsDates = existingCalendars.ToList().Exists(c => c.Id != calendar.Id &&
                                               c.StartDateTime < calendar.EndDateTime &&
                                               c.EndDateTime > calendar.StartDateTime);
            return !existsDates;
        } 
    } 
}