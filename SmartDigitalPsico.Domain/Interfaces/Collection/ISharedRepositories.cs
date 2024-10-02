using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface ISharedRepositories
    {
        IUserRepository UserRepository { get; }
        IApplicationLanguageRepository ApplicationLanguageRepository { get; }

        IApplicationConfigSettingRepository ApplicationConfigSettingRepository { get; }

        IEmailTemplateRepository EmailTemplateRepository { get; }
    }
}