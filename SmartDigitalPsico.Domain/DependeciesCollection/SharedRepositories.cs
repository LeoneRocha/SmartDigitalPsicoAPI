using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedRepositories : ISharedRepositories
    {
        public IUserRepository UserRepository { get; }
        public IApplicationLanguageRepository ApplicationLanguageRepository { get; }

        public SharedRepositories(
            IUserRepository userRepository, IApplicationLanguageRepository applicationLanguageRepository)
        {
            UserRepository = userRepository;
            ApplicationLanguageRepository = applicationLanguageRepository;
        }
    }
}
