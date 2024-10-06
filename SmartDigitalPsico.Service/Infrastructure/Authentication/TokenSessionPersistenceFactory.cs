using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TokenSessionPersistenceFactory : ITokenSessionPersistenceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public TokenSessionPersistenceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ITokenSessionAdapter Create(ETokenSessionPersistenceType tokenSessionPersistenceType)
        {
            var serviceRepo = _serviceProvider.GetService<IUserTokenSessionRepository>();
            return new DatabaseTokenSessionAdapter(serviceRepo!);
        }
        //public ITokenSessionAdapter Create(string adapterType)
        //{
        //    return adapterType switch
        //    {
        //        //"Database" => !,
        //        "TableStorage" => _serviceProvider.GetService<TableStorageTokenSessionAdapter>()!
        //        _ => throw new ArgumentException("Invalid adapter type")
        //    };
        //}
    }
}
