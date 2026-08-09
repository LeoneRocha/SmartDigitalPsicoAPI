using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Contracts
{
    /// <summary>
    /// Classe responsável por Record.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class Record<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; } = new User();
        public T RecordEntity { get; set; } = default!;
    }
}
