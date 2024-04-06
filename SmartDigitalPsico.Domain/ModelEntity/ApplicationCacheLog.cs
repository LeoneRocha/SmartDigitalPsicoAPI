using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class ApplicationCacheLog : EntityBase
    { 
        public DateTime DateTimeSlidingExpiration { get; set; }         
        public string CacheId { get; set; } = string.Empty;          
        public string CacheKey { get; set; } = string.Empty;
    }
}