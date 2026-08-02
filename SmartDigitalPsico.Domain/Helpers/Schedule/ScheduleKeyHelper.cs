namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    public static class ScheduleKeyHelper
    {
        public const string DefaultTenant = "sdp";

        public static string ForMedical(long medicalId) => $"medical:{medicalId}";
        public static string ForPatient(long patientId) => $"patient:{patientId}";
        public static string ForTenant(string tenantKey) => string.IsNullOrWhiteSpace(tenantKey) ? DefaultTenant : tenantKey;

        public static bool TryParseMedicalId(string ownerKey, out long medicalId)
        {
            medicalId = 0;
            if (string.IsNullOrWhiteSpace(ownerKey) || !ownerKey.StartsWith("medical:", StringComparison.OrdinalIgnoreCase))
                return false;
            return long.TryParse(ownerKey.AsSpan("medical:".Length), out medicalId);
        }

        public static bool TryParsePatientId(string subjectKey, out long patientId)
        {
            patientId = 0;
            if (string.IsNullOrWhiteSpace(subjectKey) || !subjectKey.StartsWith("patient:", StringComparison.OrdinalIgnoreCase))
                return false;
            return long.TryParse(subjectKey.AsSpan("patient:".Length), out patientId);
        }
    }
}
