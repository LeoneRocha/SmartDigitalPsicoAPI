using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class DirectoryHelper
    {
        public static string GetDiretoryTemp(IConfiguration configuration)
        {
            string resourcesTemp = ConfigurationAppSettingsHelper.GetAppSettingsResourcesTemp(configuration);
            return GetDiretory(resourcesTemp);
        }

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
    }
}
