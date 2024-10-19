using FluentValidation;
using SmartDigitalPsico.Domain.DTO.Medical.Calendar;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Validation.DTO
{
    public class ScheduleCriteriaDtoValidator : AbstractValidator<ScheduleCriteriaDto>
    {
        private readonly IMedicalCalendarRepository _medicalCalendarRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IMedicalRepository _medicalRepository;

        public ScheduleCriteriaDtoValidator(IMedicalCalendarRepository medicalCalendarRepository
            , IPatientRepository patientRepository
            , IMedicalRepository medicalRepository)
        {
            _medicalCalendarRepository = medicalCalendarRepository;
            _patientRepository = patientRepository;
            _medicalRepository = medicalRepository;

            RuleFor(x => x.MedicalId).GreaterThan(0);
            RuleFor(x => x.PatientId).GreaterThan(0);
            RuleFor(x => x.AppointmentDateTime).GreaterThanOrEqualTo(DataHelper.GetDateTimeNow());
            RuleFor(x => x.Reason).NotEmpty();
            RuleFor(x => x.TimeZone).NotEmpty();

            RuleFor(x => x).MustAsync(BeAValidPatientOfMedical)
                .WithMessage("The patient does not belong to the specified doctor.");

            RuleFor(x => x).MustAsync(HaveValidStatusForCancellation)
                .When(x => x.ScheduleType == EScheduleCalendarType.Cancellation)
                .WithMessage("The appointment cannot be canceled because its status does not allow it or it is too close to the appointment time.");

            RuleFor(x => x).MustAsync(BeWithinWorkingHours)
                .WithMessage("The appointment time is outside the doctor's working hours.");

            RuleFor(x => x).MustAsync(NotHaveSchedulingConflict)
                .When(x => x.ScheduleType == EScheduleCalendarType.Schedule)
                .WithMessage("The doctor already has an appointment at this time.");

            RuleFor(x => x)
            .MustAsync(BeAtLeast23HoursInAdvance)
            .When(x => x.ScheduleType == EScheduleCalendarType.Schedule)
            .WithMessage("The appointment must be scheduled at least 23 hours in advance.");
        }

        private async Task<bool> BeAValidPatientOfMedical(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var resultRule = (await _patientRepository.FindByCustomWhere(p => p.MedicalId == criteria.MedicalId && p.Id == criteria.PatientId)).Count > 0;
            return resultRule;
        }

        private async Task<bool> HaveValidStatusForCancellation(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var appointment = (await _medicalCalendarRepository.FindByCustomWhere(mc => mc.MedicalId == criteria.MedicalId && mc.PatientId == criteria.PatientId && mc.StartDateTime == criteria.AppointmentDateTime)).FirstOrDefault();

            if (appointment == null)
            {
                return false;
            }
            var currentTime = DataHelper.ApplyTimeZone(DateTime.UtcNow, appointment.TimeZone);
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
            var resultRule = (await _medicalCalendarRepository.FindByCustomWhere(mc => mc.MedicalId == criteria.MedicalId && mc.StartDateTime == criteria.AppointmentDateTime)).Count <= 0;
            return resultRule;
        }

        private static async Task<bool> BeAtLeast23HoursInAdvance(ScheduleCriteriaDto criteria, CancellationToken cancellationToken)
        {
            var currentTime = DataHelper.ApplyTimeZone(DataHelper.GetDateTimeNow(), criteria.TimeZone);
            var resultRule = await Task.FromResult((criteria.AppointmentDateTime - currentTime).TotalHours >= 23);
            return resultRule;
        }
    }
}