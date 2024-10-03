using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TokenSessionAdapterFactory : ITokenSessionAdapterFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public TokenSessionAdapterFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ITokenSessionAdapter Create(string adapterType)
        {
            throw new NotImplementedException();
        }

        //public ITokenSessionAdapter Create(string adapterType)
        //{
        //    return adapterType switch
        //    {
        //        //"Database" => _serviceProvider.GetService<UserTokenSessionRepository>()!,
        //        "TableStorage" => _serviceProvider.GetService<TableStorageTokenSessionAdapter>()!
        //        _ => throw new ArgumentException("Invalid adapter type")
        //    };
        //}
    }

}
