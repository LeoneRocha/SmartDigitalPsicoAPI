using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public static class Program
    { 
        public static void Main(string[] args)
        {
            var hostBuilder = WebApplicationConfigureBuilder.CreateHostBuilder(args);

            WebApplicationConfigureBuilder.BuildAndRunAPP(hostBuilder.Item1, hostBuilder.Item2);
        }
    }
}