using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.User;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por SharedRepositories.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class SharedRepositories : ISharedRepositories
    {
        public IUserRepository UserRepository { get; }
        public IApplicationLanguageRepository ApplicationLanguageRepository { get; }
        public IApplicationConfigSettingRepository ApplicationConfigSettingRepository { get; }



        /// <summary>
        /// Método SharedRepositories: executa a operação SharedRepositories.
        /// </summary>
        public SharedRepositories(
            IUserRepository userRepository,
            IApplicationLanguageRepository applicationLanguageRepository,
            IApplicationConfigSettingRepository applicationConfigSettingRepository,
            INotificationTemplateRepository notificationTemplateRepository)
        {
            UserRepository = userRepository;
            ApplicationLanguageRepository = applicationLanguageRepository;
            ApplicationConfigSettingRepository = applicationConfigSettingRepository;

        }
    }
}
