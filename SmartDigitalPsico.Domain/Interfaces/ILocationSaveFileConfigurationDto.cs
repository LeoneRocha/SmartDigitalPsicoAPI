using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface ILocationSaveFileConfigurationDto
    {
        ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
    }
}