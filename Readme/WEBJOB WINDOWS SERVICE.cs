using MyCompany.MyProject.Domain.Helper;
using MyCompany.MyProject.Domain.Interfaces.Clients;
using MyCompany.MyProject.Services.Configure;
using MyCompany.MyProject.MyService.Services;
using Serilog;

namespace MyCompany.MyProject.Service 
{
    public static class Program
    {
        private const string AppServiceName = "My Service  ";
        private static Serilog.Core.Logger? _logger;
        public static void Main()
        {
            CreateHostBuilder().Build().Run();
        }
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                var env = hostingContext.HostingEnvironment;
                if (env.IsProduction())
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                }
                else
                {
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                }
                config.AddEnvironmentVariables();
            })
            .ConfigureServices((hostContext, services) =>
            {
                _logger = LogHelper.CreateLogger(hostContext.Configuration);

                services.AddLogging();

                _logger?.Information($"Config Environment: {hostContext.HostingEnvironment.EnvironmentName} ");

                ConfigurationDependencyInjection.ConfigureContext(services, hostContext);
                ConfigurationDependencyInjection.ConfigureService(services);

                services.AddWindowsService(options => { options.ServiceName = AppServiceName; });
                services.AddSingleton<IHostedService, Worker>();
                services.AddScoped<IMyProjectServiceUpload, MyProjectServiceUpload>();

                services.AddSingleton<Serilog.ILogger>(sp =>
                {
                    return _logger ?? LogHelper.CreateLogger(hostContext.Configuration);
                });
            })
            .UseWindowsService()
            .UseSerilog();
        }
    }
}

worker 

using MyCompany.MyProject.Domain.Helper;
using MyCompany.MyProject.Domain.Interfaces.Clients;
using MyCompany.MyProject.ServiceUpload.Services;

namespace MyCompany.MyProject.ServiceUpload
{
    public class Worker : BackgroundService
    {
        private readonly Serilog.ILogger _logger;
     
        public readonly IServiceProvider _serviceProvider;
        public readonly IConfiguration _configuration;
        public Worker(Serilog.ILogger logger, IConfiguration configuration, IServiceProvider serviceProvider)
        {
            _logger = logger ?? LogHelper.CreateLogger(configuration);
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Serviço [START] -> #MyCompany.MyProject.ServiceUpload#- StartAsync");

            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.Information("Serviço [STOP] -> #MyCompany.MyProject.ServiceUpload#- StartAsync");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int minutesDelay;
            LogHelper.PrintLogInformationVersionProduct(_logger);
            if (!int.TryParse(_configuration.GetSection("TaskDelayMinutes").Value, out minutesDelay))
            {
                minutesDelay = 1;
            }
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var servico = scope.ServiceProvider.GetRequiredService<IMyProjectServiceUpload>();

                        if (servico != null)
                        {
                            await servico.ExecuteProcessUpload(scope.ServiceProvider);
                        }
                        else
                        {
                            _logger.Error("ExecuteAsync Error: No load MyProjectService  at: {time}", DataHelper.GetDateTimeNowToLog());
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.Error(ex, "ExecuteAsync Error: {Message} at: {time}", ex.Message, DataHelper.GetDateTimeNowToLog());
                }
                await Task.Delay(minutesDelay * 60000, stoppingToken);
            }
        }
    }
}
------------------- WEB JOB 


using MyCompany.MyProject.Domain.Contracts;
using MyCompany.MyProject.Domain.Helper;
using MyCompany.MyProject.Domain.Interfaces.Clients;
using MyCompany.MyProject.Services.Configure;
using MyCompany.MyProject.WebJob.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace MyCompany.MyProject.WebJob
{
    static class Program
    {
        private static Serilog.Core.Logger? _logger;
        static async Task Main()
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddFiles();
            }).ConfigureAppConfiguration((hostingContext, config) =>
            {
                var env = hostingContext.HostingEnvironment;

                if (env.IsProduction())
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                }
                else
                {
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                }
                config.AddEnvironmentVariables();

            }).ConfigureServices((hostContext, services) =>
            {
                _logger = LogHelper.CreateLogger(hostContext.Configuration);
                services.AddLogging();

                ConfigurationDependencyInjection.ConfigureContext(services, hostContext);

                ConfigurationDependencyInjection.ConfigureService(services);

                services.AddSingleton<IMyProjectWebJob, MyProjectWebJob>();
                services.AddSingleton<Serilog.ILogger>(sp =>
                {
                    return _logger;
                });

            });
            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
            });
            var host = builder
                .UseSerilog()
                .Build();

            using (host)
            {
                var servico = host.Services.GetService<IMyProjectWebJob>();

                if (servico != null)
                {
                    if (_logger != null)
                    {
                        LogHelper.PrintLogInformationVersionProduct(_logger);
                    }
                    await servico.UnLockProcess(host);
                    await servico.ExecuteProcessWebJob(host);
                }
                else
                {
                    throw new ProcessConfigurationWarningException("ExecuteProcess Error: No load MyProjectServiceUpload.");
                }
            }
        }
    }
}
