using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;



namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSetting.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ApplicationConfigSetting : EntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        public string Description { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string EndPointUrl_StorageFiles { get; set; } = string.Empty;
        public string EndPointUrl_Cache { get; set; } = string.Empty;
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles TypeLocationSaveFiles { get; set; }
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeLocationCache TypeLocationCache { get; set; }
        public ETypeLocationQueeMessaging TypeLocationQueeMessaging { get; set; }

        public string UrlRootManager { get; set; } = string.Empty;
    }
}
