using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.User;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por ISharedRepositories.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISharedRepositories
    {
        IUserRepository UserRepository { get; }
        IApplicationLanguageRepository ApplicationLanguageRepository { get; }

        IApplicationConfigSettingRepository ApplicationConfigSettingRepository { get; }
         
    }
}
