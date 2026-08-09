using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSetting.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ApplicationConfigSetting : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
        public SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
        public SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache TypeLocationCache { get; set; }
        public ETypeLocationQueeMessaging TypeLocationQueeMessaging { get; set; }

        public string UrlRootManager { get; set; } = string.Empty;
    }
}
