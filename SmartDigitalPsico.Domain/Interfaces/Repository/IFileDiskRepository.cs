using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IFileDiskRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IFileDiskRepository
    {
        /// <summary>
        /// Método Save: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<bool> Save(FileData item);

        Task<byte[]?> Get(FileData fileCriteria);
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        Task Delete(FileData fileCriteria);

        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        bool Exists(FileData fileCriteria);
    }
}

