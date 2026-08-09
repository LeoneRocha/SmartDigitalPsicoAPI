using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por ApplicationLanguage.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ApplicationLanguage : EntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseDomains
    {
        public string Language { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string LanguageKey { get; set; } = string.Empty;
        public string ResourceKey { get; set; } = "ApplicationLanguage";
        public string LanguageValue { get; set; } = string.Empty;
    }
}
