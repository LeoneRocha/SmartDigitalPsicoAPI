using System.Diagnostics;
using Azure.Monitor.OpenTelemetry.AspNetCore;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Serilog;
using Serilog.Context;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class WebApplicationConfigureBuilder
    {
        private const string ApplicationInsightsConnectionStringEnv = "APPLICATIONINSIGHTS_CONNECTION_STRING";

        public static (WebApplicationBuilder, Serilog.Core.Logger?) CreateHostBuilder(string[] args)
        {
            Serilog.Core.Logger? _logger;
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(builder.Configuration);

            _logger = LogAppHelper.CreateLogger(builder.Configuration);
            Log.Logger = _logger;

            //Service Collections.
            WebApplicationConfigureServiceCollections.Configure(builder.Services, builder.Configuration, _logger);

            // Bridge MEL → Serilog (aparecem no Console/File e, se habilitado, no Azure Monitor)
            builder.Host.UseSerilog(_logger, dispose: false);

            AddAzureMonitorOpenTelemetry(builder);

            return (builder, _logger);
        }

        public static void BuildAndRunAPP(WebApplicationBuilder builder, Serilog.Core.Logger? _logger)
        {
            if (_logger == null)
            {
                return;
            }

            try
            {
                var app = builder.Build();

                Configure(app, builder.Environment, builder.Configuration);

                LogAppHelper.PrintLogInformationVersionProduct(_logger);

                _logger.Information("Web API Loading at: {Time}", DateHelper.GetDateTimeNowToLog());
                app.Run();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Web API Error Loading at: {Message} at: {Time}", ex.Message, DateHelper.GetDateTimeNowToLog());
                throw new InvalidOperationException("Web API failed during startup or configuration.", ex);
            }
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            addAutoMigrate(app);

            app.UseHttpsRedirection();

            string diretorioTemp = DirectoryHelper.GetDiretoryTemp(configuration);

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(diretorioTemp),
                RequestPath = new PathString($"/{FolderConstants.ConstResourcesTemp}")
            });

            app.UseRouting();

            // Correlation TraceId/SpanId em cada request (logs + Azure traces)
            app.Use(async (context, next) =>
            {
                var activity = Activity.Current;
                using (LogContext.PushProperty("TraceId", activity?.TraceId.ToString() ?? context.TraceIdentifier))
                using (LogContext.PushProperty("SpanId", activity?.SpanId.ToString() ?? string.Empty))
                {
                    await next();
                }
            });

            app.UseSerilogRequestLogging(options =>
            {
                options.MessageTemplate =
                    "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms";
                options.EnrichDiagnosticContext = (diagnosticContext, httpContext) =>
                {
                    diagnosticContext.Set("RequestHost", httpContext.Request.Host.Value);
                    diagnosticContext.Set("RequestScheme", httpContext.Request.Scheme);
                    diagnosticContext.Set("UserAgent", httpContext.Request.Headers.UserAgent.ToString());
                };
            });

            app.UseCors();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                var assemblyVersion = LogAppHelper.GetAssemblyVersion();
                c.SwaggerEndpoint("/swagger/v1/swagger.json", $"SmartDigitalPsico.WebAPI {assemblyVersion}");
                c.DocumentTitle = $"SmartDigitalPsico.WebAPI {assemblyVersion}";
            });

            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");

            app.UseRewriter(option);

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute("DefaultApi", "{controller=values}/{id?}");
            });

            addCustomMiddleware(app);
        }

        private static void AddAzureMonitorOpenTelemetry(WebApplicationBuilder builder)
        {
            var connectionString =
                builder.Configuration[ApplicationInsightsConnectionStringEnv]
                ?? Environment.GetEnvironmentVariable(ApplicationInsightsConnectionStringEnv);

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                Log.Information(
                    "Azure Monitor OpenTelemetry disabled: set {EnvVar} to enable Application Insights traces/logs.",
                    ApplicationInsightsConnectionStringEnv);
                return;
            }

            builder.Services.AddOpenTelemetry().UseAzureMonitor(options =>
            {
                options.ConnectionString = connectionString;
            });

            Log.Information("Azure Monitor OpenTelemetry enabled (Application Insights).");
        }

        private static void addCustomMiddleware(IApplicationBuilder app)
        {
            app.UseMiddleware<RequestCultureMiddleware>();
        }

        private static void addAutoMigrate(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<IEntityDataContext>())
                {
                    context?.Database.Migrate();
                }
            }
        }
    }
}
