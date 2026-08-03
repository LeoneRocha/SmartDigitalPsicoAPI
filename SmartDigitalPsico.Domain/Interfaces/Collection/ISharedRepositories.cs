using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
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
