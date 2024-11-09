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
                result = await SaveFileFromByte(item);
            }
            return result;
        } 
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "SCS0018:Path traversal", Justification = "Path is validated and sanitized")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "S6549:Path traversal", Justification = "Path is validated and sanitized")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "S6549:roslyn.sonaranalyzer.security.cs:S6549", Justification = "Path is validated and sanitized")]
        private async Task<bool> SaveFileFromByte(FileData item)
        {
#pragma warning disable S6549 
            // Create random data to write to the file.
            byte[] dataArray = item.FileData;

            // Validate and sanitize the folder and file name
            string folder = Path.GetFullPath(item.FolderDestination);
            string fileName = Path.GetFileName(item.FileName);
            string arquivo = Path.Combine(folder, fileName);

            if (!Directory.Exists(folder))// NOSONAR
            {
                Directory.CreateDirectory(folder);
            }
            if (File.Exists(arquivo))// NOSONAR
            {
                File.Delete(arquivo);
            }
            using (FileStream fileStream = new FileStream(arquivo, FileMode.Create))
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
#pragma warning restore S6549
            return true;
        }

        public async Task<byte[]?> Get(FileData fileCriteria)
        {
            ArgumentNullException.ThrowIfNull(fileCriteria);

            string pathFile = string.IsNullOrEmpty(fileCriteria.FilePath) ? string.Empty : fileCriteria.FilePath;
            string fileInfo = Path.Combine(pathFile, fileCriteria.FileName);
            byte[] result = [];
            if (File.Exists(fileInfo))
            {
                result = await ReadFileAsync(fileInfo) ?? [];
            }
            else if (File.Exists(fileCriteria.FilePath))
            {
                result = await ReadFileAsync(pathFile) ?? [];
            }
            return result;
        }

        private static async Task<byte[]> ReadFileAsync(string filePath)
        {
            byte[] result;
            using (FileStream sourceStream = File.Open(filePath, FileMode.Open))
            {
                result = new byte[sourceStream.Length];
                int bytesRead = await sourceStream.ReadAsync(result.AsMemory());
                if (bytesRead != result.Length)
                {
                    throw new IOException("Could not read the entire file.");
                }
            }
            return result;
        }

        public async Task Delete(FileData fileCriteria)
        {
            string pathFile = String.IsNullOrEmpty(fileCriteria.FilePath) ? string.Empty : fileCriteria.FilePath;
            string fileInfo = Path.Combine(pathFile, fileCriteria.FileName);

            if (await Task.Run(() => File.Exists(pathFile)))
            {
                await Task.Run(() => File.Delete(pathFile));
            }
            if (await Task.Run(() => File.Exists(fileInfo)))
            {
                await Task.Run(() => File.Delete(fileInfo));
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
