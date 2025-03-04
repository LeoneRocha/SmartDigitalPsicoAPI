using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using SmartDigitalPsico.Domain.AppException;
using SmartDigitalPsico.Domain.DTO;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class LogAppHelper
    {
        public static string GetDurationStopwatch(Stopwatch stopwatch)
        {
            return TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).ToString(@"hh\:mm\:ss");
        }
        public static void LogException(Serilog.ILogger logger, Exception ex, string logType)
        {
            var message = $"{logType}-LEVEL: {ex.Message} at: {DateHelper.GetDateTimeNowToLog()}";
            if (ex is AppWarningException)
            {
                message = message.Replace("-LEVEL:", "-Warning:");
                logger.Warning(message);
            }
            else
            {
                message = message.Replace("-LEVEL:", "-Error:");
                logger.Error(ex, message);
            }
        }
        public static Serilog.Core.Logger CreateLogger(IConfiguration configuration)
        {
            return new LoggerConfiguration()
                      .ReadFrom.Configuration(configuration)
                      .Enrich.FromLogContext()
                      .CreateLogger();
        }

        public static AppInformationVersionProductDto GetInformationVersionProduct()
        {
            var assembly = Assembly.GetEntryAssembly();
            var appDto = new AppInformationVersionProductDto() { Name = "Unknown", Version = "Unknown", EnvironmentName = "Unknown" };

            if (assembly != null)
            {
                var assemblyApp = assembly.GetName();
                if (assemblyApp != null)
                {
                    var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? GetHostEnvironmentName();
                    var nameApp = assemblyApp.Name ?? "Undefined";
                    var version = "Undefined";
                    if (assemblyApp.Version != null)
                        version = assemblyApp.Version.ToString();

                    appDto.Name = nameApp;
                    appDto.Version = version;
                    appDto.EnvironmentName = envName;

                    StringBuilder sb = new StringBuilder();

                    sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);
                    sb.AppendFormat("Name: {0} | Version: {1} | Environment: {2} {3}", appDto.Name, appDto.Version, appDto.EnvironmentName, Environment.NewLine);
                    sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);
                    appDto.Message = sb.ToString();
                }
            }
            else
            {
                appDto.Message = string.Format("Assembly information could not be retrieved.{0}", Environment.NewLine);
            }
            return appDto;
        }
        private static string GetHostEnvironmentName()
        {
            // Obtém o nome do ambiente do host
            var hostEnvironment = new HostBuilder().UseContentRoot(AppContext.BaseDirectory).ConfigureHostConfiguration(config =>
            {
                config.AddEnvironmentVariables();
            }).Build().Services.GetService(typeof(IHostEnvironment)) as IHostEnvironment;

            return hostEnvironment?.EnvironmentName ?? "Undefined";
        }

        public static string ShowInformationVersionProductString()
        {
            var assemblyApp = GetInformationVersionProduct();

            if (assemblyApp != null)
            {
                return assemblyApp.Message;
            }
            return "Assembly information could not be retrieved.";
        }

        public static void PrintLogInformationVersionProduct(Serilog.ILogger logger)
        {
            logger.Information("******* PRODUCT INFORMATION *******");
            var assemblyApp = GetInformationVersionProduct();
            if (assemblyApp != null)
            {
                logger.Information("Name: {Name} | Version: {Version} | Environment: {envName}", assemblyApp.Name, assemblyApp.Version, assemblyApp.EnvironmentName);
            }
            else
            {
                logger.Information("Assembly information could not be retrieved.");
            }
            logger.Information("******* PRODUCT INFORMATION *******");
        }

        public static void Set_ASPNETCORE_ENVIRONMENT(IConfiguration configuration)
        {
            string envVal = ConfigurationAppSettingsHelper.GetValueStringConfiguration(configuration, "APP_ENVIRONMENT");
            if (!string.IsNullOrEmpty(envVal))
            {
                Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", envVal);
            }
        }

        // Método para encapsular chamadas a _logger.Information_
        public static void LogInfo(ILogger logger, string message, params object[] args)
        {
            logger.Information(message, args);
        }

        // Método para encapsular chamadas a _logger.Error_
        public static void LogError(ILogger logger, Exception ex, string message, params object[] args)
        {
            logger.Error(ex, message, args);
        }
    }
}
