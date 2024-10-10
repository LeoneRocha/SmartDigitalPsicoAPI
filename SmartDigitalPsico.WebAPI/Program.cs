using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public static class Program
    {
        private static Serilog.Core.Logger? _logger;
        public static void Main(string[] args)
        {
            var hostBuilder = ApplicationConfigureApplicationBuilder.CreateHostBuilder(args);

            ApplicationConfigureApplicationBuilder.BuildAndRunAPP(hostBuilder.Item1, hostBuilder.Item2);
        }
    }
}