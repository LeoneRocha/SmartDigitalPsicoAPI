using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Serilog;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class WebApplicationConfigureBuilder
    {
        public static (WebApplicationBuilder, Serilog.Core.Logger?) CreateHostBuilder(string[] args)
        {
            Serilog.Core.Logger? _logger;
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            _logger = LogAppHelper.CreateLogger(builder.Configuration);

            //Service Collections.
            WebApplicationConfigureServiceCollections.Configure(builder.Services, builder.Configuration, _logger);

            builder.Host.UseSerilog();
            return (builder, _logger);
        }

        public static void BuildAndRunAPP(WebApplicationBuilder builder, Serilog.Core.Logger? _logger)
        {
            if (_logger != null)
            {
                try
                {
                    LogAppHelper.Set_ASPNETCORE_ENVIRONMENT(builder.Configuration);

                    var app = builder.Build();

                    //Application Builder
                    Configure(app, builder.Environment, builder.Configuration);

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

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Migrate latest database changes during startup
            addAutoMigrate(app);

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            string diretorioTemp = DirectoryHelper.GetDiretoryTemp(configuration);

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(diretorioTemp),
                RequestPath = new PathString($"/{FolderConstants.ConstResourcesTemp}")
            });

            app.UseRouting();

            app.UseCors();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SmartDigitalPsico.WebAPI v1"));

            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");

            app.UseRewriter(option);

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //HyperMedia
                endpoints.MapControllerRoute("DefaultApi", "{controller=values}/{id?}");
            });

            addCustomMiddleware(app);
        }

        private static void addCustomMiddleware(IApplicationBuilder app)
        {
            app.UseMiddleware<RequestCultureMiddleware>(); 
        }
        private static void addAutoMigrate(IApplicationBuilder app)
        {
            // Migrate latest database changes during startup
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