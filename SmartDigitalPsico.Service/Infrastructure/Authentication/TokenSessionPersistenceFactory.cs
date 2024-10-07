using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TokenSessionPersistenceFactory : ITokenSessionPersistenceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public TokenSessionPersistenceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ITokenSessionPersistenceAdapter Create(ETokenSessionPersistenceType tokenSessionPersistenceType)
        {
            switch (tokenSessionPersistenceType)
            {
                case ETokenSessionPersistenceType.DataBase:
                    var serviceRepo = _serviceProvider.GetService<IUserTokenSessionRepository>();
                    return new DatabaseTokenSessionAdapter(serviceRepo!); 
                case ETokenSessionPersistenceType.AzureStorageTable:
                    var mapper = _serviceProvider.GetService<IMapper>();

                    var serviceStorage = _serviceProvider.GetService<IStorageTableContract<UserTokenSessionTableEntity>>();
                    
                    return new TableStorageTokenSessionAdapter(mapper!, serviceStorage!);

                default:
                    throw new ArgumentException("Invalid adapter type");
            } 
        } 
    }
}
