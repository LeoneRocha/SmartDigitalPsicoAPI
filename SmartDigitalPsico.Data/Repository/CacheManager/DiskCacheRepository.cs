﻿using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains;
using System.Text;
using System.Text.Json;

namespace SmartDigitalPsico.Data.Repository.CacheManager
{
    public class DiskCacheRepository : IDiskCacheRepository
    {
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly CacheConfigurationVO _cacheConfig;

        public DiskCacheRepository(IFileDiskRepository repositoryFileDisk, IOptions<CacheConfigurationVO> cacheConfig)
        {
            _repositoryFileDisk = repositoryFileDisk;
            _cacheConfig = cacheConfig.Value;

        }

        public bool Remove(string cacheKey)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveAsync(string cacheKey)
        {
            bool result = false;
            try
            {
                string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

                var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename };

                await _repositoryFileDisk.Delete(criteriaFind);

                result = true;
            }
            catch (Exception)
            {

            }

            return result;
        }

        public bool Set<T>(string cacheKey, T value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetAsync<T>(string cacheKey, T value)
        {
            bool result = false;
            try
            {
                string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);

                var criteriaFind = new FileData() { FilePath = _cacheConfig.PathCache, FileName = filename };

                bool exists = _repositoryFileDisk.Exists(criteriaFind);

                if (exists)
                {
                    await _repositoryFileDisk.Delete(criteriaFind);
                }

                //Gerando cache 
                string jsonString = JsonSerializer.Serialize(value);
                byte[] bytesString = Encoding.UTF8.GetBytes(jsonString);

                string pathSaveCache = getPathSaveCache(_cacheConfig.PathCache);

                var fileDataSave = new FileData()
                {
                    FilePath = pathSaveCache,
                    FileName = filename,
                    FolderDestination = pathSaveCache,
                    FileData = bytesString
                };

                result = await _repositoryFileDisk.Save(fileDataSave);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public bool TryGet<T>(string cacheKey, out T value)
        {
            throw new NotImplementedException();
        }

        public async Task<KeyValuePair<bool, T>> TryGetAsync<T>(string cacheKey) where T : new()
        {
            bool result = false;
            string filename = string.Concat(cacheKey, _cacheConfig.ExtensionCache);
             
            string pathSaveCache = getPathSaveCache(_cacheConfig.PathCache);

            var criteriaFind = new FileData() { FilePath = pathSaveCache, FileName = filename };

            bool exists = _repositoryFileDisk.Exists(criteriaFind);

            if (exists)
            {
                byte[]? fileCacheByte = await _repositoryFileDisk.Get(criteriaFind);

                if (fileCacheByte != null)
                {
                    // Ler bytes e transformar em String json
                    string contentString = Encoding.UTF8.GetString(fileCacheByte, 0, fileCacheByte.Length);

                    T? resultCache = JsonSerializer.Deserialize<T>(contentString);
                    result = true;
                    return new KeyValuePair<bool, T>(result, resultCache);
                }
            }
            return new KeyValuePair<bool, T>(result, new());
        }

        private string getPathSaveCache(string pathCache)
        { 
            string currentDir = Directory.GetCurrentDirectory();
            string[] dirs = pathCache.Split('\\');

            string pathToSaveCache = Path.Combine(currentDir, dirs[0]);
            for (int i = 1; i < dirs.Length; i++)
            {
                pathToSaveCache = Path.Combine(pathToSaveCache, dirs[i]);
            }
            return pathToSaveCache;

        }
    }
}
