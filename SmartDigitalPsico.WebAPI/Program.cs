using Serilog;
using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public static class Program
    {
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
