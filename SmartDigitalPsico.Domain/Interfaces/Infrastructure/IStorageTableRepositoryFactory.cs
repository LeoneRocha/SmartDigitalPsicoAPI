using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageTableRepositoryFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IStorageTableRepositoryFactory
    {
        IStorageTableContract<T> Create<T>(SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EStorageAdapterType eStorageAdapterType, string tableName) where T : BaseEntityTable, new();
    }
}
