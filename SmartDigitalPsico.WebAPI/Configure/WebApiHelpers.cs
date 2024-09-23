using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.DTO.Domains;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class WebApiHelpers
    {
        public static ETypeDataBase getTypeDataBase(IConfiguration configuration)
        {
            DataBaseConfigurationDto configDB = new DataBaseConfigurationDto();

            new ConfigureFromConfigurationOptions<DataBaseConfigurationDto>(ConfigurationAppSettingsHelper.GetDataBaseConfigurations(configuration))
                .Configure(configDB);
            return configDB.TypeDataBase;
        }

    }
}
