using FluentValidation;
using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Calendar
{
    /// <summary>
    /// Range/conflict validator. DI uses ScheduleCalendar SoT.
    /// Historical MedicalCalendarService uses <see cref="ForObsoleteMedicalCalendarRepository"/>.
    /// Not intended as the primary <c>IValidator&lt;MedicalCalendar&gt;</c> (see MedicalCalendarValidator).
    /// </summary>
    public class MedicalCalendarRangeValidator : AbstractValidator<MedicalCalendar>
    {
        private readonly IScheduleCalendarRepository? _scheduleCalendarRepository;
#pragma warning disable CS0618
        private readonly IMedicalCalendarRepository? _medicalCalendarRepository;
#pragma warning restore CS0618
        private readonly bool _useScheduleSoT;

        /// <summary>DI / ScheduleCalendar actions — conflict against ScheduleCalendar SoT.</summary>
        public MedicalCalendarRangeValidator(IScheduleCalendarRepository scheduleCalendarRepository)
        {
            _scheduleCalendarRepository = scheduleCalendarRepository;
            _useScheduleSoT = true;
            ConfigureRules();
        }

#pragma warning disable CS0618
        /// <summary>Historical path for obsolete MedicalCalendarService (manual new, not DI).</summary>
        public static MedicalCalendarRangeValidator ForObsoleteMedicalCalendarRepository(
            IMedicalCalendarRepository medicalCalendarRepository)
            => new MedicalCalendarRangeValidator(medicalCalendarRepository);
#pragma warning restore CS0618

#pragma warning disable CS0618
        private MedicalCalendarRangeValidator(IMedicalCalendarRepository medicalCalendarRepository)
        {
            _medicalCalendarRepository = medicalCalendarRepository;
            _useScheduleSoT = false;
            ConfigureRules();
        }
#pragma warning restore CS0618

        private void ConfigureRules()
        {
            RuleFor(m => m)
                .MustAsync(_useScheduleSoT ? NoDateConflictSchedule : NoDateConflictMedical)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarRangeValidator.MedicalCalendar.Entity.Must")
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same doctor.");
        }

        private async Task<bool> NoDateConflictSchedule(MedicalCalendar calendar, CancellationToken cancellationToken)
            => await ValidConflict(calendar, _scheduleCalendarRepository!);

        private async Task<bool> NoDateConflictMedical(MedicalCalendar calendar, CancellationToken cancellationToken)
            => await ValidConflictLegacy(calendar, _medicalCalendarRepository!);

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

#pragma warning disable CS0618
        /// <summary>Legacy conflict against MedicalCalendar rows (historical service).</summary>
        public static async Task<bool> ValidConflictLegacy(MedicalCalendar calendar, IMedicalCalendarRepository entityRepository)
        {
            var existingCalendars = await entityRepository.GetMedicalCalendarsForMedicalAsync(
                 calendar.MedicalId, calendar.StartDateTime, calendar.EndDateTime.GetValueOrDefault());

            var existsDates = existingCalendars.ToList().Exists(c => c.Id != calendar.Id &&
                                               c.StartDateTime < calendar.EndDateTime &&
                                               c.EndDateTime > calendar.StartDateTime);
            return !existsDates;
        }
#pragma warning restore CS0618
    }
}
