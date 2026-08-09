using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por TokenSessionPersistenceFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class TokenSessionPersistenceFactory : ITokenSessionPersistenceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Método TokenSessionPersistenceFactory: mapeia ou transforma dados entre modelos.
        /// </summary>
        public TokenSessionPersistenceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public ITokenSessionPersistenceAdapter Create(ETokenSessionPersistenceType tokenSessionPersistenceType)
        {
            switch (tokenSessionPersistenceType)
            {
                case ETokenSessionPersistenceType.DataBase:
                    var serviceRepo = _serviceProvider.GetService<IUserTokenSessionRepository>();
                    return new DatabaseTokenSessionAdapter(serviceRepo!);
                case ETokenSessionPersistenceType.AzureStorageTable:
                    var mapper = _serviceProvider.GetService<IAppMapper>();

                    var serviceStorage = _serviceProvider.GetService<SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<UserTokenSessionTableEntity>>();

                    return new TableStorageTokenSessionAdapter(mapper!, serviceStorage!);

                default:
                    throw new ArgumentException("Invalid adapter type");
            }
        }
    }
}
