using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public class LocationSaveFileConfigurationDto : ILocationSaveFileConfigurationDto
    {
        public ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
    }
}
