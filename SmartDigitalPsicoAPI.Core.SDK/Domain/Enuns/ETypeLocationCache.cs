using System.ComponentModel;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ETypeLocationCache.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
    public enum ETypeLocationCache
    { 
        [Description("Local Salvamento em Disco HD/SSD")]
        Disk = 0,

        [Description("Local Salvamento em Memory")]
        Memory = 1,

        [Description("Local Salvamento em MongoDB")]
        MongoDB = 2,

        [Description("Local Salvamento em Azure Storage")]
        AzureStorage = 3,

        [Description("Local Salvamento em Azure Cosmo DB")]
        AzureCosmoDB = 4,

        [Description("Local Salvamento em Azure Redis")]
        AzureRedis = 5,
    }
}
