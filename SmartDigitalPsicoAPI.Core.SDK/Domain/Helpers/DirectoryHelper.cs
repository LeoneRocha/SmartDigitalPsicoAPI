using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por DirectoryHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Método GetDiretoryTemp: consulta e retorna dados.
        /// </summary>
        public static string GetDiretoryTemp(IConfiguration configuration)
        {
            string resourcesTemp = configuration?["AppSettings:ResourcesTemp"] ?? string.Empty;
            return GetDiretory(resourcesTemp);
        }

        /// <summary>
        /// Método GetDiretory: consulta e retorna dados.
        /// </summary>
        public static string GetDiretory(string pathCreate)
        {
            string pathResult;
            // Verifica se o caminho é absoluto
            if (Path.IsPathFullyQualified(pathCreate))
            {
                pathResult = pathCreate;
            }
            else
            {
                pathCreate = pathCreate.Replace(".", "");

                string currentDir = Directory.GetCurrentDirectory();
                string[] dirs = pathCreate.Split('/');
                pathResult = Path.Combine(currentDir, dirs[0]);
                for (int i = 1; i < dirs.Length; i++)
                {
                    pathResult = Path.Combine(pathResult, dirs[i]);
                }
            }
            // Verifica se o diretório existe, se não, cria o diretório
            if (!Directory.Exists(pathResult))
            {
                Directory.CreateDirectory(pathResult);
            }
            return pathResult;

        }

        /// <summary>
        /// Método GetPathSaveCache: consulta e retorna dados.
        /// </summary>
        public static string GetPathSaveCache(string pathCache)
        {
            string pathToSaveCache;
            // Verifica se o caminho é absoluto
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
            // Verifica se o diretório existe, se não, cria o diretório
            if (!Directory.Exists(pathToSaveCache))
            {
                Directory.CreateDirectory(pathToSaveCache);
            }
            return pathToSaveCache;
        }

    }
}
