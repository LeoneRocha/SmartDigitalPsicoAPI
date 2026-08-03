using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Contracts
{
    /// <summary>
    /// Classe responsável por RecordsList.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class RecordsList<T>
    {
        public long UserIdLogged { get; set; }
        public User LoggedInUser { get; set; } = new User();
        public List<T> Records { get; set; } = new List<T>();
    } 
}
