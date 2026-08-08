using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;


namespace SmartDigitalPsico.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por LocationSaveFileConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class LocationSaveFileConfigurationDto : SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto, ILocationSaveFileConfigurationDto
    {
    }
}
