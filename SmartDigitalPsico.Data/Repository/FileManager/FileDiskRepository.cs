using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Data.Repository.FileManager
{
    public class FileDiskRepository : IFileDiskRepository
    {
        public FileDiskRepository()
        {

        }
        public async Task<bool> Save(FileData item)
        {
            bool result = false;

            if (item.FileData != null)
            {
                result = await saveFileFromByte(item);
            }
            return result;
        }

        private static async Task<bool> saveFileFromByte(FileData item)
        {
            // Create random data to write to the file.
            byte[] dataArray = item.FileData;

            string folder = string.Format(@"{0}", item.FolderDestination);
            string arquivo = Path.Combine(folder, item.FileName);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }
            using (FileStream fileStream = new FileStream(string.Format(@"{0}\{1}", item.FolderDestination, item.FileName), FileMode.Create))
            {
                // Write the data to the file, byte by byte.

                await fileStream.WriteAsync(dataArray.AsMemory());


                // Set the stream position to the beginning of the file.
                fileStream.Seek(0, SeekOrigin.Begin);

                // Read and verify the data.
                for (int i = 0; i < fileStream.Length; i++)
                {
                    if (dataArray[i] != fileStream.ReadByte())
                    {
                        throw new InvalidOperationException("Error writing data.");
                    }
                }
            }
            return true;
        }

        public async Task<byte[]?> Get(FileData fileCriteria)
        {
            byte[]? result = null;
            string pathFile = String.IsNullOrEmpty(fileCriteria.FilePath) ? string.Empty : fileCriteria.FilePath;

            string fileInfo = Path.Combine(pathFile, fileCriteria.FileName);

            if (File.Exists(fileInfo))
            {
                using (FileStream SourceStream = File.Open(fileInfo, FileMode.Open))
                {
                    result = new byte[SourceStream.Length];
                    await SourceStream.ReadAsync(result.AsMemory());
                }
            }
            return result;
        }

        public async Task Delete(FileData fileCriteria)
        {
            string pathFile = String.IsNullOrEmpty(fileCriteria.FilePath) ? string.Empty : fileCriteria.FilePath;
            string fileInfo = Path.Combine(pathFile, fileCriteria.FileName);

            bool result = false;
            if (Directory.Exists(pathFile))
            {
                result = File.Exists(fileInfo);
                if (result)
                {
                    await File.AppendAllTextAsync(fileInfo, "");
                    File.Delete(fileInfo);
                }
            }
        }

        public bool Exists(FileData fileCriteria)
        {
            string pathFile = String.IsNullOrEmpty(fileCriteria.FilePath) ? string.Empty : fileCriteria.FilePath;
            string fileInfo = Path.Combine(pathFile, fileCriteria.FileName);

            bool result = false;
            if (Directory.Exists(pathFile))
            {
                result = File.Exists(fileInfo);
            }

            return result;
        }
    }
}
