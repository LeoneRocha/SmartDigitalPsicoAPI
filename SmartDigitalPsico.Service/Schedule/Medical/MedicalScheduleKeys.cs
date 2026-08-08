using SmartDigitalPsico.Domain.Helpers.Medical;

namespace SmartDigitalPsico.Service.Schedule.Medical
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Medical implementation façade for schedule keys/tenant — Core receives only opaque values.
    /// </summary>
    public static class MedicalScheduleKeys
    {
        public const string TenantKey = MedicalScheduleKeyHelper.TenantKey;
        public const string MedicalIdPrefix = MedicalScheduleKeyHelper.MedicalIdPrefix;
        public const string PatientIdPrefix = MedicalScheduleKeyHelper.PatientIdPrefix;

        /// <summary>
        /// Método ForMedical: executa a operação ForMedical.
        /// </summary>
        public static string ForMedical(long medicalId) => MedicalScheduleKeyHelper.ForMedical(medicalId);
        /// <summary>
        /// Método ForPatient: executa a operação ForPatient.
        /// </summary>
        public static string ForPatient(long patientId) => MedicalScheduleKeyHelper.ForPatient(patientId);
        /// <summary>
        /// Método TryParseMedicalId: executa a operação TryParseMedicalId.
        /// </summary>
        public static bool TryParseMedicalId(string? ownerKey, out long medicalId)
            => MedicalScheduleKeyHelper.TryParseMedicalId(ownerKey, out medicalId);
        /// <summary>
        /// Método TryParsePatientId: executa a operação TryParsePatientId.
        /// </summary>
        public static bool TryParsePatientId(string? subjectKey, out long patientId)
            => MedicalScheduleKeyHelper.TryParsePatientId(subjectKey, out patientId);
    }
}
