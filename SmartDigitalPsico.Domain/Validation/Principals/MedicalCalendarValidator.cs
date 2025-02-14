using DocumentFormat.OpenXml.Spreadsheet;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Base;

namespace SmartDigitalPsico.Domain.Validation.SystemDomains
{
    public class MedicalCalendarValidator : MedicalBaseValidator<MedicalCalendar>
    {
        private readonly IMedicalCalendarRepository _repository;
        private readonly IMedicalRepository _repositoryMedical;

        public MedicalCalendarValidator(IConfiguration configuration, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IUserRepository userRepository) : base(medicalRepository, entityRepository, userRepository)
        {
            _repository = entityRepository;
            _repositoryMedical = medicalRepository;

            #region Columns
            RuleFor(e => e.Title)
                .NotEmpty()
                .WithMessage("Title_Validator_IsRequired_Key|Title is required.")
                .MaximumLength(100)
                .WithMessage("Title_Validator_MaxLength_Key|Title cannot exceed {0} characters.|100");

            RuleFor(e => e.StartDateTime)
                .NotEmpty()
                .WithMessage("StartDateTime_Validator_IsRequired_Key|Start date and time is required.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), startDateTime))
                .WithMessage("StartDateTime_Validator_Future_Key|Start date and time must be in the future.")
                .LessThan(e => e.EndDateTime)
                .When(e => e.EndDateTime.HasValue && !e.IsAllDay)
                .WithMessage("StartDateTime_Validator_BeforeEnd_Key|Start time must be before end time.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, startDateTime))
                .WithMessage("StartDateTime_Validator_WorkingDay_Key|Start date and time must be on a working day for the doctor.")
                .MustAsync(async (e, startDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, startDateTime))
                .WithMessage("StartDateTime_Validator_WorkingHours_Key|Start time must be within the doctor's working hours.");

            RuleFor(e => e.EndDateTime)
                .NotEmpty()
                .WithMessage("EndDateTime_Validator_IsRequired_Key|End date and time is required.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeFutureDateTime(e.CreatedUserId.GetValueOrDefault(), endDateTime))
                .When(e => e.EndDateTime.HasValue)
                .WithMessage("EndDateTime_Validator_Future_Key|End date and time must be in the future.")
                .GreaterThan(e => e.StartDateTime)
                .WithMessage("EndDateTime_Validator_AfterStart_Key|End date and time must be after start date and time.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingDays(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithMessage("EndDateTime_Validator_WorkingDay_Key|End date and time must be on a working day for the doctor.")
                .MustAsync(async (e, endDateTime, cancellationToken) => await BeInWorkingHours(e.MedicalId, endDateTime.GetValueOrDefault()))
                .WithMessage("EndDateTime_Validator_WorkingHours_Key|End time must be within the doctor's working hours.");

            RuleFor(e => e.Status)
                .IsInEnum()
                .WithMessage("Status_Validator_Invalid_Key|Invalid status.");

            RuleFor(e => e.ColorCategoryHexa)
                .MaximumLength(50)
                .WithMessage("ColorCategoryHexa_Validator_MaxLength_Key|Color category cannot exceed {0} characters.|50");

            RuleFor(e => e.TokenRecurrence)
                .MaximumLength(40)
                .WithMessage("TokenRecurrence_Validator_MaxLength_Key|Token recurrence cannot exceed {0} characters.|40");

            RuleFor(e => e.TimeZone)
                .NotEmpty()
                .WithMessage("TimeZone_Validator_IsRequired_Key|Time zone is required.")
                .MaximumLength(150)
                .WithMessage("TimeZone_Validator_MaxLength_Key|Time zone cannot exceed {0} characters.|150");

            RuleFor(e => e.RecurrenceDays)
                .Must(BeValidDays)
                .When(e => e.RecurrenceDays != null && e.RecurrenceDays.Length > 0)
                .WithMessage("RecurrenceDays_Validator_Invalid_Key|Invalid recurrence days.")
                .MustAsync(async (e, recurrenceDays, cancellationToken) => await BeInWorkingDays(e.MedicalId, recurrenceDays))
                .WithMessage("RecurrenceDays_Validator_WorkingDay_Key|Recurrence days must be on working days for the doctor.");

            RuleFor(e => e.RecurrenceType)
                .IsInEnum()
                .WithMessage("RecurrenceType_Validator_Invalid_Key|Invalid recurrence type.");

            // Validação para RecurrenceCount
            RuleFor(e => e.RecurrenceCount)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("RecurrenceCount_Validator_IsRequired_Key|Recurrence count is required.")
                .InclusiveBetween((short)0, (short)999)
                .WithMessage("RecurrenceCount_Validator_Range_Key|Recurrence count must be between {0} and {1}.|0|999");

            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.PatientId)
                .NotNull()
                .WithMessage("ErrorValidator_PatientId_Null|Patient is required.");

            RuleFor(entity => entity.MedicalId)
                .NotNull()
                .WithMessage("ErrorValidator_MedicalId_Null|Doctor is required.")
                .MustAsync(async (entity, value, c) => await MedicalIdFound(entity))
                .WithMessage("ErrorValidator_MedicalId_NotFound|Doctor not found.")
                .MustAsync(async (entity, value, c) => await MedicalIdChanged(entity))
                .WithMessage("ErrorValidator_Medical_Changed|Doctor has changed.")
                .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value, entity.CreatedUserId))
                .WithMessage("ErrorValidator_MedicalCreated_Invalid|Doctor creation is invalid.")
                .MustAsync(async (entity, value, c) => await MedicalModify(entity, value, entity.ModifyUserId))
                .WithMessage("ErrorValidator_MedicalModify_Invalid|Doctor modification is invalid.");

            #endregion Relationship

            RuleFor(x => x)
                .MustAsync(NoScheduleConflict)
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

        private static bool BeValidDays(DayOfWeek[] recurrenceDays)
        {
            return recurrenceDays.ToList().TrueForAll(day => Enum.IsDefined(typeof(DayOfWeek), day));
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
            return await MedicalCalendarRangeValidator.ValidConflict(calendar, _repository);
        }
    }
}
