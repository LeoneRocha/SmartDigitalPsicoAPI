using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;
using SmartDigitalPsico.Domain.DTO.Domains;
using System.Text;
using System.Text.Json;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    public class DiskCacheRepository : IDiskCacheRepository
    {
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly CacheConfigurationDto _cacheConfig;

        public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationDto> cacheConfig)
        {
            _repositoryFileDisk = repositoryFileDisk;
            _cacheConfig = cacheConfig.Value;

        } 

        public async Task<bool> SetAsync<T>(string cacheKey, T value)
        {
            bool result;

            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename, CreatedDate = DataHelper.GetDateTimeNowFromUtc() };

            bool exists = _repositoryFileDisk.Exists(criteriaFind);

            if (exists)
            {
                await _repositoryFileDisk.Delete(criteriaFind);
            }

            //Gerando cache 
            string jsonString = JsonSerializer.Serialize(value);
            byte[] bytesString = Encoding.UTF8.GetBytes(jsonString);

            string pathSaveCache = DirectoryHelper.GetPathSaveCache(_cacheConfig.PathCache);

            var fileDataSave = new FileData()
            {
                FilePath = pathSaveCache,
                FileName = filename,
                FolderDestination = pathSaveCache,
                FileData = bytesString,
                CreatedDate = DataHelper.GetDateTimeNowFromUtc()
            };

            result = await _repositoryFileDisk.Save(fileDataSave);

            return result;
        }

        public async Task<KeyValuePair<bool, T>> TryGetAsync<T>(string cacheKey) where T : new()
        {
            bool result = false;
            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            string pathSaveCache = DirectoryHelper.GetPathSaveCache(_cacheConfig.PathCache);

            var criteriaFind = new FileData() { FilePath = pathSaveCache, FileName = filename, CreatedDate = DataHelper.GetDateTimeNowFromUtc() };

            bool exists = _repositoryFileDisk.Exists(criteriaFind);

            if (exists)
            {
                byte[]? fileCacheByte = await _repositoryFileDisk.Get(criteriaFind);

                if (fileCacheByte != null)
                {
                    // Ler bytes e transformar em String json
                    string contentString = Encoding.UTF8.GetString(fileCacheByte, 0, fileCacheByte.Length);

                    T? resultCache = JsonSerializer.Deserialize<T>(contentString);
                    if (!EqualityComparer<T>.Default.Equals(resultCache, default))
                    {
                        result = true;
                        return new KeyValuePair<bool, T>(result, resultCache ?? new());
                    }
                }
            }
            return new KeyValuePair<bool, T>(result, new());
        }

        public async Task<bool> RemoveAsync(string cacheKey)
        {
            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename, CreatedDate = DataHelper.GetDateTimeNowFromUtc() };

            await _repositoryFileDisk.Delete(criteriaFind);

            return true;
        }
    }
}