using SmartDigitalPsico.Domain.Helpers.Medical;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
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
    /// Medical implementation of schedule key/tenant policy for Core engines and validators.
    /// </summary>
    public sealed class MedicalScheduleKeyPolicy : IScheduleKeyPolicy
    {
        public string TenantKey => MedicalScheduleKeyHelper.TenantKey;

        /// <summary>
        /// Método BuildOwnerKey: mapeia ou transforma dados entre modelos.
        /// </summary>
        public string BuildOwnerKey(long ownerId) => MedicalScheduleKeyHelper.ForMedical(ownerId);

        /// <summary>
        /// Método BuildSubjectKey: mapeia ou transforma dados entre modelos.
        /// </summary>
        public string BuildSubjectKey(long subjectId) => MedicalScheduleKeyHelper.ForPatient(subjectId);

        /// <summary>
        /// Método TryParseOwnerId: executa a operação TryParseOwnerId.
        /// </summary>
        public bool TryParseOwnerId(string? ownerKey, out long ownerId)
            => MedicalScheduleKeyHelper.TryParseMedicalId(ownerKey, out ownerId);

        /// <summary>
        /// Método TryParseSubjectId: executa a operação TryParseSubjectId.
        /// </summary>
        public bool TryParseSubjectId(string? subjectKey, out long subjectId)
            => MedicalScheduleKeyHelper.TryParsePatientId(subjectKey, out subjectId);
    }
}
