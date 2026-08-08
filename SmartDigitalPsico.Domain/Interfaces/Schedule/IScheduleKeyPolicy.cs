namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Adapter-supplied schedule key policy. Core engines receive only opaque TenantKey/OwnerKey/SubjectKey.
    /// </summary>
    public interface IScheduleKeyPolicy
    {
        string TenantKey { get; }
        /// <summary>
        /// Método BuildOwnerKey: mapeia, transforma ou agenda dados.
        /// </summary>
        string BuildOwnerKey(long ownerId);
        /// <summary>
        /// Método BuildSubjectKey: mapeia, transforma ou agenda dados.
        /// </summary>
        string BuildSubjectKey(long subjectId);
        /// <summary>
        /// Método TryParseOwnerId: executa a operação TryParseOwnerId.
        /// </summary>
        bool TryParseOwnerId(string? ownerKey, out long ownerId);
        /// <summary>
        /// Método TryParseSubjectId: executa a operação TryParseSubjectId.
        /// </summary>
        bool TryParseSubjectId(string? subjectKey, out long subjectId);
    }
}
