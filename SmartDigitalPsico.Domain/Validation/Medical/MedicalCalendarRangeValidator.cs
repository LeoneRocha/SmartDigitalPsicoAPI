using FluentValidation;
using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation
{
    /// <summary>
    /// Range/conflict validator against ScheduleCalendar SoT.
    /// Not intended as the primary <c>IValidator&lt;MedicalCalendar&gt;</c> (see MedicalCalendarValidator).
    /// </summary>
    public class MedicalCalendarRangeValidator : AbstractValidator<MedicalCalendar>
    {
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;

        /// <summary>
        /// Método MedicalCalendarRangeValidator: executa a operação MedicalCalendarRangeValidator.
        /// </summary>
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

        /// <summary>
        /// Método ValidConflict: executa a operação ValidConflict.
        /// </summary>
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
