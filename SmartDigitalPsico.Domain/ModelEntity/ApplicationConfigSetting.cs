using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class ApplicationConfigSetting : EntityBase, IEntityBaseDomains
    {
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
        public ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
        public ETypeLocationCache TypeLocationCache { get; set; }
        public ETypeLocationQueeMessaging TypeLocationQueeMessaging { get; set; }

        public string UrlRootManager { get; set; } = string.Empty;
    }
}