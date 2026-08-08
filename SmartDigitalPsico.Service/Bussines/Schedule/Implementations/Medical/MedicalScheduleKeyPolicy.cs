using SmartDigitalPsico.Domain.Helpers.Medical;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
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
