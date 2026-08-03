using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains
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
