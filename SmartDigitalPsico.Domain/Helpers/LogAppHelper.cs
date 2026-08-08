using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using SmartDigitalPsicoAPI.Core.SDK.Domain.AppException;
using SmartDigitalPsico.Domain.DTO;
using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por LogAppHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class LogAppHelper
    {
        internal static Assembly? ProductAssemblyOverrideForTests { get; set; }

        internal static Func<Assembly?>? EntryAssemblyProviderForTests { get; set; }

        internal static Func<Assembly?>? EntryAssemblyFallbackForTests { get; set; }

        internal static bool ForceNullHostEnvironmentForTests { get; set; }

        internal static bool ForceNullEntryAssemblyForTests { get; set; }

        private static Assembly ResolveProductAssembly()
            => ProductAssemblyOverrideForTests
               ?? EntryAssemblyProviderForTests?.Invoke()
               ?? EntryAssemblyFallbackForTests?.Invoke()
               ?? (ForceNullEntryAssemblyForTests ? null : Assembly.GetEntryAssembly())
               ?? Assembly.GetExecutingAssembly();
        /// <summary>
        /// Método GetDurationStopwatch: consulta e retorna dados.
        /// </summary>
        public static string GetDurationStopwatch(Stopwatch stopwatch)
        {
            return TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).ToString(@"hh\:mm\:ss");
        }
        /// <summary>
        /// Método LogException: executa a operação LogException.
        /// </summary>
        public static void LogException(Serilog.ILogger logger, Exception ex, string logType)
        {
            var message = $"{logType}-LEVEL: {ex.Message} at: {SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowToLog()}";
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
        /// <summary>
        /// Método CreateLogger: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static Serilog.Core.Logger CreateLogger(IConfiguration configuration)
        {
            return new LoggerConfiguration()
                      .ReadFrom.Configuration(configuration)
                      .Enrich.FromLogContext()
                      .Enrich.WithProperty("Application", "SmartDigitalPsico.WebAPI")
                      .Enrich.WithProperty("MachineName", Environment.MachineName)
                      .CreateLogger();
        }

        /// <summary>
        /// Método GetInformationVersionProduct: consulta e retorna dados.
        /// </summary>
        public static AppInformationVersionProductDto GetInformationVersionProduct()
        {
            var assembly = ResolveProductAssembly();
            var appDto = new AppInformationVersionProductDto() { Name = "Unknown", Version = "Unknown", EnvironmentName = "Unknown" };

            var assemblyApp = assembly.GetName();
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? GetHostEnvironmentName();
            var nameApp = assemblyApp.Name!;
            var version = GetAssemblyVersion();

            appDto.Name = nameApp;
            appDto.Version = version;
            appDto.EnvironmentName = envName;

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);
            sb.AppendFormat("Name: {0} | Version: {1} | Environment: {2} {3}", appDto.Name, appDto.Version, appDto.EnvironmentName, Environment.NewLine);
            sb.AppendFormat("******* PRODUCT INFORMATION ******* {0}", Environment.NewLine);
            appDto.Message = sb.ToString();
            return appDto;
        }

        /// <summary>
        /// AssemblyVersion do entry assembly (estampado no build).
        /// </summary>
        public static string GetAssemblyVersion()
        {
            return ResolveProductAssembly().GetName().Version!.ToString();
        }
        private static string GetHostEnvironmentName()
        {
            // Obtém o nome do ambiente do host
            IHostEnvironment? hostEnvironment = ForceNullHostEnvironmentForTests
                ? null
                : new HostBuilder().UseContentRoot(AppContext.BaseDirectory).ConfigureHostConfiguration(config =>
                {
                    config.AddEnvironmentVariables();
                }).Build().Services.GetService(typeof(IHostEnvironment)) as IHostEnvironment;

            return hostEnvironment?.EnvironmentName ?? "Undefined";
        }

        /// <summary>
        /// Método ShowInformationVersionProductString: executa a operação ShowInformationVersionProductString.
        /// </summary>
        public static string ShowInformationVersionProductString()
        {
            return GetInformationVersionProduct().Message;
        }

        /// <summary>
        /// Método PrintLogInformationVersionProduct: executa a operação PrintLogInformationVersionProduct.
        /// </summary>
        public static void PrintLogInformationVersionProduct(Serilog.ILogger logger)
        {
            var assemblyApp = GetInformationVersionProduct();
            logger.Information("******* PRODUCT INFORMATION *******");
            logger.Information("Name: {Name} | Version: {Version} | Environment: {EnvironmentName}", assemblyApp.Name, assemblyApp.Version, assemblyApp.EnvironmentName);
        }

        /// <summary>
        /// Método Set_ASPNETCORE_ENVIRONMENT: configura estado ou dependencias.
        /// </summary>
        public static void Set_ASPNETCORE_ENVIRONMENT(IConfiguration configuration)
        {
            string envVal = ConfigurationAppSettingsHelper.GetValueStringConfiguration(configuration, "APP_ENVIRONMENT");
            if (!string.IsNullOrEmpty(envVal))
            {
                Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", envVal);
            }
        }

        // Método para encapsular chamadas a _logger.Information_
        /// <summary>
        /// Método LogInfo: executa a operação LogInfo.
        /// </summary>
        public static void LogInfo(ILogger logger, string message, params object[] args)
        {
            logger.Information(message, args);
        }

        // Método para encapsular chamadas a _logger.Error_
        /// <summary>
        /// Método LogError: executa a operação LogError.
        /// </summary>
        public static void LogError(ILogger logger, Exception ex, string message, params object[] args)
        {
            logger.Error(ex, message, args);
        }
    }
}
