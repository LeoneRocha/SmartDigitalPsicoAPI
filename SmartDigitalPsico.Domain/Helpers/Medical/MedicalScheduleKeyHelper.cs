using SmartDigitalPsico.Domain.Helpers.Schedule;

namespace SmartDigitalPsico.Domain.Helpers.Medical
{
    /// <summary>
    /// Medical adapter key/tenant policy (not Core). Builds opaque keys for schedule engines.
    /// </summary>
    public static class MedicalScheduleKeyHelper
    {
        /// <summary>Tenant supplied by Medical implementation to Core engines.</summary>
        public const string TenantKey = "sdp";

        public const string MedicalIdPrefix = "MedicalId:";
        public const string PatientIdPrefix = "PatientId:";

        /// <summary>Legacy SoT rows written before prefix rename.</summary>
        private static readonly string[] MedicalIdPrefixes = [MedicalIdPrefix, "medical:"];
        private static readonly string[] PatientIdPrefixes = [PatientIdPrefix, "patient:"];

        /// <summary>
        /// Método ForMedical: executa a operação ForMedical.
        /// </summary>
        public static string ForMedical(long medicalId)
            => ScheduleKeyHelper.Build(MedicalIdPrefix, medicalId);

        /// <summary>
        /// Método ForPatient: executa a operação ForPatient.
        /// </summary>
        public static string ForPatient(long patientId)
            => ScheduleKeyHelper.Build(PatientIdPrefix, patientId);

        /// <summary>
        /// Método TryParseMedicalId: executa a operação TryParseMedicalId.
        /// </summary>
        public static bool TryParseMedicalId(string? ownerKey, out long medicalId)
            => ScheduleKeyHelper.TryParse(ownerKey, MedicalIdPrefixes, out medicalId);

        /// <summary>
        /// Método TryParsePatientId: executa a operação TryParsePatientId.
        /// </summary>
        public static bool TryParsePatientId(string? subjectKey, out long patientId)
            => ScheduleKeyHelper.TryParse(subjectKey, PatientIdPrefixes, out patientId);
    }
}
