using Serilog;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.WebAPI.Configure;

namespace SmartDigitalPsico.WebAPI
{
    public static class Program
    {
        private static Serilog.Core.Logger? _logger;
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);

            createApp(builder);
        }

        private static void createApp(WebApplicationBuilder builder)
        { 
            if (_logger != null)
            {
                try
                {
                    LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(builder.Configuration);
                    var app = builder.Build();
                    ApplicationConfigure.ConfigureApp(app, builder.Environment, builder.Configuration);
                    LogAppHelper.PrintLogInformationVersionProduct(_logger);
                    _logger.Information("Web API Loading at: {time}", DataHelper.GetDateTimeNowToLog());
                    app.Run();  
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "Web API Error Loading at: {Message} at: {time}", ex.Message, DataHelper.GetDateTimeNowToLog());
                }
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
            builder.Host.UseSerilog();
            return builder;
        }
    }
}