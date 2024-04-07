using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using System.Diagnostics;
using System.Reflection;

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

        public static void PrintLogInformationVersionProduct(ILogger logger)
        {
            logger.Information("PRODUCT INFORMATION");
            logger.Information("*******");

            var assembly = Assembly.GetEntryAssembly();
            if (assembly != null)
            {
                logger.Information("Name: {Name}", assembly.GetName().Name);
                logger.Information("Version: {Version}", assembly.GetName().Version);
            }
            else
            {
                logger.Information("Assembly information could not be retrieved.");
            }
            logger.Information("*******");
        }
    }
}
