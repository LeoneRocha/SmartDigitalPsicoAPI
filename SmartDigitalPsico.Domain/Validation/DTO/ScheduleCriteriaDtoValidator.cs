using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;

namespace SmartDigitalPsico.Domain.Validation.DTO
{
    public class ScheduleCriteriaDtoValidator : AbstractValidator<ScheduleCriteriaDto>
    {
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IMedicalRepository _medicalRepository;

        public ScheduleCriteriaDtoValidator(IScheduleCalendarRepository scheduleCalendarRepository,
                                             IPatientRepository patientRepository,
                                             IMedicalRepository medicalRepository)
        {
            _scheduleCalendarRepository = scheduleCalendarRepository;
            _patientRepository = patientRepository;
            _medicalRepository = medicalRepository;

            RuleFor(x => x.MedicalId)
                .GreaterThan(0)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.MedicalId.GreaterThan")
                .WithMessage("MedicalId_Validator_GreaterThan_Key|Medical ID must be greater than {0}.|0");

            RuleFor(x => x.PatientId)
                .GreaterThan(0)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.PatientId.GreaterThan")
                .WithMessage("PatientId_Validator_GreaterThan_Key|Patient ID must be greater than {0}.|0");

            RuleFor(x => x.AppointmentDateTime)
                .GreaterThanOrEqualTo(DateHelper.GetDateTimeNowFromUtc())
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.AppointmentDateTime.GreaterThanOrEqualTo")
                .WithMessage("AppointmentDateTime_Validator_GreaterThanOrEqualTo_Key|Appointment date and time must be greater than or equal to the current time.");

            RuleFor(x => x.Reason)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Reason.NotEmpty")
                .WithMessage("Reason_Validator_NotEmpty_Key|Reason is required.");

            RuleFor(x => x.TimeZone)
                .NotEmpty()
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.TimeZone.NotEmpty")
                .WithMessage("TimeZone_Validator_NotEmpty_Key|Time zone is required.");

            RuleFor(x => x)
                .MustAsync(BeAValidPatientOfMedical)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Entity.Must")
                .WithMessage("Patient_Validator_BelongToDoctor_Key|The patient does not belong to the specified doctor.");

            RuleFor(x => x)
                .MustAsync(HaveValidStatusForCancellation)
                .When(x => x.ScheduleType == EScheduleCalendarType.Cancellation)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Entity.Must")
                .WithMessage("Appointment_Validator_CannotBeCancelled_Key|The appointment cannot be canceled because its status does not allow it or it is too close to the appointment time.");

            RuleFor(x => x)
                .MustAsync(BeWithinWorkingHours)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Entity.Must")
                .WithMessage("Appointment_Validator_OutsideWorkingHours_Key|The appointment time is outside the doctor's working hours.");

            RuleFor(x => x)
                .MustAsync(NotHaveSchedulingConflict)
                .When(x => x.ScheduleType == EScheduleCalendarType.Schedule)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Entity.Must")
                .WithMessage("Appointment_Validator_SchedulingConflict_Key|The doctor already has an appointment at this time.");

            RuleFor(x => x)
                .MustAsync(BeAtLeast23HoursInAdvance)
                .When(x => x.ScheduleType == EScheduleCalendarType.Schedule)
                .WithErrorCode("SmartDigitalPsico.ScheduleCriteriaDtoValidator.ScheduleCriteriaDto.Entity.Must")
                .WithMessage("Appointment_Validator_AtLeast23HoursInAdvance_Key|The appointment must be scheduled at least {0} hours in advance.|23");
        }

        private async Task<bool> BeAValidPatientOfMedical(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var resultRule = (await _patientRepository.FindByCustomWhere(p => p.MedicalId == criteria.MedicalId && p.Id == criteria.PatientId)).Count > 0;
            return resultRule;
        }

        private async Task<bool> HaveValidStatusForCancellation(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var ownerKey = ScheduleKeyHelper.ForMedical(criteria.MedicalId);
            var subjectKey = ScheduleKeyHelper.ForPatient(criteria.PatientId);
            var appointment = await _scheduleCalendarRepository.GetItemAsync(
                ScheduleKeyHelper.DefaultTenant, ownerKey, subjectKey, criteria.AppointmentDateTime);

            if (appointment == null)
            {
                return false;
            }
            var currentTime = DateHelper.ApplyTimeZone(DateTime.UtcNow, appointment.TimeZone);
            var timeUntilAppointment = appointment.StartDateTime - currentTime;
            var isWithinCancellationWindow = timeUntilAppointment.TotalHours >= 12;
            var resultRule = (appointment.Status == EStatusCalendar.Confirmed || appointment.Status == EStatusCalendar.PendingConfirmation) && isWithinCancellationWindow;

            return resultRule;
        }

        private async Task<bool> BeWithinWorkingHours(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var medical = (await _medicalRepository.FindByCustomWhere(m => m.Id == criteria.MedicalId)).FirstOrDefault();

            if (medical == null)
            {
                return false;
            }
            var appointmentDayOfWeek = criteria.AppointmentDateTime.DayOfWeek;

            if (!medical.WorkingDays.Contains(appointmentDayOfWeek))
            {
                return false;
            }
            var appointmentTime = criteria.AppointmentDateTime.TimeOfDay;
            var resultRule = appointmentTime >= medical.StartWorkingTime && appointmentTime <= medical.EndWorkingTime;
            return resultRule;
        }

        private async Task<bool> NotHaveSchedulingConflict(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var ownerKey = ScheduleKeyHelper.ForMedical(criteria.MedicalId);
            var hasConflict = await _scheduleCalendarRepository.HasConflictAsync(
                ScheduleKeyHelper.DefaultTenant, ownerKey, criteria.AppointmentDateTime);
            return !hasConflict;
        }

        private static async Task<bool> BeAtLeast23HoursInAdvance(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var currentTime = DateHelper.ApplyTimeZone(DateHelper.GetDateTimeNowFromUtc(), criteria.TimeZone);
            var resultRule = await Task.FromResult((criteria.AppointmentDateTime - currentTime).TotalHours >= 23);
            return resultRule;
        }
    }
}
