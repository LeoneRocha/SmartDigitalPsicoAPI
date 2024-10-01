using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedServices : ISharedServices
    {
        public ICacheService CacheService { get; }
        public ICryptoService CryptoService { get; }

        public SharedServices(
            ICacheService cacheService,
            ICryptoService cryptoService)
        {
            CacheService = cacheService;
            CryptoService = cryptoService;
        }
    }
}