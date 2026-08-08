using SmartDigitalPsico.Core.SDK.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IFileDiskRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
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

