namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ETypeDataBase.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum ETypeDataBase
    {
        MSsqlServer = 0,
        Mysql= 1,
        Postgree = 3,
        FireBase = 4,
    }
}
