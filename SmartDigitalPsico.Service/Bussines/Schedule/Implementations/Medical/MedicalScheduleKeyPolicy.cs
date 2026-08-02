using SmartDigitalPsico.Domain.Helpers.Medical;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Implementations.Medical
{
    /// <summary>
    /// Medical implementation of schedule key/tenant policy for Core engines and validators.
    /// </summary>
    public sealed class MedicalScheduleKeyPolicy : IScheduleKeyPolicy
    {
        public string TenantKey => MedicalScheduleKeyHelper.TenantKey;

        public string BuildOwnerKey(long ownerId) => MedicalScheduleKeyHelper.ForMedical(ownerId);

        public string BuildSubjectKey(long subjectId) => MedicalScheduleKeyHelper.ForPatient(subjectId);

        public bool TryParseOwnerId(string? ownerKey, out long ownerId)
            => MedicalScheduleKeyHelper.TryParseMedicalId(ownerKey, out ownerId);

        public bool TryParseSubjectId(string? subjectKey, out long subjectId)
            => MedicalScheduleKeyHelper.TryParsePatientId(subjectKey, out subjectId);
    }
}
