using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Helpers.Medical;

namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Monta ErrorResponse detalhado para conflitos de agenda (paciente, data, horários).
    /// </summary>
    public static class ScheduleConflictDetailHelper
    {
        public const string ErrorCode = "ScheduleConflict";
        public const int MaxErrors = 20;

        /// <summary>
        /// Conflito entre dois itens (request vs existente, ou self-overlap da série).
        /// </summary>
        public static ErrorResponse Create(
            ScheduleCalendarItem requested,
            string? requestedSubjectKey,
            ScheduleCalendarItem conflicting,
            string? conflictingSubjectKey)
        {
            var reqEnd = requested.EndDateTime ?? requested.StartDateTime;
            var confEnd = conflicting.EndDateTime ?? conflicting.StartDateTime;
            var reqPatient = FormatPatientId(requestedSubjectKey ?? requested.SubjectKey);
            var confPatient = FormatPatientId(conflictingSubjectKey ?? conflicting.SubjectKey);

            var message =
                $"Conflict Date={requested.StartDateTime:yyyy-MM-dd}; " +
                $"RequestedPatientId={reqPatient}; RequestedTime={requested.StartDateTime:HH:mm}-{reqEnd:HH:mm}; " +
                $"ExistingPatientId={confPatient}; ExistingTime={conflicting.StartDateTime:HH:mm}-{confEnd:HH:mm}; " +
                $"ExistingDate={conflicting.StartDateTime:yyyy-MM-dd}; " +
                $"ExistingTitle={Truncate(conflicting.Title, 80)}";

            return new ErrorResponse
            {
                ErrorCode = ErrorCode,
                Name = "ScheduleConflict",
                Message = message,
                DefaultMessage = message,
                FullMessage = message
            };
        }

        private static string FormatPatientId(string? subjectKey)
        {
            if (MedicalScheduleKeyHelper.TryParsePatientId(subjectKey, out var patientId))
                return patientId.ToString();
            return string.IsNullOrWhiteSpace(subjectKey) ? "-" : subjectKey;
        }

        private static string Truncate(string? value, int max)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "-";
            return value.Length <= max ? value : value[..max] + "…";
        }
    }
}
