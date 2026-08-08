using Microsoft.Extensions.Options;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.ModelEntity.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Domains;
using System.Text;
using System.Text.Json;

namespace SmartDigitalPsicoAPI.Core.SDK.Data.Repository.CacheManager
{
    /// <summary>
    /// Classe responsável por DiskCacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class DiskCacheRepository : IDiskCacheRepository
    {
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly CacheConfigurationDto _cacheConfig;

        /// <summary>
        /// Método DiskCacheRepository: executa a operação DiskCacheRepository.
        /// </summary>
        public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationDto> cacheConfig)
        {
            _repositoryFileDisk = repositoryFileDisk;
            _cacheConfig = cacheConfig.Value;

        } 

        public async Task<bool> SetAsync<T>(string cacheKey, T value)
        {
            bool result;

            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename, CreatedDate = DateHelper.GetDateTimeNowFromUtc() };

            bool exists = _repositoryFileDisk.Exists(criteriaFind);

            if (exists)
            {
                await _repositoryFileDisk.Delete(criteriaFind);
            }

            //Gerando cache 
            string jsonString = JsonSerializer.Serialize(value);
            byte[] bytesString = Encoding.UTF8.GetBytes(jsonString);

            string pathSaveCache = GetPathSaveCache(_cacheConfig.PathCache);

            var fileDataSave = new FileData()
            {
                FilePath = pathSaveCache,
                FileName = filename,
                FolderDestination = pathSaveCache,
                FileData = bytesString,
                CreatedDate = DateHelper.GetDateTimeNowFromUtc()
            };

            result = await _repositoryFileDisk.Save(fileDataSave);

            return result;
        }

        public async Task<KeyValuePair<bool, T>> TryGetAsync<T>(string cacheKey) where T : new()
        {
            bool result = false;
            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            string pathSaveCache = GetPathSaveCache(_cacheConfig.PathCache);

            var criteriaFind = new FileData() { FilePath = pathSaveCache, FileName = filename, CreatedDate = DateHelper.GetDateTimeNowFromUtc() };

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
                        return new KeyValuePair<bool, T>(result, resultCache!);
                    }
                }
            }
            return new KeyValuePair<bool, T>(result, new());
        }

        /// <summary>
        /// Método RemoveAsync: remove ou cancela um registro/recurso.
        /// </summary>
        public async Task<bool> RemoveAsync(string cacheKey)
        {
            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

            var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename, CreatedDate = DateHelper.GetDateTimeNowFromUtc() };

            await _repositoryFileDisk.Delete(criteriaFind);

            return true;
        }

        private string GetPathSaveCache(string pathCache)
        {
            string pathToSaveCache;
            if (Path.IsPathFullyQualified(pathCache))
            {
                pathToSaveCache = pathCache;
            }
            else
            {
                pathCache = pathCache.Replace(".", "");
                string currentDir = Directory.GetCurrentDirectory();
                string[] dirs = pathCache.Split('/');
                pathToSaveCache = Path.Combine(currentDir, dirs[0]);
                for (int i = 1; i < dirs.Length; i++)
                {
                    pathToSaveCache = Path.Combine(pathToSaveCache, dirs[i]);
                }
            }
            if (!Directory.Exists(pathToSaveCache))
            {
                Directory.CreateDirectory(pathToSaveCache);
            }
            return pathToSaveCache;
        }
    }
}
