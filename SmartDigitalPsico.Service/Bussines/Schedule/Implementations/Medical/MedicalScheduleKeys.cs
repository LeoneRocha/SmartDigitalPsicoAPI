using SmartDigitalPsico.Domain.Helpers.Medical;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Medical implementation façade for schedule keys/tenant — Core receives only opaque values.
    /// </summary>
    public static class MedicalScheduleKeys
    {
        public const string TenantKey = MedicalScheduleKeyHelper.TenantKey;
        public const string MedicalIdPrefix = MedicalScheduleKeyHelper.MedicalIdPrefix;
        public const string PatientIdPrefix = MedicalScheduleKeyHelper.PatientIdPrefix;

        public static string ForMedical(long medicalId) => MedicalScheduleKeyHelper.ForMedical(medicalId);
        public static string ForPatient(long patientId) => MedicalScheduleKeyHelper.ForPatient(patientId);
        public static bool TryParseMedicalId(string? ownerKey, out long medicalId)
            => MedicalScheduleKeyHelper.TryParseMedicalId(ownerKey, out medicalId);
        public static bool TryParsePatientId(string? subjectKey, out long patientId)
            => MedicalScheduleKeyHelper.TryParsePatientId(subjectKey, out patientId);
    }
}
