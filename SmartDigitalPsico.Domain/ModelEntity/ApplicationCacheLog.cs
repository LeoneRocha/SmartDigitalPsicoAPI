using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por ApplicationCacheLog.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ApplicationCacheLog : EntityBase
    { 
        public DateTime DateTimeSlidingExpiration { get; set; }         
        public string CacheId { get; set; } = string.Empty;          
        public string CacheKey { get; set; } = string.Empty;
    }
}
