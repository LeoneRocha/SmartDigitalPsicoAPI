using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public class Program
    { 
        private static Serilog.Core.Logger? _logger;
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);
            
            createApp(builder); 
        }

        private static void createApp(WebApplicationBuilder builder)
        {
            builder.Host.UseSerilog();
            try
            {
                _logger?.Information("Web API Loading at: {time}", DataHelper.GetDateTimeNowToLog());
                var app = builder.Build();
                ApplicationConfigure.ConfigureApp(app, builder.Environment, builder.Configuration);
                app.Run(); 
            }
            catch (Exception ex)
            {
                _logger?.Error(ex, "Web API Error Loading at: {Message} at: {time}", ex.Message, DataHelper.GetDateTimeNowToLog());
            } 
        }

        public static WebApplicationBuilder CreateHostBuilder(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            _logger = LogAppHelper.CreateLogger(builder.Configuration);

            ApplicationBuilderConfigure.ConfigureServices(builder.Services, builder.Configuration, _logger);
             
            //Test
            return builder;
        }
    }
}