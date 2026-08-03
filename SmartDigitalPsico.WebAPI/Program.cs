using Serilog;
using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    /// <summary>
    /// Classe responsável por Program.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Método Main: executa a operação Main.
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                var hostBuilder = WebApplicationConfigureBuilder.CreateHostBuilder(args);
                WebApplicationConfigureBuilder.BuildAndRunAPP(hostBuilder.Item1, hostBuilder.Item2);
            }
            finally
            {
                // Garante flush de Console/File/App Insights ao encerrar o processo (Azure + local)
                Log.CloseAndFlush();
            }
        }
    }
}
