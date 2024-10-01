using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface ISharedServices
    { 
        
        ICacheService CacheService { get; }
        ICryptoService CryptoService { get; }    
    }
}