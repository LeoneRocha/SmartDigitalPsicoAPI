namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por EAuditServiceType.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum EAuditServiceType
    {
        Database = 0,
        Log = 1,
        AzureTable = 2,
    }

}
