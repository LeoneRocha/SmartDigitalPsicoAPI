namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureLog
    {
        public static void Configure(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            //Add log 
            addLog(services, _logger);
        }
        private static void addLog(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            services.AddLogging();
            services.AddSingleton<Serilog.ILogger>(sp =>
            {
                return _logger;
            });
        }
    }
}