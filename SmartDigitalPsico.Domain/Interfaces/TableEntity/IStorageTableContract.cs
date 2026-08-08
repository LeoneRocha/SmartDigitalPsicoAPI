using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageTableContract.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IStorageTableContract<T> where T : BaseEntityTable, new()
    {
        /// <summary>
        /// Método GetAllAsync: consulta e retorna dados.
        /// </summary>
        Task<IEnumerable<T>> GetAllAsync();
        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        Task<T> GetByIdAsync(string partitionKey, string rowKey);
        /// <summary>
        /// Método InsertAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task InsertAsync(T entity);
        /// <summary>
        /// Método UpdateAsync: atualiza um registro/recurso existente.
        /// </summary>
        Task UpdateAsync(T entity);
        /// <summary>
        /// Método DeleteAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task DeleteAsync(string partitionKey, string rowKey);
    }
} 
