using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class ApplicationLanguage : EntityBase, IEntityBaseDomains
    {          
        public string Language { get; set; } = string.Empty;         
        public string Description { get; set; } = string.Empty;         
        public string LanguageKey { get; set; } = string.Empty;         
        public string ResourceKey { get; set; } = "ApplicationLanguage";         
        public string LanguageValue { get; set; } = string.Empty;
    }
}