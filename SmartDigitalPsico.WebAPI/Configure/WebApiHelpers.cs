using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.VO.Domains;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class WebApiHelpers
    {
        public static ETypeDataBase getTypeDataBase(IConfiguration configuration)
        {
            DataBaseConfigurationVO configDB = new DataBaseConfigurationVO();

            new ConfigureFromConfigurationOptions<DataBaseConfigurationVO>(configuration.GetSection("DataBaseConfigurations"))
                .Configure(configDB);
            return configDB.TypeDataBase;
        }

    }
}
