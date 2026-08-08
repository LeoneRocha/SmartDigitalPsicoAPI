using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Contracts
{
    /// <summary>
    /// Classe responsável por EntityDtoBaseDomainAdd.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public abstract class EntityDtoBaseDomainAdd : IEntityDtoAdd
    { 
        public string Description { get; set; } = string.Empty;  
        public string Language { get; set; } = "en";
    }
}
