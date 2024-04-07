using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class ApplicationConfigure
    {
        public static void ConfigureApp(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration)
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
                using (var context = serviceScope.ServiceProvider.GetService<SmartDigitalPsicoDataContext>())
                { 
                    context?.Database.Migrate(); 
                }
            } 
        }
    }
}
