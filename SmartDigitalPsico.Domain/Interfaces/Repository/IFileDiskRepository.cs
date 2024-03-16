using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IFileDiskRepository
    {
        Task<bool> Save(FileData item);

        Task<byte[]?> Get(FileData fileCriteria);
        Task Delete(FileData fileCriteria);

        bool Exists(FileData fileCriteria);
    }
}

