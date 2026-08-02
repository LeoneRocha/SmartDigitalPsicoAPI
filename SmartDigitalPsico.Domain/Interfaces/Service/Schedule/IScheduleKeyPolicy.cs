namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Adapter-supplied schedule key policy. Core engines receive only opaque TenantKey/OwnerKey/SubjectKey.
    /// </summary>
    public interface IScheduleKeyPolicy
    {
        string TenantKey { get; }
        string BuildOwnerKey(long ownerId);
        string BuildSubjectKey(long subjectId);
        bool TryParseOwnerId(string? ownerKey, out long ownerId);
        bool TryParseSubjectId(string? subjectKey, out long subjectId);
    }
}
