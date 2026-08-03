namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ETokenSessionPersistenceType.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum ETokenSessionPersistenceType
    {
        DataBase = 0,
        AzureStorageTable = 1
    }
}
