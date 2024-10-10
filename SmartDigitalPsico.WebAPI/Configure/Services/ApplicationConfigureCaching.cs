namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureCaching
    {
        public static void Configure(IServiceCollection services)
        {
            addCaching(services);
        }
        private static void addCaching(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
