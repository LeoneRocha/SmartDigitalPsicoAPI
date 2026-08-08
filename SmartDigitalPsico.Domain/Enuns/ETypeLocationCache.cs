using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
