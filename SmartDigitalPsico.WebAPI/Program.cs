

using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);

            createApp(builder);

        }

        private static void createApp(WebApplicationBuilder builder)
        {
            var app = builder.Build();
            ApplicationConfigure.ConfigureApp(app, builder.Environment, builder.Configuration); 
            app.Run();
        }

        public static WebApplicationBuilder CreateHostBuilder(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            ApplicationBuilderConfigure.ConfigureServices(builder.Services, builder.Configuration);

            return builder;
        }

    }
}
