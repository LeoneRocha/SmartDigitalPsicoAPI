using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;
using SmartDigitalPsico.Domain.Validation.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Principals.Calendar
{
    /// <summary>
    /// Medical/Patient-specific rules + working hours/days + future dates.
    /// Generic schedule fields via <see cref="MedicalCalendarScheduleFieldsValidator"/>;
    /// conflict via <see cref="ScheduleCalendarConflictValidator"/>.
    /// </summary>
    public class MedicalCalendarValidator : MedicalBaseValidator<MedicalCalendar>
    {
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;
        private readonly IMedicalRepository _repositoryMedical;

#pragma warning disable CS0618
        public MedicalCalendarValidator(
            IConfiguration configuration,
            IMedicalCalendarRepository entityRepository,
            IMedicalRepository medicalRepository,
            IUserRepository userRepository,
            IScheduleCalendarRepository scheduleCalendarRepository)
            : base(medicalRepository, entityRepository, userRepository)
#pragma warning restore CS0618
        {
            _scheduleCalendarRepository = scheduleCalendarRepository;
            _repositoryMedical = medicalRepository;

            Include(new MedicalCalendarScheduleFieldsValidator());

            // Host: future dates
            RuleFor(e => e.StartDateTime)
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), startDateTime))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.StartDateTime.Must")
                .WithMessage("StartDateTime_Validator_Future_Key|Start date and time must be in the future.");

            RuleFor(e => e.EndDateTime)
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), endDateTime))
                .When(e => e.EndDateTime.HasValue)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.EndDateTime.Must")
                .WithMessage("EndDateTime_Validator_Future_Key|End date and time must be in the future.");

            // Medical-specific: working days/hours
            RuleFor(e => e.StartDateTime)
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, startDateTime))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.StartDateTime.Must")
                .WithMessage("StartDateTime_Validator_WorkingDay_Key|Start date and time must be on a working day for the doctor.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, startDateTime))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.StartDateTime.Must")
                .WithMessage("StartDateTime_Validator_WorkingHours_Key|Start time must be within the doctor's working hours.");

            RuleFor(e => e.EndDateTime)
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.EndDateTime.Must")
                .WithMessage("EndDateTime_Validator_WorkingDay_Key|End date and time must be on a working day for the doctor.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.EndDateTime.Must")
                .WithMessage("EndDateTime_Validator_WorkingHours_Key|End time must be within the doctor's working hours.");

            RuleFor(e => e.RecurrenceDays)
                .MustAsync(async (e, recurrenceDays, cancellationToken) => await BeInWorkingDays(e.MedicalId, recurrenceDays))
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.RecurrenceDays.Must")
                .WithMessage("RecurrenceDays_Validator_WorkingDay_Key|Recurrence days must be on working days for the doctor.");

            #region Relationship Medical / Patient

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.PatientId.NotNull")
                .WithMessage("ErrorValidator_PatientId_Null|Patient is required.");

            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.MedicalId.NotNull")
                .WithMessage("ErrorValidator_MedicalId_Null|Doctor is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.MedicalId.Must")
                .WithMessage("ErrorValidator_MedicalId_NotFound|Doctor not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.MedicalId.Must")
                .WithMessage("ErrorValidator_Medical_Changed|Doctor has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.MedicalId.Must")
                .WithMessage("ErrorValidator_MedicalCreated_Invalid|Doctor creation is invalid.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.MedicalId.Must")
                .WithMessage("ErrorValidator_MedicalModify_Invalid|Doctor modification is invalid.");

            #endregion Relationship Medical / Patient

            RuleFor(x => x)
                .MustAsync(NoScheduleConflict)
                .WithErrorCode("SmartDigitalPsico.MedicalCalendarValidator.MedicalCalendar.Entity.Must")
                .WithMessage("ScheduleConflict_Validator_Key|There is a scheduling conflict for the specified time.");
        }

        private async Task<bool> BeFutureDateTime(long userId, DateTime dateTime)
        {
            var user = await _userRepository.FindByID(userId);
            var dateCurrent = DateHelper.ApplyTimeZone(DateTime.UtcNow, user.TimeZone);
            return dateTime > dateCurrent;
        }

        private async Task<bool> BeFutureDateTime(long userId, DateTime? dateTime)
        {
            var user = await _userRepository.FindByID(userId);
            var dateCurrent = DateHelper.ApplyTimeZone(DateTime.UtcNow, user.TimeZone);
            return dateTime.HasValue && dateTime.Value > dateCurrent;
        }

        private async Task<bool> BeInWorkingDays(long medicalId, DateTime dateTime)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            return medical.WorkingDays.Contains(dateTime.DayOfWeek);
        }

        private async Task<bool> BeInWorkingDays(long medicalId, DayOfWeek[] recurrenceDays)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            return recurrenceDays.All(day => medical.WorkingDays.Contains(day));
        }

        private async Task<bool> BeInWorkingHours(long medicalId, DateTime dateTime)
        {
            var medical = await _repositoryMedical.FindByID(medicalId);
            var timeOfDay = dateTime.TimeOfDay;
            return timeOfDay >= medical.StartWorkingTime && timeOfDay <= medical.EndWorkingTime;
        }

        private async Task<bool> NoScheduleConflict(MedicalCalendar calendar, CancellationToken cancellationToken)
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
                _scheduleCalendarRepository);
        }
    }
}
