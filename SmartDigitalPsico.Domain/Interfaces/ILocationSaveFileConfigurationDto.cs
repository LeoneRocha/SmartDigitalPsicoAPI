using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por ILocationSaveFileConfigurationDto.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ILocationSaveFileConfigurationDto
    {
        ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
    }
}
