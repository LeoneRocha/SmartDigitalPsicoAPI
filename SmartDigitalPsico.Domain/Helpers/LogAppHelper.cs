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

                return new AppInformationVersionProduct() { Name = assemblyApp.Name, Version = assemblyApp.Version?.ToString() };
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
                sb.AppendFormat("Name: {0} - Version: {1} {2}", assemblyApp.Name, assemblyApp.Version, Environment.NewLine);
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
                logger.Information("Name: {Name} - Version: {Version}", assemblyApp.Name, assemblyApp.Version);
            }
            else
            {
                logger.Information("Assembly information could not be retrieved.");
            }
            logger.Information("******* PRODUCT INFORMATION *******");
        }
    }
}
