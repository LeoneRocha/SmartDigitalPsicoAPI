namespace SmartDigitalPsico.Core.SDK.Domain.Enuns
{
    /// <summary>
    /// Destinos de persistência de auditoria.
    /// </summary>
    public enum EAuditServiceType
    {
        Database = 0,
        Log = 1,
        AzureTable = 2,
    }
}
