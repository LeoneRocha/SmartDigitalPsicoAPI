using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.VO.Domains
{
    public class LocationSaveFileConfigurationVO : ILocationSaveFileConfigurationVO
    {
        public ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
    }
}
