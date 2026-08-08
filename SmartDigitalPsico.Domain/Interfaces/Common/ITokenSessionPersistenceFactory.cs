using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por ITokenSessionPersistenceFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ITokenSessionPersistenceFactory
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        ITokenSessionPersistenceAdapter Create(ETokenSessionPersistenceType tokenSessionPersistenceType);
    }
}
