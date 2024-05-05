using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using SmartDigitalPsico.Domain.VO;
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
            var message = $"{logType}-LEVEL: {ex.Message} at: {DataHelper.GetDateTimeNowToLog()}";
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


        public static AppInformationVersionProduct? GetInformationVersionProduct()
        {
            var assembly = Assembly.GetEntryAssembly();
            if (assembly != null)
            {
                var assemblyApp = assembly.GetName();

                var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                return new AppInformationVersionProduct() { Name = assemblyApp.Name, Version = assemblyApp.Version?.ToString(), EnvironmentName = envName };
            }
            return null;
        }

        public static string ShowInformationVersionProduct()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);
            var assemblyApp = GetInformationVersionProduct();

            if (assemblyApp != null)
            {
                sb.AppendFormat("Name: {0} - Version: {1} - {2} {3}", assemblyApp.Name, assemblyApp.Version, assemblyApp.EnvironmentName, Environment.NewLine);
            }
            else
            {
                sb.AppendFormat("Assembly information could not be retrieved.{0}", Environment.NewLine);
            }
            sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);

            return sb.ToString();
        }

        public static void PrintLogInformationVersionProduct(Serilog.ILogger logger)
        {
            logger.Information("******* PRODUCT INFORMATION *******");
            var assemblyApp = GetInformationVersionProduct(); 
            if (assemblyApp != null)
            {
                logger.Information("Name: {Name} - Version: {Version} - {envName}", assemblyApp.Name, assemblyApp.Version, assemblyApp.EnvironmentName);
            }
            else
            {
                logger.Information("Assembly information could not be retrieved.");
            }
            logger.Information("******* PRODUCT INFORMATION *******");
        }

        public static void Set_ASPNETCORE_ENVIRONMENT(IConfiguration configuration)
        {
            string? envVal = configuration["APP_ENVIRONMENT"];
            if (!string.IsNullOrEmpty(envVal))
            {
                Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", envVal);
            } 
        }
    }
}
