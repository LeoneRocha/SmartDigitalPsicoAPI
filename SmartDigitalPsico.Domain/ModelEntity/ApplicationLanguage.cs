using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;


namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por ApplicationLanguage.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ApplicationLanguage : EntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {          
        public string Language { get; set; } = string.Empty;         
        public string Description { get; set; } = string.Empty;         
        public string LanguageKey { get; set; } = string.Empty;         
        public string ResourceKey { get; set; } = "ApplicationLanguage";         
        public string LanguageValue { get; set; } = string.Empty;
    }
}
