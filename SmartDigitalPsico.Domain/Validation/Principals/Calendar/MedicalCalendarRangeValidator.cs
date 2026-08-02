using FluentValidation;
using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Calendar
{
    /// <summary>
    /// Range/conflict validator against ScheduleCalendar SoT.
    /// Not intended as the primary <c>IValidator&lt;MedicalCalendar&gt;</c> (see MedicalCalendarValidator).
    /// </summary>
    public class MedicalCalendarRangeValidator : AbstractValidator<MedicalCalendar>
    {
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;

        public MedicalCalendarRangeValidator(IScheduleCalendarRepository scheduleCalendarRepository)
        {
            _scheduleCalendarRepository = scheduleCalendarRepository;
            RuleFor(m => m)
                .MustAsync(NoDateConflictSchedule)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarRangeValidator.MedicalCalendar.Entity.Must")
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same doctor.");
        }

        private async Task<bool> NoDateConflictSchedule(MedicalCalendar calendar, CancellationToken cancellationToken)
            => await ValidConflict(calendar, _scheduleCalendarRepository);

        public static async Task<bool> ValidConflict(MedicalCalendar calendar, IScheduleCalendarRepository scheduleCalendarRepository)
        {
            return await ScheduleCalendarConflictValidator.HasNoConflictAsync(
                new ScheduleCalendarConflictRequest
                {
                    TenantKey = MedicalScheduleKeyHelper.TenantKey,
                    OwnerKey = MedicalScheduleKeyHelper.ForMedical(calendar.MedicalId),
                    StartDateTime = calendar.StartDateTime,
                    EndDateTime = calendar.EndDateTime,
                    ExcludeToken = calendar.TokenRecurrence
                },
                scheduleCalendarRepository);
        }
    }
}
