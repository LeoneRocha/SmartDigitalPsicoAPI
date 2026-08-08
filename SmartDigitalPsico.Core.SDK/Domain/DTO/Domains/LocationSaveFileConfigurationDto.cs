using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por LocationSaveFileConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class LocationSaveFileConfigurationDto : ILocationSaveFileConfigurationDto
    {
        public ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
    }
}
