using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;


namespace SmartDigitalPsico.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por LocationSaveFileConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class LocationSaveFileConfigurationDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto, ILocationSaveFileConfigurationDto
    {
    }
}
