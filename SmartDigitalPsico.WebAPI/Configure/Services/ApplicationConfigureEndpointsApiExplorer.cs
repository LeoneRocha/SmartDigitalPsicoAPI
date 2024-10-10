namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureEndpointsApiExplorer
    {
        public static void Configure(IServiceCollection services)
        {
            // 
            services.AddEndpointsApiExplorer();
        }

    }
}